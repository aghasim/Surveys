using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestionAnswer.DAL.Interfaces;
using QuestionAnswer.DAL.Entities;
using QuestionAnswer.DAL.EF;

namespace QuestionAnswer.DAL.Repositories
{
    public class AnswerTypeRepositories : IAnswerType<AnswerType>
    {
        private QuestionAnswerContext db;
        public AnswerTypeRepositories(QuestionAnswerContext context)
        {
            this.db = context;
        }
        public void CreateAnswerType(AnswerType answerType)
        {
            db.AnswerTypes.Add(answerType);
        }

        public List<AnswerType> GetAllAnswerType()
        {
            return db.AnswerTypes.ToList();
        }
    }
}
