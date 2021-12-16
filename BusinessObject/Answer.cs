using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObject
{
    public class Answer : Entity
    {
        [ForeignKey("Question")]
        public int QuestionId { get; set; }
        [ForeignKey("QuestionId")]
        public virtual Question Question { get; set; }
        public String Content { get; set; }

        public Answer()
        {
        }

        public Answer(String id, int questionId, string content): base (id)
        {
            QuestionId = questionId;
            Content = content;
        }
    }
}
