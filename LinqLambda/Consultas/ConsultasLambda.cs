using System.Collections.Generic;
using System.Linq;
using LinqLambda.Consultas;

namespace LinqLambda
{
    public class ConsultasLambda
    {
        private List<Aluno> TabelaAlunos { get; set; }
        
        private List<Curso> TabelaCursos { get; set; }
        
        private List<Professor> TabelaProfessores { get; set; }
        
        private List<Turma> TabelaTurmas { get; set; }

        public ConsultasLambda()
        {
            TabelaAlunos = PreenchimentoDeDados.CriarAlunos();
            TabelaCursos = PreenchimentoDeDados.CriarCursos();
            TabelaProfessores = PreenchimentoDeDados.CriarProfessores();
            TabelaTurmas = PreenchimentoDeDados.CriarTurma();
        }

        public List<string> SelecionarNomeDosAlunos()
        {
            return TabelaAlunos.Select(x => x.Nome).ToList();
        }

        public List<string> SelecionarProfessorPorCurso(int idCurso)
        {
            return TabelaProfessores
                .Where(x=>x.AptoParaCursos.Contains(idCurso))
                .OrderBy(x=>x.Nome)
                .Select(x => x.Nome).ToList();
        }

        public bool VerificarSeCursoExiste(string palavraChave)
        {
            return TabelaCursos.Any(x => x.Descricao.Contains(palavraChave));
        }

        public object SelecionarDadosDaTurma()
        {
            return TabelaTurmas.Join(
                TabelaProfessores,
                turma => turma.IdProfessor,
                prof => prof.Id,
                (turma, professor) => new {Turma = turma, Professor = professor});
        }
    }
}