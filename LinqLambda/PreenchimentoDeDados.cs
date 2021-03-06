﻿using System;
using System.Collections.Generic;
using LinqLambda.Consultas;

namespace LinqLambda
{
    public class PreenchimentoDeDados
    {
        public static List<Aluno> CriarAlunos()
        {
            return new List<Aluno>()
            {
                new Aluno()
                {
                    Id = 1,
                    Nome = "João",
                    Telefone = "1111-1111",
                    DataNasc = new DateTime(1990, 05, 20),
                    Email = "joao@hotmail.com"
                },
                new Aluno()
                {
                    Id = 2,
                    Nome = "Maria",
                    Telefone = "1111-1112",
                    DataNasc = new DateTime(1990, 05, 30),
                    Email = "maria@hotmail.com"
                },
                new Aluno()
                {
                    Id = 3,
                    Nome = "Joaquim",
                    Telefone = "1111-1113",
                    DataNasc = new DateTime(1990, 03, 30),
                    Email = "joaquim@hotmail.com"
                },
                new Aluno()
                {
                    Id = 4,
                    Nome = "Mariana",
                    Telefone = "1111-1114",
                    DataNasc = new DateTime(1990, 03, 03),
                    Email = "mari@hotmail.com"
                }
            };
        }

        public static List<Curso> CriarCursos() =>
            new List<Curso>()
            {
                new Curso()
                {
                    Id = 1,
                    NomeDoCurso = "Aceleração de C#",
                    Descricao = "Curso intensivo de C# para iniciantes"
                },
                new Curso()
                {
                    Id = 2,
                    NomeDoCurso = "Aceleração de React",
                    Descricao = "Curso intensivo de React para iniciantes"
                },
                new Curso()
                {
                    Id = 3,
                    NomeDoCurso = "Aceleração de Ciência de Dados",
                    Descricao = "Curso intensivo de Ciência de Dados para iniciantes"
                }
            };

        public static List<Professor> CriarProfessores()
        {
            return new List<Professor>()
            {
                new Professor()
                {
                    Id = 1,
                    Nome = "Ricardo",
                    DataNasc = new DateTime(1960, 8, 27),
                    Email = "ricardo@gmail.com",
                    Telefone = "3332-9573",
                    AptoParaCursos = new List<int>() {1, 2, 3}
                },
                new Professor()
                {
                    Id = 2,
                    Nome = "Thamirys",
                    DataNasc = new DateTime(1988, 9, 30),
                    Email = "thamirys@gmail.com",
                    Telefone = "2222-2222",
                    AptoParaCursos = new List<int>(){1}
                },
                new Professor()
                {
                    Id = 3,
                    Nome = "Coelho",
                    DataNasc = new DateTime(1971, 12, 15),
                    Email = "acvcoelho@gmail.com",
                    Telefone = "2254-1234",
                    AptoParaCursos = new List<int>(){2}
                }
            };
        }

        public static List<Turma> CriarTurma()
        {
            return new List<Turma>()
            {
                new Turma()
                {
                    Id = 1,
                    Alunos = new List<int>(){1, 2, 3},
                    IdCurso = 1,
                    IdProfessor = 1,
                    NomeDaTurma = "Aceleração de C# do prof. Ricardo"
                }
            };
        }
    }
}