using System;



namespace Homework6

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;



            Question[] questions = new Question[5];
            questions[0] = new Question("Назовите драгоценный камень зеленого цвета");
            questions[1] = new Question("На какой естественный предмет больше всего похожа по своему строению Земля?");
            questions[2] = new Question("Сколько глаз у пчелы?");
            questions[3] = new Question("Из чего состоит горбу у верблюда?");
            questions[4] = new Question("У кого ухо на ноге?");
            questions[0].Answers = new Answer[4];
            questions[0].Answers[0] = new WrongAnswer("берилл", "A");
            questions[0].Answers[1] = new WrongAnswer("александрит", "B");
            questions[0].Answers[2] = new CorrectAnswer("изумруд", "C");
            questions[0].Answers[3] = new WrongAnswer("опал", "D");

            questions[1].Answers = new Answer[4];
            questions[1].Answers[0] = new CorrectAnswer("яйцо", "A");
            questions[1].Answers[1] = new WrongAnswer("яблоко", "B");
            questions[1].Answers[2] = new WrongAnswer("мяч", "C");
            questions[1].Answers[3] = new WrongAnswer("фасоль", "D");

            questions[2].Answers = new Answer[4];
            questions[2].Answers[0] = new WrongAnswer("2", "A");
            questions[2].Answers[1] = new CorrectAnswer("5", "B");
            questions[2].Answers[2] = new WrongAnswer("4", "C");
            questions[2].Answers[3] = new WrongAnswer("3", "D");

            questions[3].Answers = new Answer[4];
            questions[3].Answers[0] = new WrongAnswer("вода", "A");
            questions[3].Answers[1] = new WrongAnswer("мышцы", "B");
            questions[3].Answers[2] = new CorrectAnswer("жир", "C");
            questions[3].Answers[3] = new WrongAnswer("песок", "D");

            questions[4].Answers = new Answer[4];
            questions[4].Answers[0] = new WrongAnswer("скоробей", "A");
            questions[4].Answers[1] = new WrongAnswer("майский жук", "B");
            questions[4].Answers[2] = new WrongAnswer("муха", "C");
            questions[4].Answers[3] = new CorrectAnswer("кузнечик", "D");
                                                         

            Game game = new Game(questions);
            game.Run();


        }
    }
}







     

            

                
