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
    public class AnswerRepositories : IUserAnswer<UsersAnswers>
    {
        private QuestionAnswerContext db;
        public AnswerRepositories(QuestionAnswerContext context)
        {
            this.db = context;
        }
        public void Create(List<UsersAnswers> item)
        {
            db.UsersAnswers.AddRange(item);
        }

        public List<UsersAnswers> GetAll()
        {
            return db.UsersAnswers.ToList();
        }
    }
}
