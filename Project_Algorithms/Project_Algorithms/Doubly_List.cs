using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project_Algorithms
{
    public class Doubly_List
    {
        Node Head;

        // اضافة عقدة ببداية اللائحة 
        public void Add_First(int iD, string fullName, string country, double test_one, double test_two)
        {
            Student student = new Student(iD, fullName, country, test_one, test_two);

            Node newNode = new Node(student);

            if (Head == null)
            {
                Head = newNode;
                return;
            }
            newNode.Next = Head;
            Head.Previous = newNode;
            Head = newNode;
        }
        // اضافة عقدة بنهاية اللائحة 
        public void Add_Last(int iD, string fullName, string country, double test_one, double test_two)
        {
            Student student = new Student(iD, fullName, country, test_one, test_two);
            Node newNode = new Node(student);
            // اول عقدة 
            if (Head == null)
            {
                Head = newNode;
                return;
            }
            // العقدة الحالية 
            Node Current = Head;

            while (Current.Next != null)
            {
                Current = Current.Next;
            }
            Current.Next = newNode;
            newNode.Previous = Current;
        }
        // دالة الطباعة 
        public void Print()
        {
            Node Current = Head;
            while (Current != null) 
            {
                Console.WriteLine($"ID : {Current.Data.ID} \n"+$"Name : {Current.Data.FullName} \n"+ $"Country : {Current.Data.Country} \n" +$"Test_1 : {Current.Data.Test_one} \n"+$"Test_2 : {Current.Data.Test_two} \n"+$"Average : {Current.Data.Average} \n"+$"Grade : {Current.Data.Grade} \n");
                Current=Current.Next;
            }
        }
        // الفرز حسب الاسم بترتيب تصاعدي 
        public void Sort_StudentByname()
        {
            if (Head == null && Head.Next==null)
                return;
            bool swap;
            do
            {
                swap = false;
                Node current = Head;
                while (current.Next != null)
                {
                    // مقارنة الاسمين حرف بحرف 
                    if (String.Compare(current.Data.FullName, current.Next.Data.FullName) > 0)
                    {
                        // تبديل بيانات كل عقدة 
                        Student temp = current.Data;
                        current.Data = current.Next.Data;
                        current.Next.Data = temp;


                        // تم التبديل 
                        swap = true;
                    }
                    // الانتقال الى العقدة التالية
                    current = current.Next;
                }
            } while (swap);

        }
        // الفرز حسب المحصلة تصاعدياً
        public void Sort_StudentByAverage()
        {
            if (Head == null && Head.Next==null)
                return;

            bool swap;
            do
            {
                swap = false;

                Node current = Head;
                while (current.Next != null)
                {
                    // مقارنة المحصلة 
                    if (current.Data.Average > current.Next.Data.Average)
                    {
                        // تبديل بيانات كل عقدة 
                        Student temp = current.Data;
                        current.Data = current.Next.Data;
                        current.Next.Data = temp;

                        // تم التبديل 
                        swap = true;
                    }
                    // الانتقال الى التالية
                    current = current.Next;
                }
            }while (swap);   
        }
        // دالة البحث 
        public void  SearchByAverage(double Avg)
        {
            SearchByAverage(Avg,Head);
        }
        private void SearchByAverage(double Avg,Node X)
        {
            // اول عقدة 
            
             Node current = X;

            // البداية 
            if (current == null)
            {
                return;
            }
            // اذا وجد تطابق  اطبع بيانات هذا الطالب 
            if (current.Data.Average == Avg)
            {
                Console.WriteLine($"ID : {current.Data.ID} \n" + $"Name : {current.Data.FullName} \n" 
                    + $"Country : {current.Data.Country} \n" + $"Test_1 : {current.Data.Test_one} \n" 
                    + $"Test_2 : {current.Data.Test_two} \n" + $"Average : {current.Data.Average} \n" 
                    + $"Grade : {current.Data.Grade} \n");
            }
            // الاستدعاء العودي 
                SearchByAverage(Avg,current.Next);
        }
    }

}
