using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheriHW
{
    abstract class Device
    {
        protected string device_name;

        public Device() : this("N/A") { }
        public Device(string device_name) => this.device_name = device_name;
        abstract public void Sound();
        abstract public void Show();
        abstract public void Desc();
    }

    class Kettle : Device
    {
        string corpus_material;
        public Kettle() : base("N/A")
        {
            corpus_material = "N/A";
        }

        public Kettle(string name, string corpus_material)
        {
            device_name = name;
            this.corpus_material = corpus_material;
        }

        public override void Sound() => Console.WriteLine("Kettle does phhhhhstttt???");
        public override void Show() => Console.WriteLine("This is a kettle - " + device_name);
        public override void Desc() => Console.WriteLine("This is a kettle with " + corpus_material + " corpus material!");

    }

    class Microvawe : Device
    {
        double power;
        public Microvawe() : base("N/A")
        {
            power = 1.0;
        }

        public Microvawe(string name, double power)
        {
            device_name = name;
            this.power = power;
        }
        public override void Sound() => Console.WriteLine("Microvawe does tuuuuuuuu~ pip,pip,pip!");
        public override void Show() => Console.WriteLine("This is a microvawe - " + device_name);
        public override void Desc() => Console.WriteLine("This microwave is " + power + " watt!");
    }
    class Car : Device
    {
        string engine;
        public Car() : base("N/A")
        {
            engine = "N/A";
        }
        public Car(string name, string engine)
        {
            device_name = name;
            this.engine = engine;
        }
        public override void Sound() => Console.WriteLine("Car does ~wuuuuuuuuUUUUUUUUUUUUUU pr, pr, pr...");
        public override void Show() => Console.WriteLine("This is a car - " + device_name);
        public override void Desc() => Console.WriteLine("This car has " + engine + " engine!");
    }
    class Streamer : Device
    {
        double displacement;
        public Streamer() : base("N/A")
        {
            displacement = 0.0;
        }
        public Streamer(string name, double displacement)
        {
            device_name = name;
            this.displacement = displacement;
        }
        public override void Sound() => Console.WriteLine("Streamer does Pshhhhhhh..... pshhhhhh.... pshhh....psh.... 0_0");
        public override void Show() => Console.WriteLine("This is a streamer - " + device_name);
        public override void Desc() => Console.WriteLine("This streamer has " + displacement + " displacement");
    }

}
