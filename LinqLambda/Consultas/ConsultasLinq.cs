using System.Collections.Generic;
using System.Linq;
using LinqLambda.Consultas;

namespace LinqLambda
{
    public class ConsultasLinq
    {
        private List<Aluno> TabelaAlunos { get; set; }
        private List<Curso> TabelaCursos { get; set; }
        private List<Professor> TabelaProfessores { get; set; }
        private List<Turma> TabelaTurmas { get; set; }
        public ConsultasLinq()
        {
            TabelaAlunos = PreenchimentoDeDados.CriarAlunos();
            TabelaCursos = PreenchimentoDeDados.CriarCursos();
            TabelaProfessores = PreenchimentoDeDados.CriarProfessores();
            TabelaTurmas = PreenchimentoDeDados.CriarTurma();
        }

        public List<string> SelecionarNomeDosAlunos()
        {
            return (from tabAlunos in TabelaAlunos
                    orderby tabAlunos.Nome ascending
                    select tabAlunos.Nome)
                    .ToList();
        }

        public List<string> SelecionarProfessorPorCurso(int idCurso)
        {
            return (from tabProfessores in TabelaProfessores
                    where tabProfessores.AptoParaCursos.Contains(idCurso)
                    orderby tabProfessores.Nome ascending
                    select tabProfessores.Nome)
                .ToList();
        }

        public bool VerificarSeCursoExiste(string palavraChave)
        {
            return (from tabCursos in TabelaCursos
                    select tabCursos)
                .Any(x => x.Descricao.Contains(palavraChave));
        }

        public object SelecionarDadosDaTurma()
        {
            return (from tabTurma in TabelaTurmas
                    join tabProf in TabelaProfessores on tabTurma.IdProfessor equals tabProf.Id
                    select new {Turma = tabTurma, Professor = tabProf})
                    .ToList();
        }
    }
}