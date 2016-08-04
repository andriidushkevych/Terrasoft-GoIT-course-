using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMenu();
            
            Console.ReadKey();
        }

        static Worker[] CreateWorkers()
        {
            Guard VityaGuard = new Guard();
            VityaGuard.Name = "VityaGuard";
            Guard SashaGuard = new Guard();
            SashaGuard.Name = "SashaGuard";

            RegularWorker DenisRegularWorker = new RegularWorker();
            DenisRegularWorker.Name = "DenisRegularWorker";
            RegularWorker ArtemRegularWorker = new RegularWorker();
            ArtemRegularWorker.Name = "ArtemRegularWorker";

            Phychologist IraPhychologist = new Phychologist();
            IraPhychologist.Name = "IraPhychologist";
            Phychologist OlyaPhychologist = new Phychologist();
            OlyaPhychologist.Name = "OlyaPhychologist";

            Doctor MishaDoctor = new Doctor();
            MishaDoctor.Name = "MishaDoctor";
            Doctor KatyaDoctor = new Doctor();
            KatyaDoctor.Name = "KatyaDoctor";

            Worker[] workers = new Worker[] { VityaGuard, SashaGuard, DenisRegularWorker, ArtemRegularWorker, IraPhychologist, OlyaPhychologist, MishaDoctor, KatyaDoctor };
            return workers;
        }

        static void InCaseOfError()
        {
            Console.WriteLine("You have pressed wrong key, try again(press any key to continue...)");
            Console.ReadKey();
            Console.Clear();

            ShowMenu();
        }

        static void ShowMenu(int answ = 0)
        {            
            Console.WriteLine("Choose worker to count his wage: ");
            Console.WriteLine("");
            ShowWorkerList(CreateWorkers());
            
            bool result = int.TryParse(Console.ReadLine(), out answ);

            if (result)
            {
                Switcher(answ);
            }
            else
            {
                InCaseOfError();
            }
        }

        static void ShowWorkerList(Worker[] workersArgArr)
        {
            for (int i = 0; i < workersArgArr.Length; i++)
            {
                string str = string.Format((i+1) +". {0}. \n", workersArgArr[i].Name);
                Console.WriteLine(str);
            }
            
        }

        static void GetWorkerType(int answArg, Worker[] workersArgArr)
        {
            
            answArg--;
            if (workersArgArr[answArg] is Guard)
            {
                CountGuardsWage(workersArgArr[answArg].Name, (Guard)workersArgArr[answArg]);
            }else if (workersArgArr[answArg] is RegularWorker)
            {
                CountRegularWorkersWage(workersArgArr[answArg].Name, (RegularWorker)workersArgArr[answArg]);
            }else if (workersArgArr[answArg] is Phychologist)
            {
                CountPhychologistsWage(workersArgArr[answArg].Name, (Phychologist)workersArgArr[answArg]);
            }else if (workersArgArr[answArg] is Doctor)
            {
                CountDoctorsWage(workersArgArr[answArg].Name, (Doctor)workersArgArr[answArg]);
            }else
            {
                Console.WriteLine("Something wrong, try again(press any key to continue...)");
                Console.ReadKey();
                Console.Clear();
                ShowMenu();
            }
        }

        static void Switcher(int answArg)
        {
            
            switch (answArg)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                    {
                        GetWorkerType(answArg, CreateWorkers());
                        break;
                    }
                default:
                    {
                        InCaseOfError();
                        break;
                    }
            }

        }

        static void CountGuardsWage(string workersName, Guard workerObjArg)
        {
            
            Console.WriteLine("Input {0}s experience", workersName);            
            float a1;
            bool r1 = float.TryParse(Console.ReadLine(), out a1);

            if (r1)
            {
                workerObjArg.Experience = a1; 
            }
            else
            {
                InCaseOfError();
            }



            Console.WriteLine("Input how many hours had {0} worked", workersName);
            float a;
            bool r = float.TryParse(Console.ReadLine(), out a);

            if (r)
            {
                workerObjArg.HoursWorked = a;
            }
            else
            {
                InCaseOfError();
            }


            Console.WriteLine("Input {0}s hourly wage", workersName);
            float a2;
            bool r2 = float.TryParse(Console.ReadLine(), out a2);

            if (r2)
            {
                workerObjArg.HourlyWage = a2;
            }
            else
            {
                InCaseOfError();
            }


            Console.WriteLine("Input {0}s bonus multiplier", workersName);            
            float a3;
            bool r3 = float.TryParse(Console.ReadLine(), out a3);

            if (r3)
            {
                workerObjArg.BonusMultiplier = a3;
            }
            else
            {
                InCaseOfError();
            }


            Console.WriteLine("Input {0}s number of night hours", workersName);
            float a4;
            bool r4 = float.TryParse(Console.ReadLine(), out a4);

            if (r4)
            {
                workerObjArg.NumberOfNightHours = a4;
            }
            else
            {
                InCaseOfError();
            }


            float wage = ((1 + 0.1F * workerObjArg.Experience) + (workerObjArg.HoursWorked * workerObjArg.HourlyWage) + (workerObjArg.NumberOfNightHours * workerObjArg.HourlyWage * workerObjArg.BonusMultiplier));
            Console.WriteLine("{0}s wage for this month = {1}", workersName , wage);
            return;
        }

        static void CountRegularWorkersWage(string workersName, RegularWorker workerObjArg)
        {
            Console.WriteLine("Input {0}s experience", workersName);
            float a1;
            bool r1 = float.TryParse(Console.ReadLine(), out a1);

            if (r1)
            {
                workerObjArg.Experience = a1;
            }
            else
            {
                InCaseOfError();
            }


            Console.WriteLine("Input how many hours had {0} worked", workersName);
            float a;
            bool r = float.TryParse(Console.ReadLine(), out a);

            if (r)
            {
                workerObjArg.HoursWorked = a;
            }
            else
            {
                InCaseOfError();
            }


            Console.WriteLine("Input {0}s hourly wage", workersName);
            float a2;
            bool r2 = float.TryParse(Console.ReadLine(), out a2);

            if (r2)
            {
                workerObjArg.HourlyWage = a2;
            }
            else
            {
                InCaseOfError();
            }


            Console.WriteLine("Input {0}s bonus multiplier", workersName);
            float a3;
            bool r3 = float.TryParse(Console.ReadLine(), out a3);

            if (r3)
            {
                workerObjArg.BonusMultiplier = a3;
            }
            else
            {
                InCaseOfError();
            }


            Console.WriteLine("Input {0}s number of night hours", workersName);
            float a4;
            bool r4 = float.TryParse(Console.ReadLine(), out a4);

            if (r4)
            {
                workerObjArg.Overtime = a4;
            }
            else
            {
                InCaseOfError();
            }


            float wage = ((1 + 0.1F * workerObjArg.Experience) + (workerObjArg.HoursWorked * workerObjArg.HourlyWage) + (workerObjArg.Overtime * workerObjArg.HourlyWage * workerObjArg.BonusMultiplier));
            Console.WriteLine("{0}s wage for this month = {1}", workersName, wage);
            return;
        }

        static void CountPhychologistsWage(string workersName, Phychologist workerObjArg)
        {
            Console.WriteLine("Input {0}s experience", workersName);
            float a1;
            bool r1 = float.TryParse(Console.ReadLine(), out a1);

            if (r1)
            {
                workerObjArg.Experience = a1;
            }
            else
            {
                InCaseOfError();
            }


            Console.WriteLine("Input how many hours had {0} worked", workersName);
            float a;
            bool r = float.TryParse(Console.ReadLine(), out a);

            if (r)
            {
                workerObjArg.HoursWorked = a;
            }
            else
            {
                InCaseOfError();
            }


            Console.WriteLine("Input {0}s hourly wage", workersName);
            float a2;
            bool r2 = float.TryParse(Console.ReadLine(), out a2);

            if (r2)
            {
                workerObjArg.HourlyWage = a2;
            }
            else
            {
                InCaseOfError();
            }


            Console.WriteLine("Input {0}s bonus multiplier", workersName);
            float a3;
            bool r3 = float.TryParse(Console.ReadLine(), out a3);

            if (r3)
            {
                workerObjArg.BonusMultiplier = a3;
            }
            else
            {
                InCaseOfError();
            }


            Console.WriteLine("Input {0}s number of night hours", workersName);
            int a4;
            bool r4 = int.TryParse(Console.ReadLine(), out a4);

            if (r4)
            {
                workerObjArg.NumberOfPatients = a4;
            }
            else
            {
                InCaseOfError();
            }


            float wage = ((1 + 0.1F * workerObjArg.Experience) + (workerObjArg.HoursWorked * workerObjArg.HourlyWage) + (workerObjArg.NumberOfPatients * workerObjArg.HourlyWage * workerObjArg.BonusMultiplier));
            Console.WriteLine("{0}s wage for this month = {1}", workersName, wage);
            return;
        }

        static void CountDoctorsWage(string workersName, Doctor workerObjArg)
        {
            Console.WriteLine("Input {0}s experience", workersName);
            float a1;
            bool r1 = float.TryParse(Console.ReadLine(), out a1);

            if (r1)
            {
                workerObjArg.Experience = a1;
            }
            else
            {
                InCaseOfError();
            }


            Console.WriteLine("Input how many hours had {0} worked", workersName);
            float a;
            bool r = float.TryParse(Console.ReadLine(), out a);

            if (r)
            {
                workerObjArg.HoursWorked = a;
            }
            else
            {
                InCaseOfError();
            }


            Console.WriteLine("Input {0}s hourly wage", workersName);
            float a2;
            bool r2 = float.TryParse(Console.ReadLine(), out a2);

            if (r2)
            {
                workerObjArg.HourlyWage = a2;
            }
            else
            {
                InCaseOfError();
            }


            Console.WriteLine("Input {0}s bonus multiplier", workersName);
            float a3;
            bool r3 = float.TryParse(Console.ReadLine(), out a3);

            if (r3)
            {
                workerObjArg.BonusMultiplier = a3;
            }
            else
            {
                InCaseOfError();
            }


            Console.WriteLine("Input {0}s number of night hours", workersName);
            int a4;
            bool r4 = int.TryParse(Console.ReadLine(), out a4);

            if (r4)
            {
                workerObjArg.NumberOfPatients = a4;
            }
            else
            {
                InCaseOfError();
            }


            float wage = (( 1 + 0.1F * workerObjArg.Experience) + (workerObjArg.HoursWorked * workerObjArg.HourlyWage) + (workerObjArg.NumberOfPatients * workerObjArg.HourlyWage * workerObjArg.BonusMultiplier));
            Console.WriteLine("{0}s wage for this month = {1}", workersName, wage);
            return;
        }
    }
}
