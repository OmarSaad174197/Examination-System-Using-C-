using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class Answer
    {
        public string StdAnswer { get; set; }
        public bool IstheAnswerIsCorrect { get; set; }

        public Answer(string _StdAnswer, bool _IstheAnswerIsCorrect)
        {
            StdAnswer = _StdAnswer;
            IstheAnswerIsCorrect = _IstheAnswerIsCorrect;
        }

    }
}
