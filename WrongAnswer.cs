using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6
{
 class WrongAnswer: Answer
    {
        public WrongAnswer(string answerText, string answerLetter) : base(answerText, answerLetter)
        {

        }
        public override void Choose()
        {
            Console.WriteLine("К сожалению, Вы не угадали  и покидаете игру!");
        }
    }
}
