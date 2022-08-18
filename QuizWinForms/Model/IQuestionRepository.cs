using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizBSWinForms.Model
{
    public interface IQuestionRepository
    {
        IEnumerable<QuestionModel> GetQuestions();
    }
}
