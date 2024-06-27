// See https://aka.ms/new-console-template for more information


using AreaCalculate;

Console.WriteLine("Welcome to the Geometric Shape Calculation Program!");

List<BaseShape> shapeList = new List<BaseShape>();


while (true)
{
     Console.WriteLine("\nPlease select the shape you want to add to list:");
     Console.WriteLine("1.Square");
     Console.WriteLine("2.Triangle");
     Console.WriteLine("3.Rectangle");
     Console.WriteLine("4.Pentagon");
     Console.WriteLine("5.Circle");
     Console.WriteLine("6.Exit");
     Console.WriteLine("7.Display Shape List");
     string Choice = Console.ReadLine();


     switch (Choice)
     {
          case "1":
               Console.WriteLine("Your Choice: Square");
               Console.Write("Enter the edge of the square :");
               double Edge = Convert.ToDouble(Console.ReadLine());
               Square square = new Square(Edge, ColorType.Green);
               shapeList.Add(square);
               System.Console.WriteLine("");
               break;
          case "2":
               Console.WriteLine("Your Choice: Triangle");
               Console.Write("Enter the base length of the triangle: ");
               double Baselength = Convert.ToDouble(Console.ReadLine());
               Console.Write("enter the height of the triangle: ");
               double Height = Convert.ToDouble(Console.ReadLine());
               Triangle triangle = new Triangle(Baselength, Height, ColorType.Red);
               shapeList.Add(triangle);
               break;
          case "3":
               Console.WriteLine("Your Choice: Rectangle");
               Console.Write("Enter the longedge of the rectangle: ");
               double Longedge = Convert.ToDouble(Console.ReadLine());
               Console.Write("Enter the shortedge of the rectangle: ");
               double Shortedge = Convert.ToDouble(Console.ReadLine());
               Rectangle regtangle = new Rectangle(Shortedge, Longedge, ColorType.Blue);
               shapeList.Add(regtangle);
               break;
          case "4":
               Console.WriteLine("Your Choice: Pentagon");
               Console.Write("Enter the edge of the pentagon: ");
               double edge = Convert.ToDouble(Console.ReadLine());
               Pentagon pentagon = new Pentagon(edge, ColorType.Yellow);
               shapeList.Add(pentagon);
               break;
          case "5":
               Console.WriteLine("Your Choice: Circle");
               Console.Write("Enter the radius of the circle: ");
               double Radius = Convert.ToDouble(Console.ReadLine());
               Circle circle = new Circle(Radius, ColorType.Red);
               shapeList.Add(circle);
               break;
          case "6":
               Console.WriteLine("Exiting the program...");
               return;
          case "7":
               System.Console.WriteLine("Total number of shapes: " + shapeList.Count);
               foreach (BaseShape shape in shapeList)
               {
                    Console.WriteLine(shape.ToString());
               }
               return;
          default:
               Console.WriteLine("Invalid choice! Please try again.");
               break;

     }



}



