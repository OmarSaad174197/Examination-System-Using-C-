using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    // Abstract class that con not be instatiated
    internal abstract class Question
    {
        // Properties for providing encapsulation to access each atrribute.
        public string Body { get; set; }
        public int Marks { get; set; }
        public string Header { get; set; }
        public string QuestionType { get; set; }
        public AnswerList Answers { get; set; }

         string filePath;

        protected Question(string body, int marks, string header, string questionType, string _filePath)
        {
            Body = body;
            Marks = marks;
            Header = header;
            QuestionType = questionType;
            filePath = _filePath;
            Answers = new AnswerList(_filePath);
            InsertQuestionToFile();
        }

        private void InsertQuestionToFile()
        {
            File.AppendAllText(filePath, $"Question: {Header}: {Body} ({Marks} marks) - {QuestionType}\n");
        }
        // Abstract method which will not be implemented here, but in the derived classes (TrueOrFalse, ChooseOne & ChooseAll)
        public abstract void ShowQuestion();
        
        public override string ToString()
        {
            return $"Header: {Header}, Body: {Body}, Marks: {Marks}";
        }
    }
}
