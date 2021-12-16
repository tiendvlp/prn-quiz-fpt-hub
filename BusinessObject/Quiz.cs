using System;
namespace BusinessObject
{
    public class Quiz : Entity
    {
        public String Title { get; set; }
        public object MyProperty { get; set; }

        public Quiz()
        {
        }

        public Quiz(string id, string title) : base(id)
        {
            Title = title;
        }
    }
}
