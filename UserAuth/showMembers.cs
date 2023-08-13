using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usermodel;
using System.IO;
using System.Xml.Linq;

namespace Authentication.UserAuth
{
    public class showMembers
    {
        public string id;
        List<userDTO> Users = new List<userDTO>();
        public void  getMembers()
        {
            //string file = @"C:\Users\Twinnie Tech\source\repos\Authentication\Data\users.txt";
            //List<string> lines = new List<string>();
            List<userDTO> People = new List<userDTO>();
            //lines = File.ReadAllLines(file).ToList();
            //foreach (string line in lines)
            //{
            //    string[] parts = line.Split(' ');
            //userDTO p = new userDTO(Convert.ToInt32(parts[0]),parts[1],parts[2],parts[3],parts[4]);
            //    People.Add(p);
            // }
            //List<string> outContent = new List<string>();
            //foreach (userDTO person in People)
            //{
            //    outContent.Add(person.ToString());
            //    Console.WriteLine(person);
            //}

            //string outfile = @"C:\Users\Twinnie Tech\source\repos\Authentication\Data\outfile.txt";
            //File.WriteAllLines(outfile, outContent);
            Console.WriteLine("users");
        }     
        }

    }

