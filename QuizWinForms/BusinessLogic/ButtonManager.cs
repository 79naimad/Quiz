using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizBSWinForms.BusinessLogic
{
    public static class ButtonManager
    {
        #region Fields
        public enum ButtonType
        {
            singlePossibilites,
            multiplePossibilites
        }

        #endregion

        #region Logic

        public static bool CheckPossiblitiesToClickTheButton(int currentQuestion, int borderForTheButton, ButtonType btnType)
        {
            switch (btnType)
            {
                case ButtonType.singlePossibilites:
                    {
                        return borderForTheButton == currentQuestion;
                    }

                case ButtonType.multiplePossibilites:
                    {
                        return currentQuestion != borderForTheButton;
                    }
                default:
                    {
                        return false;
                    }
            }

            #endregion

        }
    }
}
