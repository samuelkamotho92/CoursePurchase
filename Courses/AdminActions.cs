using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Courses
{
    public class AdminActions
    {

        public string choice;
        public int input; 
        public void chooseCategory()
        {
            Console.WriteLine("Choose options");
            Console.WriteLine("1: Add Course");
            Console.WriteLine("2: View Courses");
            Console.WriteLine("3: Delete Course");
            Console.WriteLine("4: Update Course");
            Console.WriteLine("5: View Analytics");
            choice = Console.ReadLine();
            input = Convert.ToInt16(choice);
            switch (input) {
                case 1:
                    Addcourse();
                    break;
                case 2:
                    viewCourses();
                    break;
                case 3:
                    deleteCourse();
                    break;
                case 4:
                    deleteCourse();
                    break;
                case 5:
                    updateCourse();
                    break;
                case 6:
                    deleteCourse();
                    break;
            }


        }



        public void Addcourse()
        {
            Console.WriteLine("Add Course enter the following details");
            Console.WriteLine("Enter Name");
            int courseId = 1;
            string coursename = Console.ReadLine();
            Console.WriteLine("Enter Plan ");
            string plan = Console.ReadLine();
            Console.WriteLine("Enter Plan ");
            string price = Console.ReadLine();
            //get options from 


        }

        public void viewCourses()
        {

        }

        public void deleteCourse()
        {

        }

        public void updateCourse()
        {

        }

        public void analytics()
        {

        }


    }
}
