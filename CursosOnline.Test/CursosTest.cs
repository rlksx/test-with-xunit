using Xunit;
namespace CursosOnline.Test;

public class CursosTest
{
   [Fact]
   public void criar_curso_valido()
   {
      // Arrange
      string nome = "Teste1";
      double cargaHoraria = 80;
      string publicoAlvo = "Universitarios";
      double valor = 120;

      // Act
      var curso = new Curso(nome, cargaHoraria, publicoAlvo, valor);

      // Assert

   }

   [Fact]
   public void criar_aula_valida()
   {

   }
}

public class Curso
{
   public string nome { get; private set; }
   public double cargaHoraria { get; private set; }
   public string publicoAlvo { get; private set; }
   public double valor { get; private set; }


   public Curso(string nome, double cargaHoraria, string publicoAlvo, double valor)
   {
      this.nome = nome;
      this.cargaHoraria = cargaHoraria;
      this.publicoAlvo = publicoAlvo;
      this.valor = valor;
   }
}