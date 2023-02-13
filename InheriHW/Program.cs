using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace InheriHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region #1
            //Product microvawe = new Product("Microvawe", 125,90);

            //microvawe.Print();

            //Console.WriteLine("Microvawe price was increased by 1.50:");
            //microvawe.IncreasePrice(1, 50);
            //microvawe.Print();
            //Console.WriteLine("Microvawe price was decresed by 20.90:");
            //microvawe.DecreasePrice(20, 90);
            //microvawe.Print();
            #endregion

            #region #2
            //Device[] ptr = new Device[4];
            //ptr[0] = new Kettle("Supa-Kettle", "Bronze");
            //ptr[1] = new Microvawe("Time Travel microvawe", 1250.50);
            //ptr[2] = new Car("BMW", "'Supa' Engine'");
            //ptr[3] = new Streamer("Supa-Streamer", 600);

            //Console.WriteLine("------------------");
            //foreach (var device in ptr) {

            //    device.Sound();
            //    Console.WriteLine();
            //    device.Show();
            //    Console.WriteLine();
            //    device.Desc();
            //    Console.WriteLine("------------------");
            //}
            #endregion

            #region #3
            //Musical_Instrument[] ptr = new Musical_Instrument[4];
            //ptr[0] = new Violin("Viooloo!", "some type...");
            //ptr[1] = new Trombone("Troooomboonnee name", 14.4);
            //ptr[2] = new Ukulele("Supa-Ukulelelelelle", 12);
            //ptr[3] = new Cello("Cellooo_name", "some tailpice type...");


            //foreach (var instrument in ptr) {
            //    instrument.Show();
            //    instrument.Sound();
            //    instrument.Desc();
            //    instrument.History();


            //    Console.WriteLine("-------------------------------------------------");
            //}
            #endregion

            #region #4

            //Worker[] ptr = new Worker[4];
            //ptr[0] = new Manager("Tom");
            //ptr[1] = new Engineer("Alex");
            //ptr[2] = new President("John");
            //ptr[3] = new Security("Jake");
            //foreach (Worker worker in ptr)
            //{
            //    worker.Print();
            //}

            #endregion
        }
    }
}
