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
    public partial class ControlViewModel : UserControl, IControlViewModel
    {

        #region Constructors

        public ControlViewModel()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods

        //Sets buttons text
        public void SetButtonFinishText(string btnText)
        {
            btnFinishTest.Text = btnText;
        }

        public void SetButtonNextText(string btnText)
        {
            btnNextQuestion.Text = btnText;
        }

        public void SetButtonPrievText(string btnText)
        {
            btnPrievQuestion.Text = btnText;
        }

        //Sets buttons enabling
        public void SetButtonFinishEnable(bool isEnable)
        {
            btnFinishTest.Enabled = isEnable;
        }

        public void SetButtonNextEnable(bool isEnable)
        {
            btnNextQuestion.Enabled = isEnable;
        }

        public void SetButtonPrievEnable(bool isEnable)
        {
            btnPrievQuestion.Enabled = isEnable;
        }
        #endregion

        #region Event Handlers

        public EventHandler NextQuestion
        {
            set
            {
                btnNextQuestion.Click += value;
            }
        }

        public EventHandler PrievQuestion
        {
            set
            {
                btnPrievQuestion.Click += value;
            }
        }

        public EventHandler FinishTest 
        { 
            set
            {
                btnFinishTest.Click += value;
            }
        }



        #endregion
    }
    public interface IControlViewModel
    {
        void SetButtonFinishText(string btnText);
        void SetButtonNextText(string btnText);
        void SetButtonPrievText(string btnText);
        void SetButtonFinishEnable(bool isEnable);
        void SetButtonNextEnable(bool isEnable);
        void SetButtonPrievEnable(bool isEnable);
        EventHandler NextQuestion { set; }
        EventHandler PrievQuestion { set; }
        EventHandler FinishTest { set; }
    }
}
