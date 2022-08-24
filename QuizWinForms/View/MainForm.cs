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
    public partial class MainForm : Form, IMainForm
    {
        #region Fields
        private readonly ControlViewModel controlViewModel;
        private readonly QuestionViewModel questionViewModel;
        private readonly AnswerViewModel answerViewModel;
        #endregion

        public MainForm()
        {
            InitializeComponent();
            controlViewModel = new ControlViewModel() { Dock = DockStyle.Top};
            answerViewModel = new AnswerViewModel() { Dock = DockStyle.Bottom };
            questionViewModel = new QuestionViewModel() { Dock = DockStyle.Fill};

            ShowAnswerViewModel();
            ShowControlViewModel();
            ShowQuestionViewModel();
        }

        #region Properties
        public IControlViewModel ControlViewModel
        {
            get => controlViewModel;
        }

        public IQuestionViewModel QuestionViewModel
        {
            get => questionViewModel;
        }

        public IAnswerViewModel AnswerViewModel
        {
            get => answerViewModel;
        }

        #endregion

        #region Methods
        public void ShowAnswerViewModel()
        {
            pnlBot.Controls.Clear();
            pnlBot.Controls.Add(answerViewModel);
        }

        public void ShowControlViewModel()
        {
            pnlTop.Controls.Clear();
            pnlTop.Controls.Add(controlViewModel);
        }

        public void ShowQuestionViewModel()
        {
            pnlMid.Controls.Clear();
            pnlMid.Controls.Add(questionViewModel);
        }

        #endregion

    }

    public interface IMainForm
    {
        IControlViewModel ControlViewModel { get; }
        IQuestionViewModel QuestionViewModel { get; }
        IAnswerViewModel AnswerViewModel { get; }

        public void ShowControlViewModel();
        public void ShowQuestionViewModel();
        public void ShowAnswerViewModel();
    }
}
