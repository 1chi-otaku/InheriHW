using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace InheriHW
{
    class Money
    {
        int pound;
        int pence;

        public Money() : this(0, 0) { }
        public Money(int pound, int pence)
        {
            this.pound = pound;
            if (pence < 99 && pence > -1) this.pence = pence;
        }
        public void Print() => Console.WriteLine(pound + "." + pence);

        public int Pound
        {
            get { return pound; }
            set { pound = value; }
        }
        public int Pence
        {
            get { return pence; }
            set {
                if (value <= 99 && value >= 0) pence = value;
            }
        }
    }

    class Product
    {
        Money price;
        string product_name;

        public Product(string product_name, int pound, int pence = 0)
        {
            price = new Money(pound, pence);
            this.product_name = product_name;
        }
        public void Print()
        {
            Console.Write("----------------\nProduct - " + product_name + "\nPrice - ");
            price.Print();
            Console.WriteLine("----------------");
        }
        public void DecreasePrice(int pound, int pence = 0)
        {
            price.Pound -= pound;
            if (pence > 100 || pence < 0) return;

            if (price.Pence - pence >= 0) price.Pence -= pence;
            else {
                price.Pound--;
                price.Pence = 100 - pence;
            }
        }
        public void IncreasePrice(int pound, int pence = 0)
        {
            price.Pound += pound;
            if (pence > 100 || pence < 0) return;

            if (price.Pence + pence <= 99) price.Pence += pence;
            else
            {
                price.Pound++;
                price.Pence = price.Pence + pence - 100;
            }
            
        }
    }

}
