using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6
{
  abstract class Answer
    {
        public Answer(string answerText, string answerLetter)
        {
            this.AnswerText = answerText;
            this.AnswerLetter = answerLetter;
        }
        public string AnswerText;
        public string AnswerLetter;

        public abstract void Choose();
        public void Print()
        {
            Console.WriteLine(AnswerLetter + ") " + AnswerText);

        }
    }
}
