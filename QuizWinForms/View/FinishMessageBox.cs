namespace QuizBSWinForms.View
{
    internal class FinishMessageBox
    {
        public FinishMessageBox(string msg, MessageBoxButtons btn)
        {
            message = msg;
            button = btn;
        }

        #region Fields

        private readonly string message;
        private MessageBoxButtons button;

        #endregion

        #region Methods

        private DialogResult showDialogWindow(int result)
        {
            string finallyMessage = this.message + result.ToString();
            return MessageBox.Show(finallyMessage, "", button);
        }


        public bool CheckingIfRepeatTest(int result)
        {
            DialogResult windowResult = showDialogWindow(result);

            if (windowResult == DialogResult.Retry)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
       
}
}
