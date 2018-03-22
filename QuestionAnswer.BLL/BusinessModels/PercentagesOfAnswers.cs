using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestionAnswer.BLL.DTO;
using QuestionAnswer.BLL.Interfaces;
using QuestionAnswer.DAL.Interfaces;

namespace QuestionAnswer.BLL.BusinessModels
{
    public class PercentagesOfAnswers : ICalculationOfPercentage<PercentageAnswers>
    {
        public List<PercentageAnswers> Calculation(IUnitOfWork uow)
        {

            var surveyType = uow.GetSurveyType.GetSurveyType();
            var anserType = uow.GetAnswerTypes.GetAllAnswerType();
            var AllUsersAnswers = uow.GetUserAnswers.GetAll();
            //get count survey type
            var countSurveyType = (from s in surveyType
                                   join a in AllUsersAnswers on s.Id equals a.SurveyTypeId into g
                                   select new
                                   {
                                       Id = s.Id,
                                       Count = Convert.ToDouble(g.Count(x=>x.SurveyTypeId >0))
                                   }).ToList();
            //group user answer by surbey type and answer type
            var groupUsersAnswersBySurveyType = (from s in surveyType
                                                 join a in AllUsersAnswers on s.Id equals a.SurveyTypeId
                                                 group a by new { a.SurveyTypeId, a.AnswerTypeId } into g
                                                 select new
                                                 {
                                                     SurveyTypeId = g.Key.SurveyTypeId,
                                                     AnswerTypeId = g.Key.AnswerTypeId,
                                                     Percentage = Convert.ToDouble(g.Count(x=>x.AnswerTypeId >0))
                                                 }).ToList();

            var percentageList = (from g in groupUsersAnswersBySurveyType
                                  join s in surveyType on g.SurveyTypeId equals s.Id
                                  join a in anserType on g.AnswerTypeId equals a.Id
                                  join c in countSurveyType on g.SurveyTypeId equals c.Id
                                  select new PercentageAnswers
                                  {
                                      SurveyTypeId = g.SurveyTypeId,
                                      AnswerTypeId = g.AnswerTypeId,
                                      AnswerTypetext = a.Type,
                                      SurveyTypeText = s.TypeName,
                                      Percentage = g.Percentage * 100 / c.Count
                                  }).ToList();

            return percentageList;
        }
    }
}
