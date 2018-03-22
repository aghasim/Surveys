using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestionAnswer.BLL.DTO;
using QuestionAnswer.DAL.Entities;
using QuestionAnswer.BLL.BusinessModels;

namespace QuestionAnswer.BLL.Interfaces
{
    public interface IServices
    {
        List<SurveyDTO> GetAllSurveys();
        SurveyDTO GetSurveyById(int id);
        List<QuestionDTO> GetQuestionDTOBySurveyId(int id);
        List<VariantsOfAnswersDTO> GetVariantsOfAnswersDTOByQuestionId(int id);
        List<UsersAnswersDTO> GetUsersAnswersDTO();
        List<AnswerTypeDTO> GetAllAnswerType();
        List<PercentageAnswers> GetPercentages();
        List<SurveyTypeDTO> GetSurveyTypes();
        void MakeUsersAnswers(List<UsersAnswersDTO> usersAnswersDTO);
        void Dispose();
    }
}
