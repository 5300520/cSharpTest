using static System.Console;
namespace cTest
{
    class  Testing
    {
        static void Main(string[] args)
        {
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
            /*c# operators are the same as python's but no DIV
             + - = / % 
            ++ is increment, adds one to the value
            -- is decrement, minuses one from the value*/


        }
    }
}


