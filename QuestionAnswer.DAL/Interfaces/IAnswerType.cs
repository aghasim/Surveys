using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestionAnswer.DAL.Entities;

namespace QuestionAnswer.DAL.Interfaces
{
    public interface IAnswerType<T> where T : AnswerType
    {
        List<AnswerType> GetAllAnswerType();
        void CreateAnswerType(AnswerType answerType);
    }
}
