using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QuestionAnswer.Models;

namespace QuestionAnswer.AuxiliariesMethods
{
    public class CreateUsersAnswersFromString
    {
        public static List<UsersAnswersViewModel> StringToUsersAnswers(List<string> multiple)
        {
            if (multiple != null)
            {

            }
            List<UsersAnswersViewModel> answersViewModel = new List<UsersAnswersViewModel>();
            foreach (var item in multiple)
            {
                UsersAnswersViewModel model = new UsersAnswersViewModel();
                string[] st = item.Split(',');
                model.SurveyTypeId = Convert.ToInt32(st[0]);
                model.SurveyId = Convert.ToInt32(st[1]);
                model.QuestionId = Convert.ToInt32(st[2]);
                model.AnswerTypeId = Convert.ToInt32(st[3]);
                model.VariantsOfAnswerId = Convert.ToInt32(st[4]);
                model.Answer = st[5];
                answersViewModel.Add(model);
            }
            return answersViewModel;
        }

        public static UsersAnswersViewModel StringToUsersAnswers(string only)
        {
            UsersAnswersViewModel model = new UsersAnswersViewModel();
            string[] st = only.Split(',');
            model.SurveyTypeId = Convert.ToInt32(st[0]);
            model.SurveyId = Convert.ToInt32(st[1]);
            model.QuestionId = Convert.ToInt32(st[2]);
            model.AnswerTypeId = Convert.ToInt32(st[3]);
            model.VariantsOfAnswerId = Convert.ToInt32(st[4]);
            model.Answer = st[5];

            return model;
        }
    }
}