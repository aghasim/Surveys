using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuestionAnswer.DAL.Entities
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public int AnswerTypeId { get; set; }
        [ForeignKey(nameof(AnswerTypeId))]
        public virtual AnswerType AnswerType { get; set; }
        public int SurveyId { get; set; }
        [ForeignKey(nameof(SurveyId))]
        public virtual Survey Survey { get; set; }
        public virtual List<VariantsOfAnswers> VariantsOfAnswers { get; set; }
    }
}
