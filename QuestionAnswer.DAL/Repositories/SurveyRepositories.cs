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
    public class SurveyRepositories : ISurvey<Survey>
    {
        private QuestionAnswerContext db;
        public SurveyRepositories(QuestionAnswerContext context)
        {
            this.db = context;
        }

        public List<Survey> GetAll()
        {
            return db.Surveys.ToList();
        }

        public Survey GetById(int id)
        {
            return db.Surveys.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
