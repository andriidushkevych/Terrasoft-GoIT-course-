using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multilingual_chat_bot
{
    class RusBot:Bot
    {
        public RusBot(string nameArg)
        {
            Name = nameArg;
        }

        public override void SayHi()
        {            
            Console.WriteLine("PRIVET, menya zovut {0}, dobro pozhalovat' v chat !", Name);
            Console.WriteLine("Kak tebya zovut ?");
            PersonName = Console.ReadLine();
            Console.WriteLine("Otlichno, {0}, rad tebya videt'!", PersonName);
            HowAreYou();
        }

        public override void SayBye()
        {
            Console.WriteLine("POKA !");
            return;
        }

        public override void Missunderstanding()
        {
            Console.WriteLine("NE PONIMAYU VAS :(");
        }

        public override void HowAreYou()
        {
            Console.WriteLine("KEK DELA {0} ?", PersonName);
            Console.ReadLine();
            SayBye();
        }

        public override void StartConversation()
        {
            SayHi();
        }
    }
}
