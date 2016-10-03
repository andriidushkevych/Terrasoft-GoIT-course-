using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hw13.Aggregate;


namespace hw13.Iterator
{
    class IteratorForClassList
    {
        private int position;
        private List<Pupil> Form;


        public IteratorForClassList(List<Pupil> formArg)
        {
            this.Form = formArg;
            position = 0;
        }

        public void SetZeroPosition()
        {
            position = 0;
        }

        public bool IsDone()
        {
            return position >= Form.Count;
        }

        public void First()
        {
            position = 0;
        }

        public Pupil Current()
        {
            return Form.ElementAt(position);
        }

        public Pupil Next()
        {
            return Form.ElementAt(position++);
        }
    }
}
