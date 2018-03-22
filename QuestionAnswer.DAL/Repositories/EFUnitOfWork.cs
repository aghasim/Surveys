using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using QuestionAnswer.DAL.Interfaces;
using QuestionAnswer.DAL.Entities;
using QuestionAnswer.DAL.EF;

namespace QuestionAnswer.DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    { 
        private QuestionAnswerContext db;
        private SurveyRepositories surveyRepositories;
        private AnswerRepositories answerRepositories;
        private QuestionsRepositories questionsRepositories;
        private AnswerTypeRepositories answerTypeRepositories;
        private VariantsOfAnswersRepositories variantsOfAnswersRepositories;
        private SurveyTypeRepositories surveyTypeRepositories;
        public EFUnitOfWork(string connectionString)
        {
            db = new QuestionAnswerContext(connectionString);
        }

        public ISurveyType<SurveyType> GetSurveyType
        {
            get
            {
                if (surveyTypeRepositories == null)
                    surveyTypeRepositories = new SurveyTypeRepositories(db);
                return surveyTypeRepositories;
            }
        }
        public IAnswerType<AnswerType> GetAnswerTypes
        {
            get
            {
                if (answerTypeRepositories == null)
                    answerTypeRepositories = new AnswerTypeRepositories(db);
                return answerTypeRepositories;
            }
        }
        public ISurvey<Survey> GetSurveys
        {
            get
            {
                if (surveyRepositories == null)
                    surveyRepositories = new SurveyRepositories(db);
                return surveyRepositories;
            }
        }

        public IUserAnswer<UsersAnswers> GetUserAnswers
        {
            get
            {
                if (answerRepositories == null)
                    answerRepositories = new AnswerRepositories(db);
                return answerRepositories;
            }
        }

        public IQuestions<Question> GetQuestions
        {
            get
            {
                if (questionsRepositories == null)
                    questionsRepositories = new QuestionsRepositories(db);
                return questionsRepositories;
            }
        }

        public IVariantsOfAnswers<VariantsOfAnswers> GetVariantsOfAnswers
        {
            get
            {
                if (variantsOfAnswersRepositories == null)
                    variantsOfAnswersRepositories = new VariantsOfAnswersRepositories(db);
                return variantsOfAnswersRepositories;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }


        //Dispose
        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        
    }
}
