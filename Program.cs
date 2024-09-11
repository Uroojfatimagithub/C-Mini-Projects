using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text; 
using System.Threading.Tasks;

namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //this is important for debugging .do not remove this
            /*yeh comments hen single line or multiple line same hen jesy hum baaki language s men use karty*/
            // int arooj = 20;
            /*Data types in C# :
             int(4 bytes),long(8 bytes),float(4 bytes),Double(8 bytes),character(2 bytes),string(2 bytes per character),boolean(1 bit very minimum storage)
            yeh jo read line hota hy yeh ek string return karta hy 
             */
            // string inp = Console.ReadLine();
            //Console.WriteLine(inp);
            //Console.WriteLine("Hello World");
            //Console.Write("Hello Arooj");
            //Console.WriteLine("I Love C# and the number is " + arooj);

            //Datatypes Examples
            ////
            //int a = 34;
            //float b = 34.4F;   //jab F nhi daala tha to recongnize nhi kar pa rha tha k yeh floating point number hy or error dy rha hy to is ko recognize karny k liye F lgana parta phir error nhi ata
            //double c = 44.5D;   //doube k liye D best hota
            //bool isGreat = false;
            //Char d= 'a';
            //String e = "this is a string";
            //Console.WriteLine(a);
            //Console.WriteLine(b); 
            //Console.WriteLine(c);
            //Console.WriteLine(isGreat);
            //Console.WriteLine(d);
            //Console.WriteLine(e);


            //Type Casting    :    important concept
            //Ek value ko ek datatype sy ksi doosri datatype men convert karny ko type casting kehty hen
            //there are two types of Type Casting
            //Implicit Type Casting
            //is kaam ko khud hi compiler kar rha given table k through hamen explicitly karny ki zaroorat nhi prh rhi means jis men compiler kehta ruk men teri madad karun tu ny kuch garbar ki hy
            // //char to int to long to float to double     isko samajhny k matlab k char convert ho sakta int long float or double men or int ka promotion ho sakta long float or double men or long ka folat or double men  lets take an exampe
            // int x = 4;
            //double y = x;    //yeah this si poossible beacuse int ka promotion hp sakta double men it will show output
            //                 //Console.WriteLine(y);
            //                 //int z = y;  //it is giving me error beacuse y  double hy or double ka promotion int men nhi ho sakta
            // int z = 'y'; //this will not give error beceause char promote int
            //Console.WriteLine(z);    this will print value 121 on secreen it means it will print the ascii value of y 
            //Explicit type Casting
            //jab hum khud explicitly mention karty means jo hum khud karn chahty men compiler ko instruction dy rhi k men karna chahti hun 
            /*int x = (int)3.5;*/    //hum int men double ko store kar rhy that is not posible to hum type cast kar rhy
                                     //                         //Console.WriteLine(x);
                                     //double x1 = (double)3.5;
                                     //Console.WriteLine(x1);       //3.5 will print on screen
                                     // Console.ReadLine();



            //there is some one more method for converting data types those methods are built in in C#

            //float varr = Convert.ToInt32(3.55);
            //Convert.ToDouble;
            //Convert.ToString;
            //Console.WriteLine(varr);       

            //To take input from user
            //Console.WriteLine("Enter Your Name");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hi Hello " + name);

            //Console.WriteLine("How many candies do you want");
            //string can = Console.ReadLine();
            //Console.WriteLine("You will get 4 more Candies " + can + 4);
            //when i enter 4 candies it is giving me 44 candies means yeh 4 ko bhi string consider kar rha or isy add nhi kar rha beacuse redine strign return kar rha to hamen add karny k iye can ko int men convert kRNA PRY gs or double brackets use karni parengi tab correct output ay gi

            //Console.WriteLine("How many candies do you want");
            //string can = Console.ReadLine();
            //Console.WriteLine("You will get 4 more Candies " + (Convert.ToInt32(can) + 4));

            //operators in C#
            /* 1 Arithmetic operators
             * 2 Assignment operators
             * 3 Logical operators
             * 4 Comparison operators
             */

            //int a = 4;
            //int b = 2;
            //Console.WriteLine("the value of a + b is : " +(a + b));
            //Console.WriteLine("the value of a - b is : " +(a - b));
            //Console.WriteLine("the value of a * b is : " +(a * b));
            //Console.WriteLine("the value of a / b is : " +(a / b));

            //Assignment operators
            //int a = 4;
            //int b = a;
            // b+= 4;
            //b -= 4;
            //b *= 4;
            //b /= 4;
            //Console.WriteLine(b);

            //Logical opertors
            //logical op 2 boolean perators men operate karty hen

            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);

            //Console.WriteLine(true || false);
            //Console.WriteLine(true || true);
            //Console.WriteLine(false || false);

            //Console.WriteLine(!false);
            //Console.WriteLine(!true);

            //Comparison opertors
            //Console.WriteLine(324 > 555);
            //Console.WriteLine(324 <= 555);
            //Console.WriteLine(324 >= 555);
            //Console.WriteLine(324 != 555);
            //Console.WriteLine(5 == 5);

            //Math operations : is men kuch classes hoti unhen recognize karwengy
            //Math ki class hmaary system k andr hoti to hmaari system .Math ek class hoti jisko hum directly acccess kar pa rhy hen beacuae hum ny already first ine men using saystem likha hua hy ab system .math k andar
            //ek max function hy jo k 2 values ly rha hy or max return kar rha hy
            //int a = Math.Max(34, 345);
            //int b = Math.Min(34, 345);
            //double c = Math.Sqrt(6);  //square root
            //int d=Math.Abs(-39); //absolute
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);

            //String functions Main topic

            //string hello = "Hello world this is Arooj";
            //Console.WriteLine(hello.Length);
            //Console.WriteLine(hello.ToLower());
            //Console.WriteLine(hello.ToUpper());
            //Console.WriteLine(hello + " You are nice");
            //Console.WriteLine( string.Concat(hello , " You are nice"));

            //String Interpolition means agar apni string ko readable bnana chahty ho
            //string name=Console.ReadLine();
            //string candies=Console.ReadLine();
            //Console.WriteLine($"Your name is {name}. You will get {candies} candies");

            //string hello = "Hello world this is Arooj";
            //Console.WriteLine(hello[0]);
            //Console.WriteLine(hello.IndexOf("Hello"));     
            //Console.WriteLine(hello.IndexOf("is"));     //yeh jo word ki pehli occurrence ka resut hy wo return kary ga
            //Console.WriteLine(hello.Substring(5));     //5th index py jo string ka word hy jo start ho rha whan sy display hona start hoga
            //                                           //basically yeh ooper wala sentence ek nae string return kr rha hoga puraani py koi affect nhi pary ga
            //Console.WriteLine(hello);     //like yeh whi sentence return kry ga jo original hoga

            //Escape Sequences in string
            //string hello = "Hello world this \" is Arooj";
            ////measn agar display men " print karwana to / kar k karwana pary ga tab hi print hoga else error dy ga
            //string hello = "Hello world this \n is Arooj";
            //string hello = "Hello world this \t is Arooj";
            //Console.WriteLine(hello);

            //Decision Control
            //decision k liye C sharp men hmaary paas conditionals hoty hen
            //

            //Console.WriteLine("Enter Your Age");
            //string ageStr=Console.ReadLine();
            //int age = Convert.ToInt32(ageStr);
            ////if (age > 18)
            ////{ Console.WriteLine("you can drive beacuse you are above 18"); }
            //bool isBanned=true;
            // if (age < 2 || isBanned)
            //{
            //    { Console.WriteLine("you are just born or Banned"); }

            //}
            //else if (age < 10 || isBanned)
            //{
            //    { Console.WriteLine("Please finish your high school or maybe you are Banned"); }
            //}
            //else if (age < 18 && isBanned)
            //{
            //   { Console.WriteLine("You are below 18 and Banned also"); }
            //}
            //else if (age < 75)
            //{
            //    { Console.WriteLine("You can Drive"); }
            //}
            //else
            //{ Console.WriteLine("you cannot drive beacuse you are under 18"); }    //is poory portion ko if else ladder bhi bolty hen


            //Switch Statement
            //int age = 8;
            //switch(age)
            //{
            //    case 56:
            //        Console.WriteLine("Please Wait for an year");
            //        break;
            //    case 16:
            //        Console.WriteLine("You are 16");
            //        break;
            //    default:
            //        Console.WriteLine("Enjoy!");
            //        break;
            //}


            //Loops in C shrp : Loops ka matlab hota hy ek cheez ko baar baar use karna
            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            ////but if we have to execute this statement  for 50000 lines it wil be too difficult so we can use loopes insted of this
            ///
            //while loop

            //int i = 0;
            //while (i < 5)
            //{

            //    Console.WriteLine(i+1);
            //    i++ ;
            //}      
            //it will print from 0 to 4 if we want  from 1 to 5 we can do i+1

            //int i = 0;
            //do
            //{

            //    Console.WriteLine(i + 1);
            //    i++;
            //}
            //while (i < 5) ;      //if i>5 hota to sirf 1 print hota beacuse condition false lekin phir bhi do while means ek dfa ouptut to ay gi hi shi


            //for loop
            //for (int i = 0; i < 5; i++)
            //{
            //if(i==0)          //means i==0 k liye chor k aagy sy continue karo
            //{ 
            //continue;}      //means continue kar do agli waali iteration ko or is waali iteration ko bhool jao means continue kehta mery neechy jo bhi likha usy bhool jao or agli iteration py in statement ko chalo 
            //    Console.WriteLine(i+1);
            //break;     //means loop ko chor do or hamesha hamesha k liye chaly jao  so break statement sy sirf 1 print hoga ek baar
            //}

            //Break and continue Concept
            //break means tor do or continue means is waaly ko tor do or aagy waaly sy continue karo
            //Break- leave this loop forever
            //Continue-leave this particular itteration of the loop
            //

            //Methods or functions
            //Greet("Arooj");
            ////Console.WriteLine(Average(2, 4, 7));
            //float temp = Average(3, 3, 3);
            //Console.WriteLine(temp);
            //Console.WriteLine(Average(8, 9));


            //OOP- classes and objects
            //oop cheezon ko karny ka ek tareeka hy programming men

            //Player tommy=new Player();     //yeh player bnaany ka syntax hy player bna k uski jo by default health hy wo print karaengy
            //Console.WriteLine(tommy.health);
            //tommy.sethealth(57);
            //Console.WriteLine(tommy.health);


            //agar private ko access karna ho to gethealth lagengy member functions ki help sy access kar sakty
            Player tommy = new Player();     
            Console.WriteLine(tommy.gethealth());
            tommy.sethealth(57);
            Console.WriteLine(tommy.gethealth());
            Console.ReadLine();
        }
        //static void Greet(string name)      //static simple means k yeh jo finction hy yeh is clas ko belong krta hy jiska name program hy ab class kea hota hy class ek blue print hota hy objects ko create karny k liye
        //{
        //    Console.WriteLine("Good Morning " + name);        //void means doesnot return anyhting
        //}
        //static float Average(int a, int b, int c)
        //{
        //    float sum = a + b + c;
        //    return sum/3;
        //}
        //static float Average(int a, int b)   //function overloading
        //{
        //    float sum = a + b;
        //    return sum / 2;
        //}
    }
}

