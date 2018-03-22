using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject.Modules;
using QuestionAnswer.BLL.Interfaces;
using QuestionAnswer.BLL.Services;

namespace QuestionAnswer.Util
{
    public class ServicesWebModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IServices>().To<DALBLLServices>();
        }
    }
}