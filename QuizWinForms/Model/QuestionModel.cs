using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizBSWinForms.Model
{
    public class QuestionModel
    {

        #region Fields
        private static int id = 1;
        private int currentId;
        #endregion

        #region Constructors
        public QuestionModel()
        {
            currentId = id;
            id++;
        }
        #endregion

        #region Properties
        public string Question { get; set; }
        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AnswerC { get; set; }
        public string AnswerD { get; set; }
        public bool BoolAnswerA { get; set; }
        public bool BoolAnswerB { get; set; }
        public bool BoolAnswerC { get; set; }
        public bool BoolAnswerD { get; set; }
        public int CorrectAnswer { get; set; }
        public int Id { get => currentId; }
        #endregion

    }
}
