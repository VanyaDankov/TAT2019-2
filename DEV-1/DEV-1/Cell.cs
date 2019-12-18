using System;
using System.Collections.Generic;
using System.Text;

namespace DEV_1
{
    class Cell
        {
            private int x = 0, y = 0;
            public Cell(int X, int Y)
            {
                x = X;
                y = Y;
                while (CheckCoordinate() == false)
                {
                    Console.WriteLine("enter coordinate");
                    x = Convert.ToInt32(Console.ReadLine());
                    y = Convert.ToInt32(Console.ReadLine());
                }
            }
            public void Move(int X, int Y)
            {
                x += X;
                y += Y;

            }
            public string Color()
            {
            return (x + y) % 2 == 0 ? "black" : "White";
            }
            public bool CheckCoordinate()
            {
                return (x <= 8 && y <= 8 && x > 0 && y > 0);                
            }
            public bool CheckDiaganale(Cell abc)
            {
                return (abc.x - x == abc.y - y || abc.x - x == y - abc.y);               
            }
            public bool CheckVertical(Cell abc)
            {
                return (abc.x == x);               
            }
            public bool CheckHorizontal(Cell abc)
            {
                return (abc.y == y);               
            }
        }
    
}
