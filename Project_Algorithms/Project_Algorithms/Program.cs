using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Project_Algorithms
{
    internal class Program
    {
        
        static void Main(string[] args)
        
         {
            // انشاء لائحة خطية مزدوجة 
            Doubly_List list = new Doubly_List();
            for (int i = 1; i <= 5; i++)
            {
               
                // ادخال البيانات 
                Console.WriteLine("please enter student data");
                Console.WriteLine("");

                // ادخال رقم الطالب 
                int id;
                while(true)
                {
                    Console.WriteLine("enter student ID ");
                    id =Convert.ToInt32(Console.ReadLine());
                    
                     if(id>0)
                    {
                        break;
                    }
                    else if(id <= 0) { Console.WriteLine("enter correct number "); }

                } 
                
                
                // ادخال اسم الطالب 
                Console.WriteLine("enter full name ");
                string full_name = Console.ReadLine();

                // ادخال مكان سكن الطالب 
                Console.WriteLine("enter the student country");
                string country = Console.ReadLine();

                // ادخال العلامة الاولى 
                double test_one ;
                while (true)
                {

                    Console.WriteLine("enter mark test one");
                    test_one = Convert.ToDouble(Console.ReadLine());
                    if (test_one <= 0)
                    {
                        Console.WriteLine(" Mark must be greater than zero");
                    }
                    if(test_one > 100)
                    {
                        Console.WriteLine("Mark must be less than 100");

                    }
                    else
                    {
                        break;
                    }
                } 
                
                
                    
                 
                // ادخال العلامة الثانية 
                
                double test_two ;
                while (true)
                {
                    Console.WriteLine("enter mark test two");
                    test_two = Convert.ToDouble(Console.ReadLine());
                    if (test_two <= 0)
                    {
                        Console.WriteLine(" Mark must be greater than zero");
                    }
                    if(test_two > 100)
                    {
                        Console.WriteLine("Mark must be less than 100");
                    }
                    else { break; }
                } 


                // اختيار مكان الاضافة
                int location;
                while (true) 
                {
                    Console.WriteLine("choose the location to add \n 1:Start \n 2:End ");
                    location = int.Parse(Console.ReadLine());
                    // الاضافة بالبداية 
                    if (location == 1)
                    {
                        list.Add_First(id, full_name, country, test_one, test_two);
                        break;
                    }
                    // الاضافة في النهاية 
                    else if (location == 2)
                    {
                        list.Add_Last(id, full_name, country, test_one, test_two);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Entry");
                    }
                } 
                
            }
            
            Console.WriteLine("Student Data \n");

            // طباعة بيانات جميع الطلاب 
            list.Print();
            

            // (اختيار طريقة فرز الطلاب (فرز حسب الاسم او فرز حسب المحصلة  
            int choice;
            while (true) 
            {
                Console.WriteLine("choose a sorting way \n 1:ByName \n 2:ByAverage ");

                choice =int.Parse(Console.ReadLine());
                
                // فرز حسب الاسم
                if (choice == 1)
                {
                    list.Sort_StudentByname();
                    break;
                }
                // فرز حسب المحصلة
                else if (choice == 2)
                {
                    list.Sort_StudentByAverage();
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect Entry");
                }

            }
            // طباعة بيانات الطلاب بعد الفرز 
            list.Print();
            Console.WriteLine("Enter Mark to search for");

            // ادخال معدل للبحث عنه 
            double Mark=double.Parse(Console.ReadLine());

            list.SearchByAverage( Mark);

            
            Console.ReadLine();

            
        }
    }
   
}
