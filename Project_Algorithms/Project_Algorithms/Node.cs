using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Algorithms
{
    public class Node
    {
        
        public Student Data {  get; set; }
        public Node Next { get; set;}
        public Node Previous {  get; set;}
        public Node(Student data) 
        {
            this.Data = data;
            this.Next = null;
            this.Previous = null;
        }
    }
}
