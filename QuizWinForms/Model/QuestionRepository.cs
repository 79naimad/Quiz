using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizBSWinForms.Model
{
    public class QuestionRepository: IQuestionRepository
    {
        #region Fields
        private IEnumerable<QuestionModel> quesitions;

        #endregion

        #region Constructors
        public QuestionRepository()
        {
            quesitions = new List<QuestionModel>()
            {
                new QuestionModel()
                {
                    Question = "Pytanie1",
                    AnswerA = "AnswA1",
                    AnswerB = "AnswB1",
                    AnswerC = "AnswC1",
                    AnswerD = "AnswD1",
                    BoolAnswerA = false,
                    BoolAnswerB = false,
                    BoolAnswerC = false,
                    BoolAnswerD = false,
                    CorrectAnswer = 1
                },
                new QuestionModel()
                {
                    Question = "Pytanie2",
                    AnswerA = "AnswA2",
                    AnswerB = "AnswB2",
                    AnswerC = "AnswC2",
                    AnswerD = "AnswD2",
                    BoolAnswerA = false,
                    BoolAnswerB = false,
                    BoolAnswerC = false,
                    BoolAnswerD = false,
                    CorrectAnswer = 2
                },
                new QuestionModel()
                {
                    Question = "Pytanie3",
                    AnswerA = "AnswA3",
                    AnswerB = "AnswB3",
                    AnswerC = "AnswC3",
                    AnswerD = "AnswD3",
                    BoolAnswerA = false,
                    BoolAnswerB = false,
                    BoolAnswerC = false,
                    BoolAnswerD = false,
                    CorrectAnswer = 3
                }
            };
        }

        public IEnumerable<QuestionModel> GetQuestions()
        {
            return quesitions;
        }
        #endregion
    }
}
