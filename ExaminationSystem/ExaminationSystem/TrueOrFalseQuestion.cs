using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class TrueOrFalse : Question
    {
        public TrueOrFalse(string body, int marks, string header, bool correctAnswer, string filePath)
        : base(body, marks, header, "TrueFalse", filePath)
        {
            Answers.AddAnswer(new Answer("True", correctAnswer));
            Answers.AddAnswer(new Answer("False", !correctAnswer));
        }

        public override void ShowQuestion()
        {
            Console.WriteLine($"{Header}\n{Body}");
            Console.WriteLine("1. True\n2. False");
        }
    }
}
