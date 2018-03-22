using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuestionAnswer.DAL.Entities
{
    public class Survey
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public int TypeSurveyId { get; set; }
        [ForeignKey(nameof(TypeSurveyId))]
        public virtual SurveyType SurveyType { get; set; }

        //public Questionnarie()
        //{
        //    Questions = new List<Question>();
        //}
    }
}
