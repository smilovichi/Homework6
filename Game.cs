using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6
{
    class Game
    {
        public Question[] questions;
        public Game(Question[] questions)
        {
            this.questions = questions;
        }
        public void Run()
        {
            Console.WriteLine("Добро пожаловать в игру 'Кто хочет стать миллионером?'!");
            Console.WriteLine("Компьютер будет задавать Вам вопросы и предлагать 4 варианта ответа.");
            Console.WriteLine(" Вам необходимо будет выбрать A, B, C или D. В случае правильного ответа, выйгрыш будет удваиваться!");
            Console.WriteLine("В случае неправильного ответа, Вы покидаете игру");
            Console.WriteLine("Чтобы начать, введите свое имя");

            User user = new User();
            user.userName = Console.ReadLine();

            Console.WriteLine("Итак, " + user.userName + " мы начинаем игру!");
            Score score = new Score("BYN");

            for (int i = 0; i < questions.Length; i++)
            {
                questions[i].Print();

                if (i != 0)
                {
                    Console.WriteLine("Если Вы хотите забрать выйгрыш и покинуть игру, введите Х");
                }
                string userInput = Console.ReadLine();
                if (i != 0 && userInput == "X")

                {
                    Console.WriteLine(score.GetMessage());
                    return;
                }

                if (questions[i].IsCorrectAnswer(userInput))
                {
                    score.AddPoint();

                    Console.WriteLine("И это правильный ответ! " + score.GetMessage());
                }
                else
                {
                    Console.WriteLine("К сожалению,Вы не угадали и покидаете игру!");
                    return;
                }
            }
        }
    }
  
}
