using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using QuestionAnswer.Models;
using QuestionAnswer.BLL.DTO;

namespace QuestionAnswer.AutoMapperPresentation
{
    public class AutoMapperPresentationProfile : Profile
    {
        public AutoMapperPresentationProfile()
        {
            CreateMap<QuestionDTO, QuestionViewModel>()
            .ForMember("SurveyId", srv => srv.MapFrom(c => c.SurveyId))
           .ForMember("QuestionId", srv => srv.MapFrom(c => c.QuestionId))
           .ForMember("QuestionText", srv => srv.MapFrom(c => c.QuestionText))
           .ForMember("AnswerTypeId", srv => srv.MapFrom(c => c.AnswerTypeId))
           .ForMember("AnswerTypeText", srv => srv.MapFrom(c => c.AnswerTypeText))
           .ForMember("VariantsOfAnswersViewModel", srv => srv.MapFrom(c => c.VariantsOfAnswersDTO));
            CreateMap<SurveyDTO, SurveyViewModel>();
            CreateMap<UsersAnswersDTO, UsersAnswersViewModel>();
            CreateMap<UsersAnswersViewModel, UsersAnswersDTO>();
            CreateMap<AnswerTypeDTO, AnswerTypeViewModel>();
            CreateMap<PercentageAnswers, PercentageAnswersViewModel>();
            CreateMap<SurveyTypeDTO, SurveyTypeViewModel>();
        }
    }
}