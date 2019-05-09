using System;
using System.Collections.Generic;
using System.Text;

namespace App4.Modelos
{
    static class Listas
    {

        /*public static Aluno[] Alunos = new Aluno[3]
      {
             new Aluno("João", 1, 1),
             new Aluno("Pedro", 2, 2),
             new Aluno("Maria", 3, 3),
             
      };*/
        public static List<Aluno> Alunos = new List<Aluno>();

        public static Disciplina[] Disciplinas = new Disciplina[4]
       {
             new Disciplina("Cálculo 1", 1, 1),
             new Disciplina("Introdução a Engenharia", 2, 2),
             new Disciplina("Cálculo 2", 3, 3),
             new Disciplina("Projetos de Engenharia", 4, 4)
       };

    }
}
