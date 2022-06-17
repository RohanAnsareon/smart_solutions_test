namespace personality_test_api.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public ICollection<Answer> Answers { get; set; }
    }
}
