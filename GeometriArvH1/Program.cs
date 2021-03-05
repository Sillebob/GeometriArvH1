using System;
using System.Collections.Generic;

namespace GeometriArvH1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintChangeColour("Assignment a) number 1-7");
            #region Perimeter new objects and testing calculating method.
            // Perimeter.
            // Instansiating a new object of the class Square.
            Square square1 = new Square(2.54, 2.54);
            // Prints the result by calling the method from the logiclayer , which calls the datalayer.
            // Calling the Method to calculate the perimeter, rounding up to two decimals and prints the result.
            Console.WriteLine($"\nThe perimeter of square one is: {Math.Round(LogicLayer.GetPerimeter(square1), 2)}");

            // Instansiating another new object of the class Square with a different value of the length of the side.
            Square square2 = new Square(5.25, 5.25);
            Console.WriteLine($"The perimeter of square two is: {Math.Round(LogicLayer.GetPerimeter(square2), 2)}");

            // Instansiating another new object of the class Square with a different value of the length of the side.
            Square square3 = new Square(15.00, 15.00);
            Console.WriteLine($"The perimeter of square three is: {Math.Round(LogicLayer.GetPerimeter(square3), 2)}");
            #endregion Perimeter new objects and testing calculating methods.

            PrintChangeColour("\nAssignment a) number 8+9");
            #region Area testing calculating method.
            // Area
            // Prints and calls the method to calculate the area of the objects.
            Console.WriteLine($"The area of square one is: {Math.Round(LogicLayer.GetArea(square1), 2)}");
            Console.WriteLine($"The area of square two is: {Math.Round(LogicLayer.GetArea(square2), 2)}");
            Console.WriteLine($"The area of square three is: {Math.Round(LogicLayer.GetArea(square3), 2)}");
            #endregion Area testing calculating method.

            PrintChangeColour("\nAssignment b) to f)");

            #region Rectangel new object of subclass  testing calculating methods.
            // Instansiating a new object of the subclass Rectangle. 
            Square rectangle1 = new Rectangle(10, 5);
            // Calling the methods to calculate perimeter and area.
            Console.WriteLine($"\nThe perimeter of the rectangle is: {Math.Round(LogicLayer.GetPerimeter(rectangle1))}");
            Console.WriteLine($"The area of the rectangle is: {Math.Round(LogicLayer.GetArea(rectangle1), 2)}");
            #endregion Rectangel new object of subclass  testing calculating methods.

            #region Parallelogram new object of subclass  testing calculating methods.
            Square parallelogram1 = new Parallelogram(3, 5, 20);
            Console.WriteLine($"\nThe perimeter of the parallelogram is: {Math.Round(LogicLayer.GetPerimeter(parallelogram1))}");
            Console.WriteLine($"The area of the parallelogram is: {Math.Round(LogicLayer.GetArea(parallelogram1), 2)}");
            #endregion Parallelogram new object of subclass  testing calculating methods.

            #region Trapeze new object of subclass  testing calculating methods.
            Square trapeze1 = new Trapeze(10, 9, 8, 9);
            // The calculation of the perimeter for the trapeze is not correct therefor it is not printed.
            Console.WriteLine($"\nThe area of the trapeze is: {Math.Round(LogicLayer.GetArea(trapeze1), 2)}");
            #endregion Trapeze new object of subclass  testing calculating methods.

            #region Triangle new object of subclass  testing calculating methods.
            Square triangle1 = new Triangle(4, 3);
            Console.WriteLine($"\nThe perimeter of the triangle is: {Math.Round(LogicLayer.GetPerimeter(triangle1))}");
            Console.WriteLine($"The area of the triangle is: {Math.Round(LogicLayer.GetArea(triangle1), 2)}");
            #endregion Triangle new object of subclass  testing calculating methods.

            PrintChangeColour("\nAssignment g)");
            #region List of all objects from class and subclasses and printing.
            // Making a list of squares an adding one of each sunclass.
            List<Square> squares = new List<Square>();
            squares.Add(new Square(5,5));
            squares.Add(new Rectangle(5, 3));
            squares.Add(new Parallelogram(3, 5, 20));
            squares.Add(new Trapeze(10, 9, 8, 9));
            squares.Add(new Triangle(4, 3));

            // Printing the perimeter and area of each subclass
            foreach (Square square in squares)
            {
                // Prints the result by calling the method from the logiclayer , which calls the datalayer.
                Console.WriteLine($"The perimeter is: {LogicLayer.GetPerimeter(square)}");
                Console.WriteLine($"The area is: {LogicLayer.GetArea(square)}");
                Console.WriteLine();
            }
            #endregion #region List of all objects from class and subclasses and printing.

            string answer = "y";
            //Prompting the user to get to the menu or exit the program.
               PrintChangeColour("Do you wish to go to the menu to try calculating (y/n)");

            answer = Console.ReadLine().ToLower();
            #region Calculator.
            double sidea;
            double sideb;
            double sidec;
            double sided;
            double degrees;
            while (answer == "y")
            {
                // Calls the method to print the menu.
                ShowMenu();
                Console.ForegroundColor = ConsoleColor.Green;

                // Calls the method to get the users input and checks if it is an integer.
                int menuChoice = GetMenuChoice("Choose the figure you wish to calculate perimeter and area of");
                Console.ResetColor();
                switch (menuChoice)
                {
                    case 1:
                        // Gets the users input and checks if it is a double.
                        sidea = GetAnswer("Insert values for side a: ");

                        // Instantiating a new object of the class Square.
                        Square square = new Square(sidea, sidea);
                        // Prints the result by calling the method from the logiclayer , which calls the datalayer.
                        Console.WriteLine($"The perimeter of the square is: {Math.Round(LogicLayer.GetPerimeter(square),2)}");
                        Console.WriteLine($"The area of the square is: {Math.Round(LogicLayer.GetArea(square),2)}");
                        break;

                    case 2:
                        sidea = GetAnswer("Insert values for side a: ");
                        sideb = GetAnswer("Insert values for side b: ");
                        Square rectangle = new Rectangle(sidea, sideb);
                        Console.WriteLine($"The perimeter of the rectangle is: {Math.Round(LogicLayer.GetPerimeter(rectangle),2)}");
                        Console.WriteLine($"The area of the rectangle is: {Math.Round(LogicLayer.GetArea(rectangle),2)}");
                        break;

                    case 3:
                        sidea = GetAnswer("Insert values for side a: ");
                        sideb = GetAnswer("Insert values for side b: ");
                        degrees = GetAnswer("Insert value for degrees of the angle");
                        Square parallelogram = new Parallelogram(sidea, sideb, degrees);
                        Console.WriteLine($"The perimeter of the parallelogram is: {Math.Round(LogicLayer.GetPerimeter(parallelogram),2)}");
                        Console.WriteLine($"The area of the parallelogram is: {Math.Round(LogicLayer.GetArea(parallelogram),2)}");
                        break;

                    case 4:
                        sidea = GetAnswer("Insert values for side a: ");
                        sideb = GetAnswer("Insert values for side b: ");
                        sidec = GetAnswer("Insert values for side c: ");
                        sided = GetAnswer("Insert values for side d: ");
                        Square trapeze = new Trapeze(sidea, sideb, sidec, sided);
                        Console.WriteLine($"The perimeter of the trapeze is: {Math.Round(LogicLayer.GetPerimeter(trapeze),2)}");
                        Console.WriteLine($"The area of the trapeze is: {Math.Round(LogicLayer.GetArea(trapeze),2)}");
                        break;

                    case 5:
                        sidea = GetAnswer("Insert values for side a: ");
                        sideb = GetAnswer("Insert values for side b: ");
                        Square triangle = new Triangle(sidea, sideb);
                        Console.WriteLine($"The perimeter of the triangle is: {Math.Round(LogicLayer.GetPerimeter(triangle),2)}");
                        Console.WriteLine($"The area of the triangle is: {Math.Round(LogicLayer.GetArea(triangle),2)}");
                        break;

                    case 6:
                        Environment.Exit(0);
                        break;

                    default:
                        break;
                }
                // Prompting the user to get back to the menu or exit the program.
                PrintChangeColour("Back to the menu (y/n)");
                #endregion Calculator.
                answer = Console.ReadLine().ToLower();
            }
            PrintChangeColour("Press enter to exit");
            Console.ReadKey();
        }
        // Method Menu.
        #region Method menu
        public static void ShowMenu()
        {
            Console.Clear();
            PrintChangeColour("Calculator".ToUpper());
            // Calling the method from the logic layer to get the product information to fill into the menu.
            Console.WriteLine("1) Square");
            Console.WriteLine("2) Rectangle");
            Console.WriteLine("3) Parallelogram");
            Console.WriteLine("4) Trapeze");
            Console.WriteLine("5) Triangle");
            Console.WriteLine("6) Exit");
            //PrintChangeColour("\r\nChoose an item: ");
        }
        #endregion

        // Method Getting the users choice, checking for int.
        #region GetMenuChoice
        public static int GetMenuChoice(string question)
        {
            PrintChangeColour(question);
            int output;//Erklærer en variabel der skal bruges til at indeholde brugerens svar
            while (!int.TryParse(Console.ReadLine(), out output))/*Brugerens indtastning gemmes i output og 
                                                                 * der testes for om der er indtastet et heltal.
                                                                 * whileløkken kører indtil det er et tal der er indtastet*/
            {
                PrintChangeColour("Invalid input, try again");
            }
            return output;
        }
        #endregion

        // Method Getting the users input, checking for double.
        #region GetAnswer
        public static double GetAnswer(string question)
        {
            PrintChangeColour(question);
            double output;//Erklærer en variabel der skal bruges til at indeholde brugerens svar
            while (!double.TryParse(Console.ReadLine(), out output))/*Brugerens indtastning gemmes i output og 
                                                                 * der testes for om der er indtastet et heltal.
                                                                 * whileløkken kører indtil det er et tal der er indtastet*/
            {
                PrintChangeColour("Invalid input, try again");
            }
            return output;
        }
        #endregion
        // Method for printing and changing colour.
        #region ChangeColour.
        public static void PrintChangeColour(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        #endregion Changecolour.
    }
}