using QuizBSWinForms.BusinessLogic;
using QuizBSWinForms.Model;
using QuizBSWinForms.Presenter;
using QuizBSWinForms.View;

namespace QuizBSWinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var mainForm = new MainForm();
            var questionRepository = new QuestionRepository();
            var answerHandler = new AnswersHandler();
            var presenter = new MainFormPresenter(mainForm, questionRepository, answerHandler);
            Application.Run(mainForm);
        }
    }
}