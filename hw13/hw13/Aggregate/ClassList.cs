using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hw13.Iterator;


namespace hw13.Aggregate
{
    class ClassList
    {
        private List<Pupil> Form;

        public ClassList()
        {
            Form = new List<Pupil>();
            Form.Add(new Pupil("Andrey", 15));
            Form.Add(new Pupil("Vitya", 14));
            Form.Add(new Pupil("Kolya", 15));
            Form.Add(new Pupil("Sasha", 16));
            Form.Add(new Pupil("Misha", 15));
        }

        public IteratorForClassList CreateIterator()
        {
            return new IteratorForClassList(Form);
        }

        public void AddPupilToClassList(ClassList formArg)
        {
            string nameArg;
            int ageArg;

            Console.Write("Input name of new pupil: ");
            nameArg = Console.ReadLine();
            Console.Write("Input age of new pupil: ");

            if (int.TryParse(Console.ReadLine(), out ageArg))
            {
                Form.Add(new Pupil(nameArg, ageArg));
                Console.WriteLine("Success! Press any key to continue...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Wrong data! Press any key to continue...");
                Console.ReadKey();
                AddPupilToClassList(formArg);
            }
        }

        public void ShowClassList(ClassList formArg, IteratorForClassList iterArg)
        {
            int counter = 1;
            while (!iterArg.IsDone())
            {
                Pupil tempPupil = iterArg.Next();                
                Console.WriteLine("{0}. Name: {1}; Age: {2} ", counter, tempPupil.Name, tempPupil.Age);
                counter++;
            }
            iterArg.SetZeroPosition();
        }

        public int ChoosePupil()
        {
            int chosenPupil;
            Console.Write("Choose pupil's number: ");

            if (int.TryParse(Console.ReadLine(), out chosenPupil))
            {
                return chosenPupil;
            }
            else
            {
                Console.WriteLine("Wrong data! Press any key to continue...");
                Console.ReadKey();
                return -1;
            }
        }

        public int ChooseAgeOfPupil()
        {
            int chosenAge;
            Console.Write("Choose pupil's age: ");

            if (int.TryParse(Console.ReadLine(), out chosenAge))
            {
                return chosenAge;
            }
            else
            {
                Console.WriteLine("Wrong data! Press any key to continue...");
                Console.ReadKey();
                return -1;
            }
        }

        public void AddMark(ClassList formArg, IteratorForClassList iterArg)
        {
            ShowClassList(formArg, iterArg);
            
            int chosenPupilArg = ChoosePupil();

            if (chosenPupilArg>=1)
            {
                // Обработать out of range
                Pupil tempPupil = formArg.Form.ElementAt(chosenPupilArg-1);

                string subject;
                int mark;

                Console.Write("Input subject: ");
                subject = Console.ReadLine();
                Console.Write("Input mark: ");

                if (int.TryParse(Console.ReadLine(), out mark))
                {                    
                    tempPupil.SubjectsAndMarksList.Add(subject, mark);
                    Console.WriteLine("Success! Press any key to continue...");                    
                }
                else
                {
                    Console.WriteLine("Wrong data! Press any key to continue...");
                    Console.ReadKey();
                    AddMark(formArg, iterArg);
                }
                
            }
            else
            {
                Console.WriteLine("Wrong Pupil number chosen!");
                return;
            }


        }

        public void CountAverageMarkOfPupil(ClassList formArg, IteratorForClassList iterArg)
        {
            ShowClassList(formArg, iterArg);

            int chosenPupilArg = ChoosePupil();

            if (chosenPupilArg >= 1)
            {
                // Обработать out of range
                Pupil tempPupil = formArg.Form.ElementAt(chosenPupilArg - 1);
                int sum = tempPupil.SubjectsAndMarksList.Sum(x => x.Value);
                float averageMark = sum / tempPupil.SubjectsAndMarksList.Count();
                Console.WriteLine("Average mark of {0} is {1}", tempPupil.Name, averageMark);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Wrong Pupil number chosen!");
                return;
            }

        }

        public void CountAverageMarkOfChosenAgePupils(ClassList formArg, IteratorForClassList iterArg)
        {
            int chosenAge = ChooseAgeOfPupil();

            if (chosenAge>=0)
            {
                int counter = 1;
                List<Pupil> tempList = new List<Pupil>();

                while (!iterArg.IsDone())
                {
                    Pupil tempPupil = iterArg.Next();
                    if (tempPupil.Age == chosenAge)
                    {
                        tempList.Add(tempPupil);
                    }
                    counter++;
                }
                iterArg.SetZeroPosition();

                foreach (var pup in tempList)
                {
                    int sum = pup.SubjectsAndMarksList.Sum(x => x.Value);
                    int count = pup.SubjectsAndMarksList.Count();
                    if (count != 0)
                    {
                        float averageMark = sum / pup.SubjectsAndMarksList.Count();
                        Console.WriteLine("Average mark of {0} is {1}", pup.Name, averageMark);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("{0}, whose age is {1} has no marks", pup.Name, pup.Age);
                        Console.ReadKey();
                    }
                }
            }
            else
            {
                Console.WriteLine("Wrong Pupil number chosen!");
                return;
            }

        }
    }
}
