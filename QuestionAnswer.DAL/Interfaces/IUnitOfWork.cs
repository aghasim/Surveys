using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestionAnswer.DAL.Entities;

namespace QuestionAnswer.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ISurvey<Survey> GetSurveys { get; }
        IUserAnswer<UsersAnswers> GetUserAnswers { get; }
        IQuestions<Question> GetQuestions { get; }
        IVariantsOfAnswers<VariantsOfAnswers> GetVariantsOfAnswers { get; }
        IAnswerType<AnswerType> GetAnswerTypes { get; }
        ISurveyType<SurveyType> GetSurveyType { get; }
        void Save();
    }
}
