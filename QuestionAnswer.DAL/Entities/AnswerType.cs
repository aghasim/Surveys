using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Text;

namespace QuestionAnswer.DAL.Entities
{
    public class AnswerType
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
    }
}
