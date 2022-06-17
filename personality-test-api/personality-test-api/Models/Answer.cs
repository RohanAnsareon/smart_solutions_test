namespace personality_test_api.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string Content { get; set; }
        public float Rate { get; set; }
    }
}
