using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuestionAnswer.Models;
using QuestionAnswer.BLL.DTO;
using QuestionAnswer.BLL.Interfaces;
using AutoMapper;
using QuestionAnswer.AuxiliariesMethods;

namespace QuestionAnswer.Controllers
{
    public class QuestionController : Controller
    {
        IServices service;
        public QuestionController(IServices serv)
        {
            service = serv;
        }
        
       
        public ActionResult Question(int Id)
        {
            var surveyDTO = service.GetSurveyById(Id);
            var surveyViewModel = Mapper.Map<SurveyDTO, SurveyViewModel>(surveyDTO);
            ViewBag.Survey = surveyViewModel;


            var questionDTO = service.GetQuestionDTOBySurveyId(Id);
            var question = Mapper.Map<List<QuestionDTO>, List<QuestionViewModel>>(questionDTO);
            return View(question);
        }

        [HttpPost]
        public ActionResult Question(List<string> multiple, string only, string free, string freeIds)
        {
            var freeAnswer = freeIds + " " + free;
            var usersAnswers = CreateUsersAnswersFromString.StringToUsersAnswers(multiple);
            usersAnswers.Add(CreateUsersAnswersFromString.StringToUsersAnswers(freeAnswer));
            usersAnswers.Add(CreateUsersAnswersFromString.StringToUsersAnswers(only));

            var answerDTO = Mapper.Map<List<UsersAnswersViewModel>, List<UsersAnswersDTO>>(usersAnswers);
            service.MakeUsersAnswers(answerDTO);

            

            return RedirectToAction("Percentage", "Percentage");
        }
    }
}