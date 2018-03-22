using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuestionAnswer.DAL.Entities
{
    public class VariantsOfAnswers
    {
        [Key]
        public int Id { get; set; }
        public int QuestionId { get; set; }
        [ForeignKey(nameof(QuestionId))]
        public virtual Question Question { get; set; }
        public string AnswerText { get; set; }
    }
}
