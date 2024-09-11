using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello{

    internal class Player             //class means hum ek apna data type bna rhy hen
    {
        public string name = "Arooj";
        //public int health = 49;   //agar yeh private kar dun public ki jga to main men program.cs men error aa jay ga beacuse accessible nhi hoga 
        //to kesy access karengy isko accesss karengy gethealth k function k through beacuse function apny private members ko access kar sakta or phir main men health ki jga get health call karengy

        private int health = 49;
        public int gethealth()
        {
            return health;
        }

        public void sethealth(int h)
        {
            health = h;
        }
    }
}
