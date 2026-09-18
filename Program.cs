//MAKE A SWITCH STATEMENT TO MAKE NAVIGATING EASIER
using static System.Console;
namespace cTest
{
    class Testing
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)
            {
                WriteLine("where would you like to go? " +
                    "0: exit " +
                    "1:string manipulation " +
                    "2:casting and if statements " +
                    "3:loops " +
                    "4: arrays and 2d arrays ");
                int choice = Convert.ToInt32(ReadLine());
                switch (choice)
                {
                    case 0:
                        isRunning = false;
                        WriteLine("exiting...");
                        break;
                    case 1:
                        WriteLine("Hello World");
                        //print on new line, like py print and rust prntln!
                        string nameFirst = "Charles";
                        /*defines the variable nameFirst as Charles using the syntax of
                         type name = value */
                        string nameSecond = "Babbage";
                        string nameFull = nameFirst + " " + nameSecond;
                        WriteLine(nameFull);
                        /*concatenation!!!!!!
                         uses same syntax as py*/
                        Write("give username ");
                        //not WriteLine so the input can be written on the same line, very nice
                        string userName = ReadLine();
                        WriteLine("your username is " + userName);
                        //user input!!! 

                        break;
                    case 2:
                        //user input!!!
                        /*c# operators are the same as python's but no DIV
                         + - = / % 
                        ++ is increment, adds one to the value
                        -- is decrement, minuses one from the value*/
                        int myNum = 18;
                        double myDouble = (double)myNum;
                        /* casting
                            can use Convert. with To(data type)*/
                        WriteLine("give 2 numbers");
                        string num1 = ReadLine();
                        string num2 = ReadLine();
                        int n1 = Convert.ToInt32(num1);
                        int n2 = Convert.ToInt32(num2);
                        if (n1 != n2)
                        {
                            WriteLine("The numbers are not equal.");
                        }
                        else
                        {
                            WriteLine("The numbers are equal.");
                        }
                        string result = (n1 > n2) ? "n1 is greater than n2" : "n1 is not greater than n2";
                        WriteLine(result);
                        /*if statements are the same as python's but with () and {} instead of : and indentation
                            also else if
                        also, use the shorthand ternary operator for simple if statements */
                        break;
                    case 3:
                        int iterationInt = 0;
                        while (iterationInt < 5)
                        {
                            WriteLine("while loop iteration " + iterationInt);
                            iterationInt++;
                        }
                        // while loops are the same as python's but with () and {} instead of : and indentation
                        for (int iterationInt2 = 0; iterationInt2 < 5; iterationInt2++)
                        {
                            WriteLine("for loop iteration " + iterationInt2);
                        }
                        // for loops are the same as python's but with () and {} instead of : and indentation
                        // you can use break and continue to exit a loop or skip an iteration in loops, same as python
                        break;
                    case 4:
                        string[] cars = { "e30", "g10", "prelude", "ae86" };
                        foreach (string car in cars)
                        {
                            WriteLine(car);
                        }
                        // foreach loops are the same as python's but with () and {} instead of : and indentation
                        cars[3] = "r34";
                        WriteLine("Updated car list:");
                        foreach (string car in cars)
                        {
                            WriteLine(car);
                        }
                        // to change a value in an array, you can use the index of the value to change it
                        WriteLine(cars.Length);
                        // to get the length of an array, you can use the Length property
                        string[,] languages = { { "rust", "c#" }, { "python", "lua" } };
                        for (int i = 0; i < languages.GetLength(0); i++)
                        {
                            for (int j = 0; j < languages.GetLength(1); j++)
                            {
                                WriteLine(languages[i, j]);
                            }
                        }
                        //2D arrays need a for loop for each dimension, and you can use GetLength(dimension) to get the length of each dimension
                        break;
                    default:
                        WriteLine("thats not a valid option, loser");
                        break;

                }
            }
        }
    }
}


