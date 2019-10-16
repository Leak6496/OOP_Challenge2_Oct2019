using Shapes;
using ShapesException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleProgShapes
{
    class Program
    {
        static void Main(string[] args)
        {

              string choice;

              double side,side1, side2, rad;

               bool req = true;

               while (req)

               {
                try

                {

                    Console.WriteLine("Please Select number from the menu driven:");

                       Console.WriteLine("1.Create Square");
                       Console.WriteLine("2.Create Rectangle");
                       Console.WriteLine("3.Create Equilateral");
                       Console.WriteLine("4.Create RightAngle");
                       Console.WriteLine("5.Create Circle");
                       Console.WriteLine("6.Quit");



                       choice = Console.ReadLine();
              

                    if (choice == "1")

                    {
                       // decimal num = default(decimal);
                        Console.WriteLine("Please input side Lenght for square: ");
                        side = double.Parse(Console.ReadLine());
                        if (side %1!=0)
                        {
                            throw new InvalidDecimalInput("Invalid Decimal Input");
                        }
                        
                        
                        Square sq = new Square("red", side);
                        Console.WriteLine("Square has been created with color {0}, side lenght {1}, Area {2}, Perimeter {3}",
                            sq.Colour, sq.Side1, sq.GetArea(), sq.GetPerimeter());

                                              
                    }

                    if (choice == "2")

                    {

                        Console.WriteLine("Please input the side1 lenght for rectangle: ");

                        side1 = double.Parse(Console.ReadLine());
                        if (side1 % 1 != 0)
                        {
                            throw new InvalidDecimalInput("Invalid Decimal Input");
                           
                        }
                      

                        Console.WriteLine("Please input the side2 Lenght for rectangle: ");
                        side2 = double.Parse(Console.ReadLine());
                        if (side2 % 1 != 0)
                        {
                            throw new InvalidDecimalInput("Invalid Decimal Input");

                        }

                        Rectangle Recg = new Rectangle("blue", side1, side2);
                        Console.WriteLine("Square has been created with color {0}, side1 lenght {1},side2 Lenght {2}, Area {3}, Perimeter {4}",
                                  Recg.Colour, Recg.Side1, Recg.Side2, Recg.GetArea(), Recg.GetPerimeter());

                      

                    }
                    if (choice == "3")

                    {

                        Console.WriteLine("Please input the side lenght for Equilateral Triangle: ");
                        side = double.Parse(Console.ReadLine());
                        if (side % 1 != 0)
                        {
                            throw new InvalidDecimalInput("Invalid Decimal Input");

                        }
                       

                        Equilateral equi = new Equilateral("green", side);
                        Console.WriteLine("Equilateral Triangle has been created with color {0}, side lenght {1}, Area {2}, Perimeter {3}",
                                    equi.Colour, equi.Side1, equi.Side2, equi.GetArea(), equi.GetPerimeter());
                      

                    }
                    if (choice == "4")

                    {

                        Console.WriteLine("Please input the side1 lenght for RightAngle Triangle: ");
                        side1 = double.Parse(Console.ReadLine());
                        if (side1 % 1 != 0)
                        {
                            throw new InvalidDecimalInput("Invalid Decimal Input");

                        }
                        Console.WriteLine("Please input the side2 lenght for RightAngle Triangle: ");
                        side2 = double.Parse(Console.ReadLine());
                        if (side1 % 1 != 0)
                        {
                            throw new InvalidDecimalInput("Invalid Decimal Input");

                        }

                        RightAngle riAg = new RightAngle("purple", side1, side2);
                        Console.WriteLine("RightAngle Triangle has been created with color {0}, side1 lenght {1},side2 Lenght {2}, Area {3}, Perimeter {4}",
                                      riAg.Colour, riAg.Side1, riAg.Side2, riAg.GetArea(), riAg.GetPerimeter());
                    

                    }
                    if (choice == "5")

                    {

                        Console.WriteLine("Please input the radius for circle: ");

                        rad = double.Parse(Console.ReadLine());
                        if (rad % 1 != 0)
                        {
                            throw new InvalidDecimalInput("Invalid Decimal Input");

                        }

                       Circle circ = new Circle("yellow", rad);
                        Console.WriteLine("Circle has been created with color {0}, radius {1} , Area {2}, Perimeter {3}",
                                 circ.Colour, circ.Radius, circ.GetArea(), circ.GetPerimeter());
                   
                    }
                    if (choice == "6")

                    {

                        System.Environment.Exit(0);

                    }

                }//try 
                catch (InvalidDecimalInput)
                {
                    
                    Console.WriteLine("Invalid Decimal Input");
                    req = true;

                }

                catch (FormatException )
                {
                    Console.WriteLine("Invalid Input. Please try again with the valid number!");
                    req = true;
                }

                catch (Exception e)

                {

                    Console.WriteLine(e.Message);
                    req = true;

                }

                   //Console.Clear(); */

               }//while true 
            Console.ReadLine();
        }
    }
}
