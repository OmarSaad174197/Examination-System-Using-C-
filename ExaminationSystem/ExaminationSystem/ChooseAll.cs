using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class ChooseAll : Question
    {
        public ChooseAll(string body, int marks, string header, string[] options, string[] correctAnswers, string filePath)
       : base(body, marks, header, "ChooseAll", filePath)
        {
            foreach (var option in options)
            {
                bool isCorrect = Array.Exists(correctAnswers, answer => answer == option);
                Answers.AddAnswer(new Answer(option, isCorrect));
            }
        }

        public override void ShowQuestion()
        {
            Console.WriteLine($"{Header}\n{Body}");
            Console.WriteLine("Select all correct answers:");
            for (int i = 0; i < Answers.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Answers[i].StdAnswer}");
            }
        }
    }
}
