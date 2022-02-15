using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Sample s = new Sample();

            ChildSample cs = new ChildSample();

            cs.




        }
    }

    class Sample
    {
        public int publicProp = 10;
        private int privateProp = 20;
        internal int internalProp = 30;
        protected int protectedProp = 40;
        protected internal int protectedInternalProp = 50;
    }

    class ChildSample : Sample
    {
        void Method1()
        {
            
        }
    }


}

namespace AccessModifier1
{
    class AccessModifier1Class1 : AccessModifier.Sample
    {
        void Display()
        {
            
        }

       
    }
}
