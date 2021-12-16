using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObject
{
    public class Question : Entity
    {
        [ForeignKey("Quiz")]
        public int QuizId { get; set; }
        public String Content { get; set; }
        [ForeignKey("Answer")]
        public String RightAnswerId { get; set; }
        [ForeignKey("QuizId")]
        public virtual Quiz Quiz { get; set; }
        [ForeignKey("RightAnswerId")]
        public virtual Answer RightAnswer { get; set; }

        public Question()
        {

        }

        public Question(String id, int quizId, String content, String rightAnswer) : base(id)
        {
            QuizId = quizId;
            Content = content;
            RightAnswerId = rightAnswer;
        }
    }
}
