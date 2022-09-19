namespace QuizBSWinForms.View
{
    public class FinishMessageBox
    {

        #region Constructors
        public FinishMessageBox(string ttl, string msg, MessageBoxButtons btn)
        {
            message = msg;
            button = btn;
            title = ttl;
        }

        #endregion

        #region Fields

        private readonly string message;
        private readonly MessageBoxButtons button;
        private readonly string title;

        #endregion

        #region Methods

        private DialogResult showDialogWindow(int result)
        {
            string finallyMessage = this.message + result.ToString();
            return MessageBox.Show(finallyMessage, this.title, button);
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
