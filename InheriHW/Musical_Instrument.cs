using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheriHW
{
    abstract class Musical_Instrument
    {
        protected string instrument;
        public Musical_Instrument(string instrument) => this.instrument = instrument;
        abstract public void Sound();
        abstract public void Show();
        abstract public void Desc();
        abstract public void History();
    }

    class Violin : Musical_Instrument
    {
        string bow_type;

        public Violin(string name, string bow_type):base(name)
        {
            this.bow_type = bow_type;
        }

        override public void Sound() => Console.WriteLine("Violin does tuUUU,tUUUU,TuuuuU!");
        override public void Show() => Console.WriteLine("This is a violin");
        override public void Desc() => Console.WriteLine("This is a violin - " + instrument + ". Violin has " + bow_type + " bow type!");
        override public void History() => Console.WriteLine("Most historians agree that today's violin emerged in the early 16th century in northern Italy, an area which would maintain the violin-making tradition over the coming centuries.");
    }
    class Trombone : Musical_Instrument
    {
        double bore;

        public Trombone(string name, double bore) : base(name)
        {
            this.bore = bore;
        }

        override public void Sound() => Console.WriteLine("Trombone does DUDUDUDUDUDDUDUDUDU!");
        override public void Show() => Console.WriteLine("This is a Trombone");
        override public void Desc() => Console.WriteLine("This is a Trombone - " + instrument + ". Trombone has " + bore + " mm bore");
        override public void History() => Console.WriteLine("The trombone is a 15th-century development of the trumpet and, until approximately 1700, was known as the sackbut. Like a trumpet, it has a cylindrical bore flared to a bell.");
    }

    class Ukulele : Musical_Instrument
    {
        double scale_len;

        public Ukulele(string name, double scale_len) : base(name)
        {
            this.scale_len = scale_len;
        }

        override public void Sound() => Console.WriteLine("Ukulele does Tryyyn,tryyyn, trimp!");
        override public void Show() => Console.WriteLine("This is a Ukulele");
        override public void Desc() => Console.WriteLine("This is a Ukulele - " + instrument + ". Trombone has " + scale_len + " mm scale lenght");
        override public void History() => Console.WriteLine("The first ukulele is said to have been built in 1879; however, it is not clear who invented this instrument. ");
    }

    class Cello : Musical_Instrument
    {
        string tailpiece_type;

        public Cello(string name, string tailpiece_type) : base(name)
        {
            this.tailpiece_type = tailpiece_type;
        }
        override public void Sound() => Console.WriteLine("Cello does wryyn, wryyn, wryyy!");
        override public void Show() => Console.WriteLine("This is aCello");
        override public void Desc() => Console.WriteLine("This is a Cello - " + instrument + ". Cello has " + tailpiece_type + "tailpiece type");
        override public void History() => Console.WriteLine("The cello came to the limelight for the first time in northern Italy in 1550. It is a member of the violin family and was initially called bass violin.");
    }

}
