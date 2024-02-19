using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC.Model
{
    public class Tip
    {
        private double amount;
        private double percent;
        public double Amount
        {
            get { return this.percent; }
        set
            {
                if (value > 1)
                {
                    this.percent = value / 100.0;
                }
                else
                {
                    this.percent = value;
                }
            }
        }
        public Tip(double amount, double percent)
        {
            Amount = amount;
            this.percent = percent;
        }
        public Tip() :  this(0, 0) { }

        public double CalculateTip()
        {
            return Amount * percent;
        }
         public double CalculatePercent()
        {
            return CalculateTip() + Amount;
        }

        public double CalculateTotal() 
        {
            return CalculateTip() + Amount;
        }
    }
}
