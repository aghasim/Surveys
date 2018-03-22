using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestionAnswer.DAL.Interfaces;

namespace QuestionAnswer.BLL.BusinessModels
{
    public interface ICalculationOfPercentage<T> where T:class
    {
        List<T> Calculation(IUnitOfWork uow);
    }
}
