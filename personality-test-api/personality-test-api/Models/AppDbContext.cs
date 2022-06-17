using Microsoft.EntityFrameworkCore;

namespace personality_test_api.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>().Navigation(q => q.Answers).AutoInclude();

            modelBuilder.Entity<Question>().HasData(
                new Question
                {
                    Id = 1,
                    Content = "You’re really busy at work and a colleague is telling you their life story and personal woes. You:"
                },
                new Question
                {
                    Id = 2,
                    Content = "You’ve been sitting in the doctor’s waiting room for more than 25 minutes. You:"
                },
                new Question
                {
                    Id = 3,
                    Content = "You’re having an animated discussion with a colleague regarding a project that you’re in charge of. You:"
                },
                new Question
                {
                    Id = 4,
                    Content = "You are taking part in a guided tour of a museum. You:"
                },
                new Question
                {
                    Id = 5,
                    Content = "During dinner parties at your home, you have a hard time with people who:"
                }
            );


            modelBuilder.Entity<Answer>().HasData(
                new Answer
                {
                    Id = 1,
                    Content = "Don’t dare to interrupt them",
                    QuestionId = 1,
                    Rate = 10
                },
                new Answer
                {
                    Id = 2,
                    Content = "Think it’s more important to give them some of your time; work can wait",
                    QuestionId = 1,
                    Rate = 7
                },
                new Answer
                {
                    Id = 3,
                    Content = "Listen, but with only with half an ear",
                    QuestionId = 1,
                    Rate = 4
                },
                new Answer
                {
                    Id = 4,
                    Content = "Interrupt and explain that you are really busy at the moment",
                    QuestionId = 1,
                    Rate = 0
                },

                new Answer
                {
                    Id = 5,
                    Content = "Look at your watch every two minutes",
                    QuestionId = 2,
                    Rate = 5
                },
                new Answer
                {
                    Id = 6,
                    Content = "Bubble with inner anger, but keep quiet",
                    QuestionId = 2,
                    Rate = 7
                },
                new Answer
                {
                    Id = 7,
                    Content = "Explain to other equally impatient people in the room that the doctor is always running late",
                    QuestionId = 2,
                    Rate = 4
                },
                new Answer
                {
                    Id = 8,
                    Content = "Complain in a loud voice, while tapping your foot impatiently",
                    QuestionId = 2,
                    Rate = 10
                },

                new Answer
                {
                    Id = 9,
                    Content = "Don’t dare contradict them",
                    QuestionId = 3,
                    Rate = 1
                },
                new Answer
                {
                    Id = 10,
                    Content = "Think that they are obviously right",
                    QuestionId = 3,
                    Rate = 3
                },
                new Answer
                {
                    Id = 11,
                    Content = "Defend your own point of view, tooth and nail",
                    QuestionId = 3,
                    Rate = 10
                },
                new Answer
                {
                    Id = 12,
                    Content = "Continuously interrupt your colleague",
                    QuestionId = 3,
                    Rate = 7
                },
                
                new Answer
                {
                    Id = 13,
                    Content = "Are a bit too far towards the back so don’t really hear what the guide is saying",
                    QuestionId = 4,
                    Rate = 1
                },
                new Answer
                {
                    Id = 14,
                    Content = "Follow the group without question",
                    QuestionId = 4,
                    Rate = 3
                },
                new Answer
                {
                    Id = 15,
                    Content = "Make sure that everyone is able to hear properly",
                    QuestionId = 4,
                    Rate = 7
                },
                new Answer
                {
                    Id = 16,
                    Content = "Are right up the front, adding your own comments in a loud voice",
                    QuestionId = 4,
                    Rate = 10
                },
                
                new Answer
                {
                    Id = 17,
                    Content = "Ask you to tell a story in front of everyone else",
                    QuestionId = 5,
                    Rate = 1
                },
                new Answer
                {
                    Id = 18,
                    Content = "Talk privately between themselves",
                    QuestionId = 5,
                    Rate = 3
                },
                new Answer
                {
                    Id = 19,
                    Content = "Hang around you all evening",
                    QuestionId = 5,
                    Rate = 7
                },
                new Answer
                {
                    Id = 20,
                    Content = "Always drag the conversation back to themselves",
                    QuestionId = 5,
                    Rate = 10
                }
            );
        }
    }
}
