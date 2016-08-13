using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multilingual_chat_bot
{
    abstract class Bot
    {
        public string Name { get; set; }
        public string PersonName { get; set; }


        abstract public void SayHi();
        abstract public void SayBye();
        abstract public void Missunderstanding();
        abstract public void HowAreYou();
        abstract public void StartConversation();

    }
}
