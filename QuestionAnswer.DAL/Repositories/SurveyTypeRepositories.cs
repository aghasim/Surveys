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
    public class SurveyTypeRepositories : ISurveyType<SurveyType>
    {
        private QuestionAnswerContext db;
        public SurveyTypeRepositories(QuestionAnswerContext context)
        {
            this.db = context;
        }
        public List<SurveyType> GetSurveyType()
        {
            return db.SurveyTypes.ToList();
        }
    }
}
