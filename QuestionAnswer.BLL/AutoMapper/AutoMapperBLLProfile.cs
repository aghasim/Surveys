using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestionAnswer.DAL.Entities;
using QuestionAnswer.BLL.DTO;
using AutoMapper;

namespace QuestionAnswer.BLL.AutoMapper
{
    public class AutoMapperBLLProfile : Profile
    {
        public AutoMapperBLLProfile()
        {
            CreateMap<Survey, SurveyDTO>()
            .ForMember("SurveyId", srv => srv.MapFrom(c => c.Id))
            .ForMember("SurveyTitle", srv => srv.MapFrom(c => c.Title))
            .ForMember("SurveyTypeId", srv => srv.MapFrom(c => c.SurveyType.Id))
            .ForMember("SurveyTypeName", srv => srv.MapFrom(c => c.SurveyType.TypeName));

            CreateMap<Question, QuestionDTO>()
           .ForMember("SurveyId", srv => srv.MapFrom(c => c.SurveyId))
           .ForMember("QuestionId", srv => srv.MapFrom(c => c.Id))
           .ForMember("QuestionText", srv => srv.MapFrom(c => c.QuestionText))
           .ForMember("AnswerTypeId", srv => srv.MapFrom(c => c.AnswerTypeId))
           .ForMember("AnswerTypeText", srv => srv.MapFrom(c => c.AnswerType.Type))
           .ForMember("VariantsOfAnswersDTO", srv => srv.MapFrom(c => c.VariantsOfAnswers));

            CreateMap<VariantsOfAnswers, VariantsOfAnswersDTO>()
           .ForMember("Id", voa => voa.MapFrom(c => c.Id))
           .ForMember("Questionid", voa => voa.MapFrom(c => c.QuestionId))
           .ForMember("AnswerText", voa => voa.MapFrom(c => c.AnswerText));
            //.ForMember("IsChecked",voa=>voa.MapFrom(c=>c.));

            CreateMap<UsersAnswers, UsersAnswersDTO>()
            .ReverseMap();

            CreateMap<UsersAnswersDTO, UsersAnswers>()
           .ForMember("SurveyTypeId", usa => usa.MapFrom(c => c.SurveyTypeId))
           .ForMember("SurveyId", usa => usa.MapFrom(c => c.SurveyId))
           .ForMember("QuestionId", usa => usa.MapFrom(c => c.QuestionId))
           .ForMember("AnswerTypeId", usa => usa.MapFrom(c => c.AnswerTypeId))
           .ForMember("VariantsOfAnswerId", usa => usa.MapFrom(c => c.VariantsOfAnswerId))
           .ForMember("Answer", usa => usa.MapFrom(c => c.Answer));


            CreateMap<AnswerType, AnswerTypeDTO>();
            CreateMap<SurveyType, SurveyTypeDTO>();
        }

    }
}
