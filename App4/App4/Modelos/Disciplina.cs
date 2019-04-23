using System;
using System.Collections.Generic;
using System.Text;

namespace App4.Modelos
{
    class Disciplina
    {
        // atributo nome
        private String nome;

        public String Nome
        {
            get
            {
                return this.nome;
            }
        }

        // atributo semestre
        private int semestre;

        public int Semestre
        {
            get
            {
                return this.semestre;
            }
        }

        // atributo professor
        private int professor;

        public int Professor
        {
            get
            {
                return this.professor;
            }
        }

        // construtor da classe
        public Disciplina(String nome, int semestre, int professor)
        {
            this.nome = nome;
            this.semestre = semestre;
            this.professor = professor;
        }

        // método para verificar se o professor leciona a disciplina 
        public bool Lecionar(Professor professor)
        {
            // retorna se o código do professor é o mesmo da disciplina
            return this.professor == professor.Codigo;
        }

    }
}