using QuizBSWinForms.BusinessLogic;
using QuizBSWinForms.Model;
using QuizBSWinForms.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizBSWinForms.Presenter
{
    public class MainFormPresenter
    {
        #region Fields
        private readonly IQuestionRepository questionsRepository;
        private readonly IMainForm mainForm;
        private readonly IControlViewModel controlViewModel;
        private readonly IQuestionViewModel questionViewModel;
        private readonly IAnswerViewModel answerViewModel;
        private readonly AnswersHandler answerHandler;
        private int currentQuestionNumber;


        #region Constants

        private readonly int startIndexOfList;
        private readonly int endIndexOfList;
        private readonly string finalMessage = "Your result: ";
        private readonly string dialogFinishWndTitle = "Result";

        #endregion

        #endregion

        #region Constructors

        public MainFormPresenter(IMainForm mainForm, 
            IQuestionRepository questionsRepository,
            AnswersHandler answerHandler)      
        {
            currentQuestionNumber = 0;
            this.questionsRepository = questionsRepository;
            this.mainForm = mainForm;
            this.answerHandler = answerHandler;
            startIndexOfList = 0;
            endIndexOfList = this.questionsRepository.GetQuestions().Count() - 1;

            controlViewModel = mainForm.ControlViewModel;
            questionViewModel = mainForm.QuestionViewModel;
            answerViewModel = mainForm.AnswerViewModel;

            controlViewModel.SetButtonFinishText("Finish");
            controlViewModel.SetButtonNextText(">>");
            controlViewModel.SetButtonPrievText("<<");
            checkPossibilitiesToClickForAllButtons(currentQuestionNumber);

            controlViewModel.NextQuestion = delegate { nextQuestion(); };
            controlViewModel.PrievQuestion = delegate { prievQuestion(); };
            controlViewModel.FinishTest = delegate { finishTest(questionsRepository); };


            loadQuestion(currentQuestionNumber);
        }

        #endregion

        #region Methods

        private void checkPossibilitiesToClickForAllButtons(int currentQuestionNumber)
        {
            controlViewModel.SetButtonFinishEnable(ButtonManager.CheckPossiblitiesToClickTheButton(currentQuestionNumber, 
                                                                                                endIndexOfList, 
                                                                                                ButtonManager.ButtonType.singlePossibilites));

            controlViewModel.SetButtonNextEnable(ButtonManager.CheckPossiblitiesToClickTheButton(currentQuestionNumber, 
                                                                                                endIndexOfList, 
                                                                                                ButtonManager.ButtonType.multiplePossibilites));

            controlViewModel.SetButtonPrievEnable(ButtonManager.CheckPossiblitiesToClickTheButton(currentQuestionNumber, 
                                                                                                0, 
                                                                                                ButtonManager.ButtonType.multiplePossibilites));
        }

        private void saveQuestions(int i)
        {
            List<QuestionModel> questionModel = (List<QuestionModel>)questionsRepository.GetQuestions();
            questionModel[i].BoolAnswerA = answerViewModel.BoolAnswerA;
            questionModel[i].BoolAnswerB = answerViewModel.BoolAnswerB;
            questionModel[i].BoolAnswerC = answerViewModel.BoolAnswerC;
            questionModel[i].BoolAnswerD = answerViewModel.BoolAnswerD;
        }

        private void nextQuestion()
        {
            if (endIndexOfList > currentQuestionNumber)
            {
                saveQuestions(currentQuestionNumber);
                loadQuestion(++currentQuestionNumber);
                checkPossibilitiesToClickForAllButtons(currentQuestionNumber);
            }

        }

        private void prievQuestion()
        {
            if (startIndexOfList < currentQuestionNumber)
            {
                saveQuestions(currentQuestionNumber);
                loadQuestion(--currentQuestionNumber);
                checkPossibilitiesToClickForAllButtons(currentQuestionNumber);
            }
        }

        private void loadQuestion(int i)
        {
            List<QuestionModel> questionModel = (List<QuestionModel>)questionsRepository.GetQuestions();

            questionViewModel.Questtion = questionModel[i].Question;
            questionViewModel.QuestationId = questionModel[i].Id;

            answerViewModel.AnswerA = questionModel[i].AnswerA;
            answerViewModel.AnswerB = questionModel[i].AnswerB;
            answerViewModel.AnswerC = questionModel[i].AnswerC;
            answerViewModel.AnswerD = questionModel[i].AnswerD;

            answerViewModel.BoolAnswerA = questionModel[i].BoolAnswerA;
            answerViewModel.BoolAnswerB = questionModel[i].BoolAnswerB;
            answerViewModel.BoolAnswerC = questionModel[i].BoolAnswerC;
            answerViewModel.BoolAnswerD = questionModel[i].BoolAnswerD;
        }

        private void finishTest(IQuestionRepository repository)
        {
            saveQuestions(currentQuestionNumber);

            answerHandler.CheckAnswers(repository);

            finishWindow(dialogFinishWndTitle, finalMessage);
        }

        private void finishWindow(string ttl, string msg)
        {
            var dialogWindow = new FinishMessageBox(ttl, msg, MessageBoxButtons.RetryCancel);
            repeatTest(dialogWindow.CheckingIfRepeatTest(answerHandler.ResultOfTest));

        }

        private void repeatTest(bool result)
        {

            if (result)
            {
                questionsRepository.ResetAnswers();

                currentQuestionNumber = 0;

                loadQuestion(currentQuestionNumber);

                checkPossibilitiesToClickForAllButtons(currentQuestionNumber);
            }
            else
            {
                Environment.Exit(0);
            }
        }

        #endregion

    }
}
