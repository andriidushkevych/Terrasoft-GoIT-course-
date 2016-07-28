using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    abstract class Sport
    {
        private string title;
        private Award award = new Award();

        public void setTitle(String title) {
            this.title = title;
        }

        public String getTitle()
        {
            return title;
        }
    }
}
