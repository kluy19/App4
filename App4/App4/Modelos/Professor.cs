using System;
using System.Collections.Generic;
using System.Text;

namespace App4.Modelos
{
    class Professor
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

        // atributo codigo
        private int codigo;

        public int Codigo
        {
            get
            {
                return this.codigo;
            }
        }

        // construtor da classe
        public Professor(String nome, int codigo)
        {
            this.nome = nome;
            this.codigo = codigo;
        }

    }
}
