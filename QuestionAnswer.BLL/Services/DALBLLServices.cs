using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestionAnswer.DAL.Interfaces;
using QuestionAnswer.DAL.Entities;
using QuestionAnswer.BLL.DTO;
using QuestionAnswer.BLL.Interfaces;
using AutoMapper;
using QuestionAnswer.BLL.AutoMapper;
using QuestionAnswer.BLL.BusinessModels;

namespace QuestionAnswer.BLL.Services
{
    public class DALBLLServices : IServices
    {
        IUnitOfWork Database { get; set; }

        public DALBLLServices(IUnitOfWork uow)
        {
            Database = uow;
        }



        private PercentagesOfAnswers percentages;

        public List<PercentageAnswers> GetPercentages()
        {
            if (percentages == null)
                percentages = new PercentagesOfAnswers();
            var percent = percentages.Calculation(Database);
            return percent;
        }


        public List<SurveyTypeDTO> GetSurveyTypes()
        {
            return Mapper.Map<List<SurveyType>, List<SurveyTypeDTO>>(Database.GetSurveyType.GetSurveyType());
        }

        public List<AnswerTypeDTO> GetAllAnswerType()
        {
            return Mapper.Map<List<AnswerType>, List<AnswerTypeDTO>>(Database.GetAnswerTypes.GetAllAnswerType());
        }
        public List<SurveyDTO> GetAllSurveys()
        {
            List<SurveyDTO> surveyDTOs = new List<SurveyDTO>();
            
            surveyDTOs = Mapper.Map<List<Survey>, List<SurveyDTO>>(Database.GetSurveys.GetAll());
            return surveyDTOs;
        }

        public SurveyDTO GetSurveyById(int id)
        {
            SurveyDTO surveyDTOs = new SurveyDTO();

            surveyDTOs = Mapper.Map<Survey, SurveyDTO>(Database.GetSurveys.GetById(id));
            return surveyDTOs;
        }

        public List<QuestionDTO> GetQuestionDTOBySurveyId(int id)
        {
            List<QuestionDTO> questionDTO = new List<QuestionDTO>();

            questionDTO = Mapper.Map<List<Question>, List<QuestionDTO>>(Database.GetQuestions.GetQuestionBySurveyId(id));
            return questionDTO;
        }


        public List<VariantsOfAnswersDTO> GetVariantsOfAnswersDTOByQuestionId(int id)
        {
            List<VariantsOfAnswersDTO> variantsOfAnswersDTO = new List<VariantsOfAnswersDTO>();

            variantsOfAnswersDTO = Mapper.Map<List<VariantsOfAnswers>, List<VariantsOfAnswersDTO>>(Database.GetVariantsOfAnswers.GetVariantsOfAnswersByQuestionId(id));
            return variantsOfAnswersDTO;
        }

       

        public List<UsersAnswersDTO> GetUsersAnswersDTO()
        {
            List<UsersAnswersDTO> usersAnswersDTO = new List<UsersAnswersDTO>();

            usersAnswersDTO = Mapper.Map<List<UsersAnswers>, List<UsersAnswersDTO>>(Database.GetUserAnswers.GetAll());
            return usersAnswersDTO;
        }
        public void Dispose()
        {
            Database.Dispose();
        }

        public void MakeUsersAnswers(List<UsersAnswersDTO> usersAnswersDTO)
        {
            List<UsersAnswers> answers = new List<UsersAnswers>();

            answers = Mapper.Map<List<UsersAnswersDTO>, List<UsersAnswers>>(usersAnswersDTO);

            Database.GetUserAnswers.Create(answers);
            Database.Save();
        }

       


    }
}
