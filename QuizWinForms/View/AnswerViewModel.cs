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
    public partial class AnswerViewModel : UserControl, IAnswerViewModel
    {
        #region Constructors
        public AnswerViewModel()
        {
            InitializeComponent();
        }
        #endregion

        #region Properties
        public string AnswerA 
        { 
            get => cBoxA.Text;
            set { cBoxA.Text = value; } 
        }
        public string AnswerB 
        {
            get => cBoxB.Text;
            set { cBoxB.Text = value; }
        }
        public string AnswerC 
        {
            get => cBoxC.Text;
            set { cBoxC.Text = value; }
        }
        public string AnswerD 
        {
            get => cBoxD.Text;
            set { cBoxD.Text = value; }
        }

        public bool BoolAnswerA { 
            get => cBoxA.Checked; 
            set { cBoxA.Checked = value; } 
        }
        public bool BoolAnswerB 
        { 
            get => cBoxB.Checked;
            set { cBoxB.Checked = value; } 
        }
        public bool BoolAnswerC 
        {
            get => cBoxC.Checked;
            set { cBoxC.Checked = value; } 
        }
        public bool BoolAnswerD 
        {
            get => cBoxD.Checked;
            set { cBoxD.Checked = value; } 
        }

        public EventHandler ReloadAnswers
        {
            set
            {
                cBoxA.Click += value;
                cBoxB.Click += value;
                cBoxC.Click += value;
                cBoxD.Click += value;

            }
        }
        #endregion

    }
    public interface IAnswerViewModel
    {
        string AnswerA { get; set; }
        string AnswerB { get; set; }
        string AnswerC { get; set; }
        string AnswerD { get; set; }

        bool BoolAnswerA { get; set; }
        bool BoolAnswerB { get; set; }
        bool BoolAnswerC { get; set; }
        bool BoolAnswerD { get; set; }
        EventHandler ReloadAnswers { set; }

    }
}
