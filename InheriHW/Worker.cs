using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheriHW
{
    abstract class Worker
    {
        protected string name;
        public Worker(string name)=> this.name = name;
        abstract public void Print();
    }

    class President : Worker
    {
        public President(string name):base(name) { }

        public override void Print()
        {
            Console.WriteLine("This is a president - " + name);
        }
    }

    class Security : Worker
    {
        public Security(string name) : base(name) { }

        public override void Print()
        {
            Console.WriteLine("This is a Security - " + name);
        }
    }

    class Engineer : Worker
    {
        public Engineer(string name) : base(name) { }

        public override void Print()
        {
            Console.WriteLine("This is a Engineer - " + name);
        }
    }

    class Manager : Worker
    {
        public Manager(string name) : base(name) { }

        public override void Print()
        {
            Console.WriteLine("This is a Manager - " + name);
        }
    }
}
