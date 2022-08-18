using QuizBSWinForms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizBSWinForms.BusinessLogic
{
    public class AnswersHandler
    {
        #region Constructors

        public AnswersHandler()
        {
            resultOfTest = 0;
        }

        #endregion

        #region Fields

        private int resultOfTest;

        #endregion

        #region Properties
        public int ResultOfTest
        {
            get => resultOfTest;
        }
        #endregion

        #region Methods
        public void CheckAnswers(IQuestionRepository repository)
        {
            int result = 0;
            var questions  = repository.GetQuestions();

            foreach(var question in questions)
            {
                if(CheckAnswer(question))
                {
                    result++;
                }
            }
            resultOfTest = result;
        }
        
        private bool CheckAnswer(QuestionModel question)
        {
            switch (question.CorrectAnswer)
            {
                case 1:
                    return question.BoolAnswerA;
                case 2:
                    return question.BoolAnswerB;
                case 3:
                    return question.BoolAnswerC;
                case 4:
                    return question.BoolAnswerD;
                default:
                    return false;
            }
        }
        #endregion
    }
}
