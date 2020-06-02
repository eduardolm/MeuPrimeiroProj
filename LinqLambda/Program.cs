using System;

namespace LinqLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsultasLambda lambdas = new ConsultasLambda();
            ConsultasLinq linq = new ConsultasLinq();

            lambdas.SelecionarNomeDosAlunos().ForEach(x => { Console.WriteLine($"Alunos por lambda: {x}"); });
            
            linq.SelecionarNomeDosAlunos().ForEach(x => { Console.WriteLine($"Alunos por linq: {x}"); });

            lambdas.SelecionarProfessorPorCurso(1).ForEach(x => { Console.WriteLine($"Professores por lambda: {x}"); });
            
            linq.SelecionarProfessorPorCurso(2).ForEach(x => { Console.WriteLine($"Professores por linq: {x}"); });

            Console.WriteLine(lambdas.VerificarSeCursoExiste("Java"));
            Console.WriteLine(linq.VerificarSeCursoExiste("React"));

            var turmaLambda = lambdas.SelecionarDadosDaTurma();
            var turmaLinq = linq.SelecionarDadosDaTurma();
            
            
        }
    }
}