using System;
using static System.Console;

/*Name: Blare Robinson
Date: 10/13/2022
Description: MoreInfo
Resources: N/A
*/

namespace MidtermProjectber
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string firstName1, firstName2, lastName1, lastName2, String_BirthDate; 
            DateTime birthDay1, birthDay2;
            int studentId1, studentId2, classCount1, classCount2, graduateYear1, graduateYear2;

            WriteLine("What is student 1's First name?");
            firstName1 = Console.ReadLine();

            WriteLine("What is student 2's First name?");
            firstName2 = Console.ReadLine();

            WriteLine("What is student 1's Last name?");
            lastName1 = Console.ReadLine();

            WriteLine("What is student 2's Last name?");
            lastName2 = Console.ReadLine();

            WriteLine("What is student 1's Birthday (YYYY/MM/DD)?");
            String_BirthDate = Console.ReadLine();
            birthDay1 = Convert.ToDateTime(String_BirthDate);

            WriteLine("What is student 2's Birthday (YYYY/MM/DD)?");
            birthDay2 = Convert.ToDateTime(ReadLine());

            WriteLine("What is student 1's student ID?");
            studentId1 = Convert.ToInt32(ReadLine());

            WriteLine("What is student 2's Student ID?");
            studentId2 = Convert.ToInt32(ReadLine());

            WriteLine("What is student 1's Class Count?");
            classCount1 = Convert.ToInt32(ReadLine());

            WriteLine("What is student 2's Class Count?");
            classCount2 = Convert.ToInt32(ReadLine());

            WriteLine("What is student 1's Graduation Yr?");
            graduateYear1 = Convert.ToInt32(ReadLine());

            WriteLine("What is student 2's Graduation Yr?");
            graduateYear2 = Convert.ToInt32(ReadLine());

            WriteLine("{0,-15} {1,-15} {2,-15} {3,-15} {4,-15} {5,-15}", "FirstName", "LastName", "DOB", "StudentID", "ClassCount", "Year");
            WriteLine("------------------------------------------------------------------------------------");
            WriteLine("{0,-15} {1,-15} {2,-15} {3,-15} {4,-15} {5,-15}", firstName1, lastName1, birthDay1.ToString("MM/dd/yyyy"), studentId1, classCount1, graduateYear1);
            WriteLine("{0,-15} {1,-15} {2,-15} {3,-15} {4,-15} {5,-15}", firstName2, lastName2, birthDay2.ToString("MM/dd/yyyy"), studentId2, classCount2, graduateYear2);




        }
    }
}
