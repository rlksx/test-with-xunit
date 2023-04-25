using ExpectedObjects;
using Xunit;

namespace CursosOnline.teste;

public class CursosTetse
{
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
      this.Nome = nome;
      this.CargaHoraria = cargaHoraria;
      this.Desconto = desconto;
      this.Publico = publico;
      this.Valor = valor;
   }
}