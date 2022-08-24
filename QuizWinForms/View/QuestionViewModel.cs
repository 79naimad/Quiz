using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizBSWinForms.View
{
    public partial class QuestionViewModel : UserControl, IQuestionViewModel
    {

        #region Constructors
        public QuestionViewModel()
        {
            InitializeComponent();

        }

        #endregion

        #region Properties
        public string Questtion 
        { 
            get => lblQuestion.Text;
            set { lblQuestion.Text = value; } 
        }
        public int QuestationId 
        { 
            get => Convert.ToInt32(lblQuestionId.Text); 
            set { lblQuestionId.Text = value.ToString(); } 
        }
        #endregion
    }

    public interface IQuestionViewModel
    {
        string Questtion { get; set; }
        int QuestationId { get; set; }
    }
}
