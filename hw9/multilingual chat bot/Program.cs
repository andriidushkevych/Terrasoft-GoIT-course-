using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multilingual_chat_bot
{
    class Program
    {
        static void Main(string[] args)
        {
            //Попробуем разработать чат на 5 слов.
            //Для этого придется написать бота (то есть автоматизированного собеседника)
            //Создайте абстрактного бота, пусть там будет свойство Имя и абстрактные методы:
            //Поздороваться, попрощаться, сказать что не понял вопрос, и как дела.
            //У этого абстрактного бота будет несколько наследников, которые представляют национальность (русский, украинец, американец...). (По желанию можно реализовать характер).
            //Должно получиться так, что при вызове метода Поздороваться выводилось приветствие на языке соответствующему национальности (Привет, Привіт, Hi...).
            //Итого, должен получится час с мульти язычным ботом. Скромный, но чат.
            Start();
            
            Console.ReadKey();
        }

        static void InCaseOfError()
        {
            Console.WriteLine("Error!!! (press any key to continue...)");
            Console.ReadKey();
            Console.Clear();
            Start();
        }

        static void Start()
        {
            Console.WriteLine("Choose your language: \n1.English \n2.Ukrainian \n3.Russian");
            string answLine = Console.ReadLine();
            int answNum;
            bool checker = int.TryParse(answLine, out answNum);
            if (checker && (answNum == 1 || answNum == 2 || answNum == 3))
            {
                Switcher(answNum);
            }
            else InCaseOfError();
        }

        static void Switcher(int answArg)
        {
            switch (answArg)
            {
                case (1):
                    {
                        string name = "John";
                        EngBot eb = new EngBot(name);
                        eb.StartConversation();
                        break;
                    }
                case (2):
                    {
                        string name = "Ivan";
                        UkrBot ub = new UkrBot(name);
                        ub.StartConversation();
                        break;
                    }
                case (3):
                    {
                        string name = "Vanya";
                        RusBot rb = new RusBot(name);
                        rb.StartConversation();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
    }
}
