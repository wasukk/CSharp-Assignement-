using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Console.Title = "Task 1";
            ///Console.WriteLine("YA ALLAH");
            ///Console.Read();
            
            Console.WriteLine("List of Tasks assigned by Sir. Noman.");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Task 1 : Show 'YA ALLAH'  to top left corner of the screen");
            Console.WriteLine("Task 2 : Show 'F','A','T','H' to top left, right, top, bottom corners respectively, and 'I' on the center of the screen");
            Console.WriteLine("Task 3 : Show Mark Statement");
            Console.WriteLine("Task 4 : Show House Drawing");
            Console.WriteLine("Task 5 : Coulorful A to Z alphabat ");
            Console.WriteLine("Task 6 : CV");
            Console.WriteLine("Please Enter Task");
            string task =  Console.ReadLine();
            if (task == "Task1" || task == "task1" || task == "1")
            {
                Console.Clear();
                Console.Title = "Task 1";
                Console.WriteLine("YA ALLAH");
            } /// End of Task 1
              
            if (task == "Task2" || task == "task2" || task == "2")
            {
                Console.Clear();
                Console.Title = "Task 2";
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("F");
                Console.SetCursorPosition(118, 0);
                Console.WriteLine("A");
                Console.SetCursorPosition(59, 10);
                Console.WriteLine("I");
                Console.SetCursorPosition(0, 20);
                Console.WriteLine("T");
                Console.SetCursorPosition(118, 20);
                Console.WriteLine("H");
            } /// End of Task 2
              
            if (task == "Task3" || task == "task3" || task == "3")
            {
                Console.Clear();
                Console.Title = "Task 3";
                Console.SetCursorPosition(25, 0);
                Console.WriteLine("Statement Of Marks");
                Console.SetCursorPosition(25, 1);
                Console.WriteLine("==================");
                Console.WriteLine("Name: \t \t Fahad Ali");
                Console.WriteLine("Father's Name: \t Muhammad Ali");
                Console.WriteLine("Collage: \t Faith Collage of Information Technology");
                Console.SetCursorPosition(0, 6);
                Console.WriteLine("=====================================================================");
                Console.WriteLine("SUBJECT \t COMBINED MARKS \t PERCENTAGE \t REMARKS");
                Console.WriteLine("=====================================================================");
                Console.WriteLine("URDU \t \t 144/200 \t \t 72 \t\t Pass");
                Console.WriteLine("ENGLISH \t 123/200 \t \t 61.50 \t\t Pass");
                Console.WriteLine("ISLAMYAT \t 44/50 \t \t \t 88 \t\t Pass");
                Console.WriteLine("PAK STUDIES \t 40/50 \t \t \t 80 \t\t Pass");
                Console.WriteLine("CHEMISTRY \t 72/100 \t \t 72 \t\t Pass");
                Console.WriteLine("MATH \t \t 80/100 \t \t 80 \t\t Pass");
                Console.WriteLine("PHYSICS \t 86/100 \t\t 86 \t \t Pass");
                Console.WriteLine("=====================================================================");
                Console.WriteLine("Total \t\t 589/800 \t\t 73.62% \t  Grade A");
                Console.WriteLine("=====================================================================");
            } ///End of Task 3

            if (task == "Task4" || task == "task4" || task == "4")
            {
                Console.Clear();
                Console.Title = "Task 4";
                Console.SetCursorPosition(25, 0);
                Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||");
                Console.SetCursorPosition(24, 1);
                Console.WriteLine("||| |||****************************************|||");
                Console.SetCursorPosition(23, 2);
                Console.WriteLine("|||  |||*****************************************|||");
                Console.SetCursorPosition(22, 3);
                Console.WriteLine("|||    |||*****************************************|||");
                Console.SetCursorPosition(21, 4);
                Console.WriteLine("|||      |||*****************************************|||");
                Console.SetCursorPosition(20, 5);
                Console.WriteLine("|||       |||*******************************************|||");
                Console.SetCursorPosition(19, 6);
                Console.WriteLine("|||         |||********************************************|||");
                Console.SetCursorPosition(18, 7);
                Console.WriteLine("|||           |||*******************************************|||");
                Console.SetCursorPosition(18, 8);
                Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
                Console.SetCursorPosition(18, 9);
                Console.WriteLine("|||            |||                                          |||");
                Console.SetCursorPosition(18, 10);
                Console.WriteLine("|||            |||                                          |||");
                Console.SetCursorPosition(18, 11);
                Console.WriteLine("|||            |||                                          |||");
                Console.SetCursorPosition(18, 12);
                Console.WriteLine("|||            |||           ||------------------||         ||| ");
                Console.SetCursorPosition(18, 13);
                Console.WriteLine("|||            |||           ||                  ||         ||| ");
                Console.SetCursorPosition(18, 14);
                Console.WriteLine("|||            |||           ||                  ||         |||");
                Console.SetCursorPosition(18, 15);
                Console.WriteLine("|||            |||           ||------------------||         |||");
                Console.SetCursorPosition(18, 16);
                Console.WriteLine("|||            |||                                          |||");
                Console.SetCursorPosition(18, 17);
                Console.WriteLine("|||            |||                                          |||");
                Console.SetCursorPosition(18, 18);
                Console.WriteLine("|||            |||                                          |||");
                Console.SetCursorPosition(18, 19);
                Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            } // End of task 4

            if (task == "Task5" || task == "task5" || task == "5")
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.Title = "Task 5";
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(61, 10);
                Console.WriteLine("A");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(57, 12);
                Console.WriteLine("B       C");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.SetCursorPosition(55, 14);
                Console.WriteLine("D     E     F");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.SetCursorPosition(53, 16);
                Console.WriteLine("G    H    I    J");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.SetCursorPosition(51, 18);
                Console.WriteLine("K    L    M    N   O");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(53, 20);
                Console.WriteLine("P    Q    R    S");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(55, 22);
                Console.WriteLine("T     U     V");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.SetCursorPosition(57, 24);
                Console.WriteLine("X       Y");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.SetCursorPosition(61, 26);
                Console.WriteLine("Z");
               } /// End of Task 5
                 
            if (task == "Task6" || task == "task6" || task == "6")
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.Title = " Task 6";
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(50, 2);
                Console.WriteLine("Muhammad Waseem");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(10, 4);
                Console.WriteLine("Career Objective                                                                               ");
                Console.SetCursorPosition(10, 6);
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("To use my intellectual abilities Computer System Engineering knowledge, leadership abilities, \n \t  Communication & interpersonal skills in prestigious organizatio.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(10, 9);
                Console.WriteLine("Education                                                                                      ");
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(10, 11);
                Console.WriteLine("M.E: \n \t * \t Computer Applied Technology from South East University Nanjing China");
                Console.SetCursorPosition(10, 13);
                Console.WriteLine("Graduation: \n \t * \t BSIT from Sindh Agriculture University Tando Jam");
                Console.SetCursorPosition(10, 15);
                Console.WriteLine("Intermediate: \n \t * \t Noor Shah Bukhari Collage Tando Jam");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(10, 18);
                Console.WriteLine("Personal Information                                                                           ");
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(10, 20);
                Console.WriteLine("Father's Name : \t Muhammad Shareef Khan");
                Console.SetCursorPosition(10, 21);
                Console.WriteLine("Date of birth : \t 15-12-1990");
                Console.SetCursorPosition(10, 22);
                Console.WriteLine("Nationality   : \t Pakistani");
                Console.SetCursorPosition(10, 23);
                Console.WriteLine("Languages     : \t Urdu, Sindhi, English, Chinese");
                Console.SetCursorPosition(10, 24);
                Console.WriteLine("Religion      : \t Islam");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(10, 26);
                Console.WriteLine("Extera Curicular Activities                                                                    ");
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(10, 27);
                Console.WriteLine("*  Reading Books");
                Console.SetCursorPosition(10, 28);
                Console.WriteLine("*  Listening Music");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(10, 30);
                Console.WriteLine("Additional Skills                                                                              ");
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(10, 31);
                Console.WriteLine("*  Ability to work in a Team");
                Console.SetCursorPosition(10, 32);
                Console.WriteLine("*  Ability to accept challenges");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(10, 34);
                Console.WriteLine("References                                                                                     ");
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(10, 35);
                Console.WriteLine("Available on request");
                
             }
            Console.ReadLine();
        }
    }
}
