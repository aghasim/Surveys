using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestionAnswer.DAL.EF;
using QuestionAnswer.DAL.Entities;
using QuestionAnswer.DAL.Interfaces;

namespace QuestionAnswer.DAL.Repositories
{
    public class VariantsOfAnswersRepositories : IVariantsOfAnswers<VariantsOfAnswers>
    {
        private QuestionAnswerContext db;
        public VariantsOfAnswersRepositories(QuestionAnswerContext context)
        {
            this.db = context;
        }
        public List<VariantsOfAnswers> GetVariantsOfAnswersByQuestionId(int id)
        {
            return db.VariantsOfAnswers.Where(v => v.QuestionId == id).ToList();
        }
    }
}
