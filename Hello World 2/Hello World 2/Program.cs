using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Hello_World_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            //const float pi=3.14;                       We cannot define a constant without setting its value
            //byte number=9;
            //int count = 10;
            //float totalPrice = 20.95f;
            //char character = 'A';
            //string name = "MOSH";
            //bool isworking = false;

            //in C# there is a shortcut insted of these of these data types we can simple use a var keywork with these variable names
            //and when we hover over the var keyword it automaticallt tells us the data dtype which has been used
            //var number = 9;
            //var count = 10;
            //var totalPrice = 20.95f;   //system single which maps to float in C#
            //var character = 'A';
            //var name = "MOSH";
            //var isworking = false;

            //Console.WriteLine(number);
            //Console.WriteLine(
            //    count);
            //Console.WriteLine(totalPrice);
            //Console.WriteLine(character);
            //Console.WriteLine(name);
            //Console.WriteLine(isworking);
            //Console.WriteLine("{0} {1}",byte.MinValue,byte.MaxValue);
            //0 represents karta first argument ko means byte.minvalue ko or 1 represents karta 2nd argument means byte.maxvalue ko
            //is sy byte ka minimum or mximum size mil jata same for float or other data types
            //Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);


            //Constant
            //const float Pi= 3.14f;
            //now this pi is constant we cant change this anywhere in our program

            //Type Casting
            // byte b = 1;
            //int i = b;
            //Console.WriteLine(i);

            //int i = 1;
            //byte b = i;
            //Console.WriteLine(b);
            //when we compile it is giving error saying cannot implicity convert int to byte
            //because int has size 4 and byte has size 1 so compiler is unhappy beacuse there is a chance of lossing data
            //compiler is saying you can do an explicit conversion like  byte b = byte(i);

            //Non compatible types
            //var num = "1234";
            //int a=Convert.ToInt32(num);
            //Console.WriteLine(a);
            //but if there is a byte instead of int it means its size has been increased and when we run it will throw an exception and 
            //message is shown on secreeen overflow exception means hmaari application crash hogae

            //var num = "1234";
            //byte a = Convert.ToByte(num);
            //Console.WriteLine(a);


            // now  learning how to handle these exceptions
            //we can do this with try-catch block
            //try
            //{
            //    var num = "1234";
            //    byte a = Convert.ToByte(num);
            //    Console.WriteLine(a);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("The number could not be converted to a byte!!");       //now we will get friendly msg and the application did not crash
            //}
            //pehly hum ny exception ko handle nhi kea tha isi liye app crash hogae thi lekin ab hum excption ko handle kar rhy pehly try block chaly ga
            // pehlt ytry ka code monitored kea jay ga agar exception hui to catch hndle hoga execute hoga


            //Operators in C#
            //var a = 10;
            //var b = 3;
            //Console.WriteLine(a + b);
            //Console.WriteLine(a/b);
            //if we want floating point result
            //    Console.WriteLine(float(a) /float(b));
            //var a = 1;
            //var b = 2;
            //var c = 3;
            //Console.WriteLine(a+b*c);    //the result will be 7 mul has higer precedence than addition
            //Console.WriteLine((a+b)*c);    //the result will be 9 beacause of brackets

            //comparison operators       
            //the result of comparison operators is always a boolean value
            //var a = 1;
            //var b = 2;
            //var c=3;
            //Console.WriteLine(a > b);      the result is false
            //Console.WriteLine(a==b);
            //Console.WriteLine(a!=b);
            //Console.WriteLine(!(a!=b));   now this time we got false


            //Logical operators
            //Console.WriteLine(c > b && c>a);     true
            //Console.WriteLine(c > b && c==a);     false
            //Console.WriteLine(c > b || c == a);    true
            //Console.WriteLine(!(c > b && c > a));     false
            Console.ReadLine();
        }
    }
}
