using BasicProject.Model;
using BasicProject.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProject.Controller
{
    internal class Controller1
    {

        public Object Run() 
        {
            

            Console.WriteLine("Nhap du lieu cho hinh tron: ");
            Console.Write("Nhap toa do x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhap toa do y: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Nhap ban kinh: ");
            double R = double.Parse(Console.ReadLine());

            Point2D point = new Point2D(x, y);

            Circle circle = new Circle(R, point);

            ShapeView view = new ShapeView(circle);
            return view;
        }

        
    }
}
