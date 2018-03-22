using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestionAnswer.DAL.EF;
using QuestionAnswer.DAL.Entities;

namespace QuestionAnswer.DAL.Interfaces
{
    public interface ISurvey<T> where T : class
    {
        //получить анкету с базы
        T GetById(int id);
        //получить все анкеты с базы
        List<T> GetAll();
    }
}
