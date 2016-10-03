using hw13.Aggregate;
using hw13.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw13
{
    class Program
    {
        static void Main(string[] args)
        {
            Program app = new Program();

            ClassList form9A = new ClassList();
            IteratorForClassList iter = form9A.CreateIterator();

            app.Menu(form9A, iter);

            Console.ReadKey();
        }

        private void Menu(ClassList classListArg, IteratorForClassList iterArg)
        {
            Console.WriteLine("Menu: \n1.Add pupil to form\n2.Add pupil's mark\n3.Get average pupil's mark\n4.Get all marks of some pupils over defined age\n5.Exit\n");
            int answer;
            if (int.TryParse(Console.ReadLine(), out answer))
                Switcher(answer, classListArg, iterArg);
            else
            {
                Console.WriteLine("You should have written the number. Press any key to exit...");
                Console.ReadKey();
                Console.Clear();
                Menu(classListArg, iterArg);
            }
        }

        private void Switcher(int choiseArg, ClassList classListArg, IteratorForClassList iterArg)
        {
            switch (choiseArg)
            {
                case 1:
                    {
                        classListArg.AddPupilToClassList(classListArg);
                        Console.Clear();
                        Menu(classListArg, iterArg);
                        break;
                    }
                case 2:
                    {
                        classListArg.AddMark(classListArg, iterArg);
                        Console.ReadKey();
                        Console.Clear();
                        Menu(classListArg, iterArg);
                        break;
                    }
                case 3:
                    {
                        classListArg.CountAverageMarkOfPupil(classListArg, iterArg);
                        Console.Clear();
                        Menu(classListArg, iterArg);
                        break;
                    }
                case 4:
                    {
                        classListArg.CountAverageMarkOfChosenAgePupils(classListArg, iterArg);
                        Console.Clear();
                        Menu(classListArg, iterArg);
                        break;
                    }


                default:
                    return;

            }
        }
    }
}

