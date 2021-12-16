using System;
namespace BusinessObject
{
    public class Question : Entity
    {
        public int QuizId { get; set; }
        public String Content { get; set; }
        public int RightAnswer { get; set; }

        public Question()
        {

        }

        public Question(String id, int quizId, String content, int rightAnswer) : base(id)
        {
            QuizId = quizId;
            Content = content;
            RightAnswer = rightAnswer;
        }
    }
}
