using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;

namespace QuestionAnswer.App_Start
{
    public class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.Initialize(cfg => cfg.AddProfiles(new[]
            {
                "QuestionAnswer",
                "QuestionAnswer.BLL"
            }));
        }
    }
}