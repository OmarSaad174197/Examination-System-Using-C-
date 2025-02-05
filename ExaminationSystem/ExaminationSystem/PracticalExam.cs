using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(string filePath) : base("Practical Exam", filePath) { }

        public void AddQuestion(Question question)
        {
            Questions.AddQuestion(question);
        }

        public override void ShowExam()
        {
            Console.WriteLine(" Practical Exam ");

            foreach (var question in Questions)
            {
                question.ShowQuestion();

                Console.Write("Your Answer: ");
                string StdAnswer= Console.ReadLine();


                SubmitAnswer(question, StdAnswer);
            }

            int score = CorrectExam();
            Console.WriteLine($"\nYour Score: {score}/{Questions.Count * 2}");
        }
    }
}
