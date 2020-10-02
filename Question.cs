using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6
{
    class Question
    {

        public Question[] questions;
        public Question(string questionText)
        {
            this.QuestionText = questionText;
        }
        public string QuestionText;
        public Answer[] Answers;
        public void Print()
        {
            Console.WriteLine(QuestionText);
            foreach (Answer answer in Answers)
            {
                answer.Print();
            }
        }
        public bool IsCorrectAnswer(string userAnswer)
        {
            foreach (Answer answer in Answers)
            {
                if (answer.AnswerLetter == userAnswer)
                {
                    return answer is CorrectAnswer;
                }
            }
            return false;
        }
    }
}
