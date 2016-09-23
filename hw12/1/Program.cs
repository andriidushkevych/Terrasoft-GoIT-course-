using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program app = new Program();            

            ClassList Form9A = new ClassList();

            Pupil Andrey = new Pupil("Andrey", 15);
            Pupil Sasha = new Pupil("Sasha", 15);
            Pupil Ira = new Pupil("Ira", 14);
            Pupil Vika = new Pupil("Vika", 15);
            Pupil Misha = new Pupil("Misha", 16);

            Form9A.ListOfClass.Add(Andrey);
            Form9A.ListOfClass.Add(Sasha);
            Form9A.ListOfClass.Add(Ira);
            Form9A.ListOfClass.Add(Vika);
            Form9A.ListOfClass.Add(Misha);

            app.ShowMenu(Form9A);

            Console.ReadKey();
        }

        private void ShowMenu(ClassList listOfClassArg)
        {
            Console.WriteLine("Menu: \n1.Add pupil to form\n2.Add pupil's mark\n3.Get average pupil's mark\n4.Get all marks of some pupils over defined age\n5.Exit\n");
            int answer;
            if (int.TryParse(Console.ReadLine(), out answer))
                Switcher(answer, listOfClassArg);
            else
            {
                Console.WriteLine("You should have written the number. Press any key to exit...");
                Console.ReadKey();
                Console.Clear();
                ShowMenu(listOfClassArg);
            }
        }

        private void Switcher(int choiseArg, ClassList listOfClassArg)
        {
            switch (choiseArg)
            {
                case 1:
                    {
                        listOfClassArg.AddPupilToClassList();
                        Console.Clear();
                        ShowMenu(listOfClassArg);
                        break;
                    }
                case 2:
                    {
                        listOfClassArg.ChoosePupilToAddMark();
                        Console.Clear();
                        ShowMenu(listOfClassArg);
                        break;
                    }
                case 3:
                    {
                        listOfClassArg.CountAverageMarkOfPupil();
                        Console.Clear();
                        ShowMenu(listOfClassArg);
                        break;
                    }
                case 4:
                    {
                        listOfClassArg.GetAverageForChosenAge();
                        Console.Clear();
                        ShowMenu(listOfClassArg);
                        break;
                    }
                default:
                    return;

            }
        }
    }
}
