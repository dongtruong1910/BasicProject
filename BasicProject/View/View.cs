using BasicProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProject.View
{
    internal class ShapeView { 
        public ShapeView(Circle circle) {
            
            Console.WriteLine("Chu vi: " + circle.Perimeter());
            Console.WriteLine("Dien tich: " + circle.Area());
            Console.ReadLine();
            
        }
    }
}
