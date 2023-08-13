using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usermodel;
using System.IO;
using Authentication.Courses;

namespace Authentication.UserAuth
{
    public class RegisterUser
    {
        public string status;
        public void checkOption()
        {
            Console.WriteLine("Enter Options");
            Console.WriteLine((int)Auth.register + " . " + Auth.register);
            Console.WriteLine((int)Auth.login + " . " + Auth.login);
        var optionSelected = Console.ReadLine();
         var selectedCatInput = validateInput(optionSelected);
            if(selectedCatInput != 0)
            {
                Console.WriteLine(selectedCatInput);
               if(selectedCatInput == 1)
                {

                }
            }
            else
            {
                Console.WriteLine("invalid inputs");
                checkOption();
            }
            if (selectedCatInput == 1) 
            {
                registerUser();
            }
            else
            {
                LoginUser();
            }
        }
        public int validateInput(string category)
        {
            if (string.IsNullOrWhiteSpace(category))
            {
                Console.WriteLine("Invalid choice pick a plan");
                checkOption();
            }
            else
            {
                bool canConverted = int.TryParse(category, out int converted);
                if (canConverted && converted > 0 && converted < 3)
                {
                    return converted;
                }
                else
                {
                    checkOption();
                }
                return 0;
            }
            checkOption();
            return 0;

        }
        public void registerUser()
        {
            Console.WriteLine("Register user details");
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter password");
            string password = Console.ReadLine();
            string outfile = @"C:\Users\Twinnie Tech\source\repos\Authentication\Data\outfile.txt";
            List<userDTO> People = new List<userDTO>();
            userDTO userone = new userDTO(2,name,email,password,role:"user");
            People.Add(userone);
            List<string> outContent = new List<string>();
            foreach (userDTO person in People)
            {
                outContent.Add(person.ToString());
                Console.WriteLine(person);
            }
            File.AppendAllLines(outfile, outContent);
            Console.WriteLine("user registered Successfully");
        }
        public void LoginUser()
        {
            //read user
            Console.WriteLine("Login details");
            Console.WriteLine("Enter email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter password");
            string password = Console.ReadLine();
            string file = @"C:\Users\Twinnie Tech\source\repos\Authentication\Data\outfile.txt";
            List<string> lines = new List<string>();
            List<userDTO> People = new List<userDTO>();
            lines = File.ReadAllLines(file).ToList();
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                string[] emailval = parts[2].Split(':');
                string[] passval = parts[3].Split(':');

                if (email == emailval[1] && password == passval[1])
                {
                     Console.WriteLine("Logged In Successfuly");
                    Dashboard();
                }
                
            }
            //if (status=="loggedIn")
            //{
            
            //    //redirect to Dashboard
            //}
            //else
            //{
            //    Console.WriteLine("User Does not exist,try again");
            //    LoginUser();
            //}

        }

        public void Dashboard()
        {
            Console.WriteLine("Check courses");
            DisplayCourses showCourses = new DisplayCourses();
            showCourses.showPlanCategory();
        }
    }
}
