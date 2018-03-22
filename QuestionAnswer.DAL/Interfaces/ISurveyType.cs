using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionAnswer.DAL.Interfaces
{
    public interface ISurveyType<T> where T:class
    {
        List<T> GetSurveyType();
    }
}
