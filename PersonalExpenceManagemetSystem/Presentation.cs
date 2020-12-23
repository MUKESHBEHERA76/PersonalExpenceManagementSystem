using BussinessLogicLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExpenceManagemetSystem
{
    class Presentation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("Welcome to personal Expence Management System");
            Console.WriteLine("***********************************************");
            Entity entity = new Entity();
            BussinessLogic logic = new BussinessLogic();
            //try
            //{
                int choice;
                while (true)
                {
                    Console.WriteLine("1. Create Budget");
                    Console.WriteLine("2. View Budget");
                    Console.WriteLine("3. Add Expence");
                    Console.WriteLine("4. View Expence");
                    Console.WriteLine("0. Exit");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            if (logic.CheckMonth(VarifyMonth()))
                            {
                                Console.WriteLine($"Wow ! Create your budget for{entity.Month}");
                                if (logic.AddList(AddExpence()))
                                    Console.WriteLine("Budget Created succesfully");
                                else
                                    Console.WriteLine("Unable to create a budget");
                            }
                            else
                            {
                                Console.WriteLine($"Budget for the {entity.Month} is Already exist or not a valid month !!");
                            }
                            break;
                        case 2:
                            Console.WriteLine("Enter First Three Digit of the Month for viewing budget ex(Jan)");
                            string MonthGettter = Console.ReadLine();
                            Entity monthsetter = logic.SearchBymonth(MonthGettter);
                            if (monthsetter != null)
                            {
                                Console.WriteLine("___________________________________________________________");
                                Console.WriteLine($"{monthsetter.Grocery} {monthsetter.Medical} {monthsetter.Personal} {monthsetter.Rent} {monthsetter.EMI} {monthsetter.Travelling}");
                                Console.WriteLine("___________________________________________________________");
                            }
                            else
                            {
                                Console.WriteLine($"No budget created for {MonthGettter}");
                            }

                            break;

                    }
                }

            //}
            //catch (SystemException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

        }
        public static Entity AddExpence()
        {
            Entity entity = new Entity();
            try
            {
                entity.Month = Console.ReadLine();
                Console.WriteLine("Enter Budget for Grocery");
                entity.Grocery = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Budget for Medical");
                entity.Medical = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Budget for Personal");
                entity.Personal = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Budget for Rent");
                entity.Rent = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Budget for EMI");
                entity.EMI = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Budget for Travelling");
                entity.Travelling = Convert.ToDouble(Console.ReadLine());
            }
            catch (SystemException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //catch(ApplicationException ex)
            //{
            //    WriteLine("Something went wrong !!");
            //}
            return entity;

        }
        public static Entity VarifyMonth()
        {
            Entity entity = new Entity();
            Console.WriteLine("Enter First Three Digit of the Month for creating budget ex(Jan)");
            entity.Month = Console.ReadLine();
            return entity;
        }
    }
    
}
