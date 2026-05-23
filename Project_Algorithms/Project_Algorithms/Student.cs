using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Algorithms
{
    public class Student
    {
        public int ID {  get; set; }
        public string FullName {  get; set; }
        public string Country {  get; set; }
        public double Test_one { get; set;}
        public double Test_two { get; set;}
        public double Average {  get;private set;}
        public string  Grade { get; set; }
        
        

        public Student(int iD, string fullName, string country, double test_one, double test_two)
        {
            ID = iD;
            FullName = fullName;
            Country = country;
            Test_one = test_one; 
            Test_two = test_two;
            Average = (test_one + test_two) / 2;
            Get_GradeAverage();

        }
        public void Get_GradeAverage()
        {
            
                if(Average < 50)
                {
                  Grade = "Failed";
                }
                else if(Average <= 65)
                {
                   Grade = "Good";
                }
                else if (Average <= 85)
                {
                  Grade = "Very Good";
                }
                else
                {
                    Grade = "Excellent";
                }
        }
       

    }
    
    
}
