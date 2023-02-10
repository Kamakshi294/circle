using CircleApplication;
using System;

namespace CircleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Get Circle Details!");
            CircleDetails circleDetails = new CircleDetails();
            int select;
            do
            {
                Console.WriteLine("1. Get Circle Radius");
                Console.WriteLine("2. Change Circle Radius");
                Console.WriteLine("3. Get Circle Circumference");
                Console.WriteLine("4. Get Circle Area");
                Console.WriteLine("5. Exit");
                Console.WriteLine();
                Console.Write("Select an Option: ");

                if (int.TryParse(Console.ReadLine(), out select))
                {
                    Console.WriteLine();
                    switch (select)
                    {
                        case 1:
                            Console.WriteLine("Radius of the circle is:: " + circleDetails.GetRadius());
                            break;

                        case 2:
                            Console.Write("Please enter the radius: ");
                            if (int.TryParse(Console.ReadLine(), out int newRadius))
                            {
                                circleDetails.SetRadius(newRadius);
                                Console.WriteLine("Radius of the circle is:: " + circleDetails.GetRadius());
                            }
                            else
                            {
                                Console.WriteLine("Invalid Entry!!!");
                            }
                            break;


                        case 3:
                            Console.WriteLine("Circumference of the circle is: " + circleDetails.GetCircumference());
                            break;

                        case 4:
                            Console.WriteLine("Area of the circle is: " + circleDetails.GetArea());
                            break;

                        case 5:
                            Console.WriteLine("Exit !!");
                            break;

                        default:
                            Console.WriteLine("Invalid Entry!! Please enter a valid number");
                            break;
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            } while (select != 5);
        }
    }
}
