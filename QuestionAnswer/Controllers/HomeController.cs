using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuestionAnswer.BLL.DTO;
using QuestionAnswer.BLL.Interfaces;
using QuestionAnswer.BLL.Services;
using AutoMapper;
using QuestionAnswer.Models;


namespace QuestionAnswer.Controllers
{
    public class HomeController : Controller
    {
        IServices service;
        public HomeController(IServices serv)
        {
            service = serv;
        }
        public ActionResult Index()
        {
            var surveyDTO = service.GetAllSurveys();
            var survey = Mapper.Map<List<SurveyDTO>, List<SurveyViewModel>>(surveyDTO);
            return View(survey);
        }



        [HttpPost]
        public ActionResult Index(int surveyId)
        {
            //var surveyDTO = service.GetSurveyById(surveyId);
            //var surveyViewModel = Mapper.Map<SurveyDTO, SurveyViewModel>(surveyDTO);
            //ViewBag.Survey = surveyViewModel;


            //var questionDTO = service.GetQuestionDTOBySurveyId(surveyId);
            //var question = Mapper.Map<List<QuestionDTO>, List<QuestionViewModel>>(questionDTO);
            //return View("~/Views/Question/Question.cshtml", question);

            return RedirectToAction("Question", "Question", new { Id = surveyId });
        }
    }
}