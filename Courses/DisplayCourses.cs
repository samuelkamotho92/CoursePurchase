using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Usermodel;
namespace Authentication.Courses
{
    public class DisplayCourses
    {
      List<CourseDTO> CourseDeals = new List<CourseDTO>();

        public DisplayCourses()
        {
            CourseDeals = new CourseService().GetCourses();
        }
        //display category
        public void showPlanCategory()
        {
            Console.WriteLine((int)Plans.Csharp + "  " + Plans.Csharp);
            Console.WriteLine((int)Plans.Javascript + "  " + Plans.Javascript);
            Console.WriteLine((int)Plans.QAQE + "  " + Plans.QAQE);
            Console.WriteLine((int)Plans.Wordpress + "  " + Plans.Wordpress);
            Console.WriteLine("Select Category");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            var optionSelected = Console.ReadLine();
            var selectedCatInput = validateInput(optionSelected, 4);
            if (selectedCatInput != 0)
            {
                //filter based on value input
                filterBasedCategory(selectedCatInput);
            }
            else
            {
                Console.WriteLine("invalid inputs");
                showPlanCategory();
            }
        }
        public void filterBasedCategory(int category)
        {
            var filtered = CourseDeals.FindAll(x => (int)x.Plans == category);

            foreach (var item in filtered)
            {
                Console.WriteLine($"{item} value");
                Console.WriteLine($"{item.Id} : {item.Name} at {item.Price}");

            }
            Console.WriteLine("select option to buy");
            var optionSelectd = Console.ReadLine();
            var selectedInput = validateInput(optionSelectd, CourseDeals.Count + 1);
            Console.WriteLine(selectedInput);
            PurchaseCourse purchase = new PurchaseCourse();
            purchase.Purchase(selectedInput);
        }


           public int validateInput(string category, int limit)
           {
            if (string.IsNullOrWhiteSpace(category))
            {
                Console.WriteLine("Invalid choice pick a plan");
                showPlanCategory();
            }
            else
            {
                bool canConverted = int.TryParse(category, out int converted);
                if (canConverted && converted > 0 && converted < limit)
                {
                    return converted;
                }

                return 0;
            }
            showPlanCategory();
            return 0;

        }
    }
}
