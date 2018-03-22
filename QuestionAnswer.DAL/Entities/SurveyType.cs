using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuestionAnswer.DAL.Entities
{
    public class SurveyType
    {
        [Key]
        public int Id { get; set; }
        public string TypeName { get; set; }
        //public Questionnarie Questionnaries { get; set; }

        //public QuestionnaireType()
        //{
        //    Questionnaries = new List<Questionnarie>();
        //}
    }
}
