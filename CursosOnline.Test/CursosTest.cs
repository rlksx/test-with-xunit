using ExpectedObjects;
using Xunit;

namespace CursosOnline.teste;

public class CursosTetse
{

   // private readonly object _curso;

   [Fact]
   public void criar_curso()
   {
      // Arrange
      var curso = new
      {
         nome = "Nutrição",
         cargaHoraria = (double)60,
         publico = "Profisional",
         valor = (double)120
      };
      
      // Act 
      Curso Curso = new Curso(curso.nome, curso.cargaHoraria, curso.publico, curso.valor);

      //Assert 
      curso.ToExpectedObject().ShouldMatch(Curso);
   }

   [Theory]
   [InlineData("")]
   [InlineData(null)]
   public void validar_campo_nome(string _nome)
   {
      // Arrange
      var curso = new
      {
         nome = "Nutrição Esportiva",
         cargaHoraria = (double)22,
         publico = "Profisional",
         valor = (double)39.99
      };

      // Act
      Assert.Throws<ArgumentException>(
         () => new Curso(_nome, curso.cargaHoraria, curso.publico, curso.valor));
   }

   [Theory]
   [InlineData(0)]
   [InlineData(-1)]
   public void validar_campo_carga_horaria(double _cargaHoraria)
   {
      // Arrange
      var curso = new
      {
         nome = "Nutrição Esportiva",
         cargaHoraria = (double)22,
         publico = "Profisional",
         valor = (double)39.99
      };

      // Act & Assert
      Assert.Throws<ArgumentException>(
         () => new Curso(curso.nome, _cargaHoraria, curso.publico, curso.valor)
      ).Message.Equals("Carga horária inválida");
   }
}

public class Curso
{
   // Campos
   public string Nome { get; private set; }
   public double CargaHoraria { get; private set; }
   public string Publico { get; private set; }
   public double Valor { get; private set; }
   public double Desconto { get; set; }

   public Curso(string nome, double cargaHoraria, string publico, double valor, double desconto = 0)
   {

      // if (nome == string.Empty) throw new ArgumentException();
      // if (nome == null) throw new ArgumentException();
      if (string.IsNullOrEmpty(nome)) throw new ArgumentException("Nome inválido");
      if(cargaHoraria <= 0) throw new ArgumentException("Carga horária inválida");

      this.Nome = nome;
      this.CargaHoraria = cargaHoraria;
      this.Desconto = desconto;
      this.Publico = publico;
      this.Valor = valor;
   }
}