using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usermodel;

namespace Authentication.Courses
{
    public class PurchaseCourse
    {
        public int Cash = 0;
        List<CourseDTO>coursePlans = new List<CourseDTO>();
        DisplayCourses courses = new DisplayCourses();
        //List<CourseDTO> dataPlans = new List<DataplanDTO>();
        //DisplayPlans validation = new DisplayPlans();

        //constructor
        public PurchaseCourse()
        {
            //get a list of DTOS
            coursePlans = new CourseService().GetCourses();
        }
        public void Purchase(int selectedId)
        {
            var selectedPlan = coursePlans.Find(x => x.Id == selectedId);
            Console.WriteLine($"purchasing Course {selectedPlan.Name} at {selectedPlan.Price}");
            Console.WriteLine("Confirm purchase");
            Console.WriteLine("1 Yes");
            Console.WriteLine("2 No");
            //check input value
            var answ = Console.ReadLine();
            //validate
            var answInput = courses.validateInput(answ, 3);
            if (answInput != 0 && answInput < 2)
            {
                Console.WriteLine($"Enter Amount : {selectedPlan.Price}");
                checkAirtime(selectedPlan.Id);
            }
            else
            {
                Console.WriteLine("Back to Home Page");
                courses.showPlanCategory();
            }
        }

          public void checkAirtime(int id)
        {
             var selectedPlan = coursePlans.Find(x => x.Id == id);
            if(selectedPlan.Price < Cash)
            {
                Console.WriteLine("Purchased successfully");
            }
            else
            {
                Console.WriteLine($"amount is low kindly ,remaining {Cash-selectedPlan.Price} to get the course");
                topUpAirTime(id);
            }
        }

        public void topUpAirTime(int id)
        {
            var selectedPlan = coursePlans.Find(x => x.Id == id);
            Console.WriteLine("Add Amount");
            var amount = Console.ReadLine();
            Console.WriteLine(amount);
            //enter amount
            var outputVal = courses.validateInput(amount, 100000);
            Console.WriteLine($"The value is {outputVal}");
            if (outputVal != 0)
            {
                Cash += outputVal;
                Console.WriteLine($"Current Amount {Cash} ,Course amount is {selectedPlan.Price}");
                continuePucharse(id);
            }

        }

        public void continuePucharse(int id)
        {

            var options = coursePlans.Find(x => x.Id == id);
            if (options.Price > Cash)
            {
                Console.WriteLine("Insufficient top up");
                topUpAirTime(id);

            }
            else
            {
                BuyPlan(id);
            }
        }
        public void BuyPlan(int id)
        {
            var option = coursePlans.Find(x => x.Id == id);
            Cash -= option.Price;
            Console.WriteLine($"You Have Successfully purchased {option.Name} at {option.Price}!!");
            return;
        }
    }
}
