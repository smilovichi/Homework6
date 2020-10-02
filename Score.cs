using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6
{
    class Score
    {
        public int score;
        public string currency;
        public Score(string currency)
        {
            this.currency = currency;
        }
        public void AddPoint()
        {
            score++;
        }
        public int GetMoney()
        {
            int money = 0;
            for (int i = 0; i < score; i++)
            {
                if (i == 0)
                {
                    money = 100;
                }
                else
                {
                    money = 2 * money;
                }

            }
            return money;
        }
        public string GetMessage()
        {
            return "Ваш выйгрыш " + GetMoney() + currency;
        }
    }
}
