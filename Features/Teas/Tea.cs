using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public abstract class Tea 
    {
        protected string name;
        protected string size;
        protected float price;
        protected string drinkHot;
        protected string drinkCold;

        public void GetCup() { Console.WriteLine("Getting cup..." + name); }
        public void ChooseSize() { Console.WriteLine("Choosing size..." + size); }
        public float Pay(float price) { return price; }
        public abstract void Prepare();
    }
}
