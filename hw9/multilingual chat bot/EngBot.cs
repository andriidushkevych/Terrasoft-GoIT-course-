using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multilingual_chat_bot
{
    class EngBot:Bot
    {
        public EngBot(string nameArg)
        {
            Name = nameArg;
        }

        public override void SayHi()
        {
            Console.WriteLine("HI, My name is {0}, welcome to chat !", Name);
            Console.WriteLine("What is your name ?");
            PersonName = Console.ReadLine();
            Console.WriteLine("Fine, {0}, nice to see you here!", PersonName);
            HowAreYou();
        }

        public override void SayBye()
        {
            Console.WriteLine("Bye bye !");
            return;
        }

        public override void Missunderstanding()
        {
            Console.WriteLine("I'm so sorry, I can't understand you :(");
        }

        public override void HowAreYou()
        {
            Console.WriteLine("How are you doing today, {0} ?", PersonName);
            Console.ReadLine();
            SayBye();
        }

        public override void StartConversation()
        {
            SayHi();
        }

    }
}
