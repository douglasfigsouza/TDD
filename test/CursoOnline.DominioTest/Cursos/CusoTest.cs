using Xunit;

namespace CursoOnline.DominioTest.Cursos
{
    public class CusoTest
    {
        [Fact]
        public void DeveCriarCurso()
        {
            var nome = "informatica";
            int cargaHoraria = 80;
            var publicoAlvo = "estudantes";
            decimal valor = 950;

            var curso = new Curso(nome, cargaHoraria, publicoAlvo, valor);

            Assert.Equal(nome, curso.Nome);
            Assert.Equal(cargaHoraria, curso.CargaHoraria);
            Assert.Equal(publicoAlvo, curso.PublicoAlvo);
            Assert.Equal(valor, curso.Valor);


        }
    }

    public class Curso
    {
        public Curso(string nome, int cargaHoraria, string publicoAlvo, decimal valor)
        {
            Nome = nome;
            CargaHoraria = cargaHoraria;
            PublicoAlvo = publicoAlvo;
            Valor = valor;
        }

        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
        public string PublicoAlvo { get; set; }
        public decimal Valor { get; set; }
    }
}
