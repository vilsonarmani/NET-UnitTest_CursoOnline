using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CursoOnline.DominioTest.Cursos
{
    public class CursoTest
    {
        [Fact]
        public void DeveCriarCurso()
        {
            const string nome = "Informática Basica";
            const double cargaHoraria = 80;
            const string publicoAlvo = "Estudantes";
            const double valor = 950;

            var curso = new Curso(nome, cargaHoraria, publicoAlvo, valor);

            Assert.NotNull(curso);
            Assert.Equal(nome, curso.Nome);
            Assert.Equal(cargaHoraria, curso.CargaHoraria);
            Assert.Equal(publicoAlvo, curso.PublicoAlvo);
            Assert.Equal(valor, curso.Valor);

        }

        private class Curso
        {
            public string Nome { get; private set; }
            public double CargaHoraria { get; private set; }
            public string PublicoAlvo { get; private set; }
            public double Valor { get; private set; }

            public Curso(string nome, double cargaHoraria, string publicoAlvo, double valor)
            {
                this.Nome = nome;
                this.CargaHoraria = cargaHoraria;
                this.PublicoAlvo = publicoAlvo;
                this.Valor = valor;
            }
        }
    }
}
