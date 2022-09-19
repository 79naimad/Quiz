using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuizBSWinForms.BusinessLogic;
using QuizBSWinForms.View;
using System.Windows.Forms;

namespace QuizBSWinFormsTests
{
    [TestClass]
    public class ButtonManagerTests
    {
        public ButtonManagerTests()
        {
        }

        [TestMethod]
        public void CheckPossiblitiesToClickTheButtonTests()
        {

            #region Arrange

            const int currentQuestion = 2;

            #endregion

            #region Act & Asserts

            Assert.IsFalse(ButtonManager.CheckPossiblitiesToClickTheButton(1, currentQuestion, ButtonManager.ButtonType.singlePossibilites));
            Assert.IsTrue(ButtonManager.CheckPossiblitiesToClickTheButton(2, currentQuestion, ButtonManager.ButtonType.singlePossibilites));
            Assert.IsTrue(ButtonManager.CheckPossiblitiesToClickTheButton(1, currentQuestion, ButtonManager.ButtonType.multiplePossibilites));
            Assert.IsFalse(ButtonManager.CheckPossiblitiesToClickTheButton(2, currentQuestion, ButtonManager.ButtonType.multiplePossibilites));

            #endregion

        }

    }
}
