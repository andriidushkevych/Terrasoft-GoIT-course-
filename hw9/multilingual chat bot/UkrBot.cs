using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multilingual_chat_bot
{
    class UkrBot:Bot
    {
        public UkrBot(string nameArg)
        {
            Name = nameArg;
        }

        public override void SayHi()
        {            
            Console.WriteLine("DOBRUY DEN', mene zvut' {0}, raduy bachutu vas u chati !", Name);
            Console.WriteLine("Yak vas zvut' ?");
            PersonName = Console.ReadLine();
            Console.WriteLine("Chudovo, {0}, raduy bachutu vas u chati!", PersonName);
            HowAreYou();
        }

        public override void SayBye()
        {
            Console.WriteLine("DO POBACHENYA! ");
            return;
        }

        public override void Missunderstanding()
        {
            Console.WriteLine("YA VAS NE ROZUMIYU :(");
        }

        public override void HowAreYou()
        {
            Console.WriteLine("YAK SPRAVU {0} ?", PersonName);
            Console.ReadLine();
            SayBye();
        }

        public override void StartConversation()
        {
            SayHi();
        }
    }
}
