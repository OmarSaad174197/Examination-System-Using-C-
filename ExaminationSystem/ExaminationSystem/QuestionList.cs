using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExaminationSystem
{
    internal class QuestionList : List<Question>
    {
        string filePath;

        public QuestionList(string _filePath)
        {
            filePath = _filePath;
        }

        public void AddQuestion(Question question)
        {
            Add(question);
            File.AppendAllText(filePath, $"Question Added: {question.Header}: {question.Body} ({question.Marks} marks)\n");
        }
    }
}