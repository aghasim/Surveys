using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using QuestionAnswer.DAL.Entities;

namespace QuestionAnswer.DAL.EF
{
    public class QuestionAnswerContext : DbContext
    {
        public DbSet<SurveyType> SurveyTypes { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<AnswerType> AnswerTypes { get; set; }
        //public DbSet<AnswerOnlyChoise> AnswerOnlyChoises { get; set; }
        //public DbSet<AnswerMultipleChoise> AnswerMultipleChoises { get; set; }
        //public DbSet<AnswerFreeText> AnswerFreeTexts { get; set; }
        public DbSet<VariantsOfAnswers> VariantsOfAnswers { get; set; }
        public DbSet<UsersAnswers> UsersAnswers { get; set; }

        static QuestionAnswerContext()
        {
            Database.SetInitializer<QuestionAnswerContext>(new StoreDbInitializer());
        }

        public QuestionAnswerContext(string connectionStrind) : base(connectionStrind)
        {

        }
    }

    public class StoreDbInitializer : DropCreateDatabaseIfModelChanges<QuestionAnswerContext>
    {
        protected override void Seed(QuestionAnswerContext db)
        {
            db.SurveyTypes.Add(new SurveyType { TypeName = "Cinema" });
            db.SurveyTypes.Add(new SurveyType { TypeName = "Internet" });

            db.AnswerTypes.Add(new AnswerType { Type = "Multiple Choise" });
            db.AnswerTypes.Add(new AnswerType { Type = "Only Choise" });
            db.AnswerTypes.Add(new AnswerType { Type = "Free Text" });
            db.SaveChanges();

            db.Surveys.Add(new Survey { Title = "How many times a week you watch a movie", TypeSurveyId = 1 });
            db.Surveys.Add(new Survey { Title = "How much time per day do you use the Internet", TypeSurveyId = 2 });
            db.SaveChanges();

            db.Questions.Add(new Question { QuestionText = "How often do you watch a film ?", SurveyId = 1, AnswerTypeId=2 });
            db.Questions.Add(new Question { QuestionText = "What kind of film do you like ?", SurveyId = 1, AnswerTypeId=1 });
            db.Questions.Add(new Question { QuestionText = "Choose the best movie you think", SurveyId = 1, AnswerTypeId=1 });
            db.Questions.Add(new Question { QuestionText = "Your opinion about modern films?", SurveyId = 1, AnswerTypeId=3 });
            db.SaveChanges();

            db.VariantsOfAnswers.Add(new VariantsOfAnswers
            {
                 QuestionId=1,
                 AnswerText= "Everyday"
            });

            db.VariantsOfAnswers.Add(new VariantsOfAnswers
            {
                QuestionId = 1,
                AnswerText = "Every week"
            });

            db.VariantsOfAnswers.Add(new VariantsOfAnswers
            {
                QuestionId = 1,
                AnswerText = "Sometimes"
            });
            db.VariantsOfAnswers.Add(new VariantsOfAnswers
            {
                QuestionId = 1,
                AnswerText = "Never"
            });

            db.VariantsOfAnswers.Add(new VariantsOfAnswers
            {
                QuestionId = 2,
                AnswerText = "Adventure"
            });
            db.VariantsOfAnswers.Add(new VariantsOfAnswers
            {
                QuestionId = 2,
                AnswerText = "Drama"
            });

            db.VariantsOfAnswers.Add(new VariantsOfAnswers
            {
                QuestionId = 2,
                AnswerText = "Fantasy"
            });
            db.VariantsOfAnswers.Add(new VariantsOfAnswers
            {
                QuestionId = 2,
                AnswerText = "Horrors"
            });

            db.VariantsOfAnswers.Add(new VariantsOfAnswers
            {
                QuestionId = 3,
                AnswerText = "Harry Potter"
            });

            db.VariantsOfAnswers.Add(new VariantsOfAnswers
            {
                QuestionId = 3,
                AnswerText = "Predator"
            });

            db.VariantsOfAnswers.Add(new VariantsOfAnswers
            {
                QuestionId = 3,
                AnswerText = "The Maze Runner"
            });

            db.VariantsOfAnswers.Add(new VariantsOfAnswers
            {
                QuestionId = 3,
                AnswerText = "The Woman in Black"
            });

            //db.AnswerFreeTexts.Add(new AnswerFreeText
            //{
            //    QuestionId = 4,
            //    AnswerTypeId = 3,
            //});
            //db.SaveChanges();
            //db.AnswerMultipleChoises.Add(new AnswerMultipleChoise
            //{
            //    QuestionId = 2,
            //    AnswerTypeId = 1,
            //    AnswerText1 = "Adventure",
            //    AnswerText2 = "Drama",
            //    AnswerText3 = "Fantasy",
            //    AnswerText4 = "Horrors",
            //});

            //db.AnswerMultipleChoises.Add(new AnswerMultipleChoise
            //{
            //    QuestionId = 3,
            //    AnswerTypeId = 1,
            //    AnswerText1 = "Harry Potter",
            //    AnswerText2 = "Predator",
            //    AnswerText3 = "The Maze Runner",
            //    AnswerText4 = "The Woman in Black",
            //});

            //db.AnswerOnlyChoises.Add(new AnswerOnlyChoise
            //{
            //    QuestionId = 1,
            //    AnswerTypeId = 2,
            //    AnswerText1 = "Everyday",
            //    AnswerText2 = "Every week",
            //    AnswerText3 = "Sometimes",
            //    Answertext4 = "Never",
            //});

            db.SaveChanges();
        }
    }
}
