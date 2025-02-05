using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class ChooseOne : Question
    {
        public ChooseOne(string body, int marks, string header, string[] choices, string correctAnswer, string filePath)
        : base(body, marks, header, "ChooseOne", filePath)
        {
            foreach (var choice in choices)
            {
                Answers.AddAnswer(new Answer(choice, choice == correctAnswer));
            }
        }

        public override void ShowQuestion()
        {
            Console.WriteLine($"{Header}\n{Body}");
            Console.WriteLine("Choices:");
            for (int i = 0; i < Answers.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Answers[i].StdAnswer}");
            }
        }
    }
}
