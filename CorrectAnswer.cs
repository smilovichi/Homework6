using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6
{
    class CorrectAnswer: Answer
    {
        public CorrectAnswer(string answerText, string answerLetter) : base(answerText, answerLetter)
        {

        }

        public override void Choose()
        {
            Console.WriteLine("И это правильный ответ!");
        }
    }
}
