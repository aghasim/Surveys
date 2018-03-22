using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuestionAnswer.Models;
using QuestionAnswer.BLL.Interfaces;
using QuestionAnswer.BLL.DTO;
using AutoMapper;
using System.Web.Helpers;
using System.Collections;
using System.IO;

namespace QuestionAnswer.Controllers
{
    public class PercentageController : Controller
    {
        IServices service;
        public PercentageController(IServices serv)
        {
            service = serv;
        }
        // GET: Percentage
        public ActionResult Percentage()
        {

            var surveyTypeDTO = service.GetSurveyTypes();
            var surveyType = Mapper.Map<List<SurveyTypeDTO>, List<SurveyTypeViewModel>>(surveyTypeDTO);

            var percentage = service.GetPercentages();
            var percentageAnswers = Mapper.Map<List<PercentageAnswers>, List<PercentageAnswersViewModel>>(percentage);

            string fileName = string.Empty;
            string path = Server.MapPath("~/Images/");
            string format = ".png";
            foreach (var item in surveyType)
            {
                var tmpPercentage = percentageAnswers.Where(x => x.SurveyTypeId == item.Id).ToList();
                fileName = item.TypeName;
                var chart = new Chart(width: 500, height: 300, theme: ChartTheme.Green)
                    .AddTitle(item.TypeName)
                    .AddSeries("Default", chartType: "Column",
                    xValue: tmpPercentage, xField: "AnswerTypetext",
                    yValues: tmpPercentage, yFields: "Percentage");
                //if(System.IO.File.Exists((path+fileName)))
                chart.Save(path + fileName+format, "image/png");
            }
            return View(surveyType);
        }

        //public ActionResult Chart()
        //{
        //    var surveyType = service.GetSurveyTypes();

        //    var percentage = service.GetPercentages();
        //    var percentageAnswers = Mapper.Map<List<PercentageAnswers>, List<PercentageAnswersViewModel>>(percentage);

        //    string fileName = string.Empty;
        //    string path = Server.MapPath("~/Images/");
        //    foreach (var item in surveyType)
        //    {
        //        var tmpPercentage = percentageAnswers.Where(x => x.SurveyTypeId == item.Id).ToList();
        //        fileName = item.TypeName;
        //        var chart = new Chart(width: 500, height: 300, theme: ChartTheme.Green)
        //            .AddTitle(item.TypeName)
        //            .AddSeries("Default", chartType: "Column",
        //            xValue: tmpPercentage, xField: "AnswerTypetext",
        //            yValues: tmpPercentage, yFields: "Percentage");
        //        if (!Directory.Exists(path))
        //        {

        //        }
        //        chart.Save(path + fileName, "image/png");
        //    }



        //    return null;
        //}
    }
}