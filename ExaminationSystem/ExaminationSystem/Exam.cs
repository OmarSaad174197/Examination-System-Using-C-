using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    // Abstract calss that cannot be instantiated, inherits from interfaces (IComparable & Iclonable)
    internal abstract class Exam 
    {
        public string ExamType { get; set; }
        public QuestionList Questions { get; set; }
        public Dictionary<Question, Answer> QuestionAnswerMap { get; set; }

        public event EventHandler<string> OnExamStarted;


        protected readonly string FilePath;

        protected Exam(string examType, string filePath)
        {
            ExamType = examType;
            FilePath = filePath;
            Questions = new QuestionList(filePath);
            QuestionAnswerMap = new Dictionary<Question, Answer>();
        }

        public void StartExam()
        {
            OnExamStarted?.Invoke(this, $"{ExamType} has started!");
        }

        public void SubmitAnswer(Question question, string Answer)
        {

            Answer studentAnswer = new Answer(Answer, false);
            QuestionAnswerMap[question] = studentAnswer;
        }

        public int CorrectExam()
        {
            int score = 0;

            foreach (var entry in QuestionAnswerMap)
            {
                Question question = entry.Key;
                Answer studentAnswer = entry.Value;


                foreach (var correctAnswer in question.Answers)
                {
                    if (correctAnswer.StdAnswer.Equals(studentAnswer.StdAnswer, StringComparison.OrdinalIgnoreCase)
                        && correctAnswer.IstheAnswerIsCorrect)
                    {
                        score += question.Marks;
                        break;
                    }
                }
            }
            return score;
        }

        public abstract void ShowExam();
    }
}