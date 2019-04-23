using System;
using System.Collections.Generic;
using System.Text;

namespace App4.Modelos
{
    class Nota
    {
        
        // atributo aluno
        private String aluno;

        public String Aluno
        {
            get
            {
                return this.aluno;
            }
        }

        // atributo disciplina
        private String disciplina;

        public String Disciplina
        {
            get
            {
                return this.disciplina;
            }
        }

        // atributo valor
        private int valor;

        public int Valor
        {
            get
            {
                return this.valor;
            }
        }

        // construtor da classe
        public Nota(String aluno, String disciplina, int valor)
        {
            this.aluno = aluno;
            this.disciplina = disciplina;
            this.valor = valor;
        }

        // método para verificar se o aluno foi aprovado na disciplina
        public bool Aprovar()
        {
            return this.valor >= 6;
        }

    }
}
