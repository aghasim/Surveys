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
    public class QuestionsRepositories : IQuestions<Question>
    {
        private QuestionAnswerContext db;
        public QuestionsRepositories(QuestionAnswerContext context)
        {
            this.db = context;
        }
        public List<Question> GetQuestionBySurveyId(int id)
        {
            return db.Questions.Where(q => q.SurveyId == id).ToList();
        }
    }
}
