using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Pupil
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public List<Tuple<string, int>> Marks;


        public Pupil(string nameArg, int ageArg)
        {
            Name = nameArg;
            Age = ageArg;
            Marks = new List<Tuple<string, int>>();
        }

        public void AddPupilsMark()
        {
            string subjectArg;
            int markArg;

            Console.Write("Input subject: ");
            subjectArg = Console.ReadLine();
            Console.Write("Input mark: ");

            if (int.TryParse(Console.ReadLine(), out markArg))
            {

                Tuple<string, int> tempTuple = new Tuple<string, int>(subjectArg, markArg);
                Marks.Add(tempTuple);
                Console.WriteLine("Success! Press any key to continue...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Wrong data! Press any key to continue...");
                Console.ReadKey();
                AddPupilsMark();
            }

        }

        public float GetPupilsAverageMark()
        {
            if(Marks.Count != 0)
            {
                int total = 0;
                float resultAverageMark = 0;

                foreach (var mark in Marks)
                {
                    total += mark.Item2;                    
                }

                resultAverageMark = total / Marks.Count;
                return resultAverageMark;

                
            }
            else
            {                
                return 0;
            }
        }

        //public float GetAverageMarkForPupil()
        //{

        //}
    }
}
