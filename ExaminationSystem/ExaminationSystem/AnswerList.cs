using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class AnswerList : List<Answer>
    {
        string filePath;

        public AnswerList(string _filePath)
        {
            filePath = _filePath;
        }


        public void AddAnswer(Answer answer)
        {
            this.Add(answer);
            InsertAnswerToFile(answer);
        }


        private void InsertAnswerToFile(Answer answer)
        {
            File.AppendAllText(filePath, $"Answer: {answer.StdAnswer}, Correct: {answer.IstheAnswerIsCorrect}\n");
        }
    }
}
