using System.Collections.Generic;

namespace Fields
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders=new List<Order>();
        //public Customer()
        //{
        //    Orders = new List<Order>();          //  Instead of initializing indefaut construcotr we will initialize in data member
        //}
        //means yeh tha k hmen orders field ko hamesha empty list men initialize karwana parta pehly jo hum ny default constructor men karya 
        //lekin agar neechy waaly cons call hon to un men empty list nhi to pehly un men sy  default ko call karna parta that is not best practice so hum ny opper hi empty list ko initilaize kar dea
       //its entirely up to you its a personal taste how you like to initialize empty list
        public Customer(int id)
        {
            Id = id;
        }
        public Customer(int id , string name)
            :this(id)    //is sy yeh hoga k id ko idhar bhi nhi btana pary ga ooper wala constructor call hoga or whan sy id initialize ho jay gi
        {
            
            Name = name;
        }
        public void Promote()
        {
            //Orders = new List<Order>();        ab read only ki wja sy yhan error aa gya hum isy use nhi kar sakty
            //.....now let say if I accidently initialize an empty list here
        }

    }
}
