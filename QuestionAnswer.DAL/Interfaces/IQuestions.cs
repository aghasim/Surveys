using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestionAnswer.DAL.Entities;

namespace QuestionAnswer.DAL.Interfaces
{
    public interface IQuestions<T> where T:Question
    {
        List<T> GetQuestionBySurveyId(int id);
    }
}
