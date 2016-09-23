using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class ClassList
    {
        public List<Pupil> ListOfClass;

        public ClassList()
        {
            ListOfClass = new List<Pupil>();
        }

        public void ShowListOfPupils()
        {
            for(int i = 0; i < ListOfClass.Count; i++)
            {
                Console.WriteLine("{0}. Name: {1}, Age: {2}",i+1, ListOfClass[i].Name, ListOfClass[i].Age);
            }
        }

        public void AddPupilToClassList()
        {
            string nameArg;
            int ageArg;

            Console.Write("Input name of new pupil: ");
            nameArg = Console.ReadLine();
            Console.Write("Input age of new pupil: ");

            if (int.TryParse(Console.ReadLine(), out ageArg))
            {
                ListOfClass.Add(new Pupil(nameArg, ageArg));
                Console.WriteLine("Success! Press any key to continue...");
                Console.ReadKey();
            }                
            else
            {
                Console.WriteLine("Wrong data! Press any key to continue...");
                Console.ReadKey();
                AddPupilToClassList();
            }
        }

        public void ChoosePupilToAddMark()
        {
            int chosenPupil;
            ShowListOfPupils();

            if (int.TryParse(Console.ReadLine(), out chosenPupil))
                ListOfClass[chosenPupil - 1].AddPupilsMark();
            else
            {
                Console.WriteLine("Wrong data! Press any key to continue...");
                Console.ReadKey();
                ChoosePupilToAddMark();
            }
        }

        public void CountAverageMarkOfPupil()
        {
            int chosenPupil;
            ShowListOfPupils();

            if (int.TryParse(Console.ReadLine(), out chosenPupil))
            {
                float res;
                res = ListOfClass[chosenPupil - 1].GetPupilsAverageMark();
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("Wrong data! Press any key to continue...");
                Console.ReadKey();
                CountAverageMarkOfPupil();
            }
        }

        public void GetAverageForChosenAge()
        {
            int chosenAge;
            float result;           

            if (int.TryParse(Console.ReadLine(), out chosenAge))
            {
                foreach(var p in ListOfClass)
                {
                    if (p.Age >= chosenAge)
                    {
                        result += p.GetPupilsAverageMark();
                    }
                }
                Console.WriteLine("Average mark for {0} years pupils is: {1}", chosenAge, result);
            }                
            else
            {
                Console.WriteLine("Wrong data! Press any key to continue...");
                Console.ReadKey();
                GetAverageForChosenAge();
            }
        }

    }
}
