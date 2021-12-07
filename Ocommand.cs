using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace 편의점_포스MVVM
{
    class Ocommand : Notifier
    {
        private int total;

        public int Total
        {
            get { return total; }
            set
            {
                total = value;
                OnPropertyChanged("Total");
            }
        }

        private int money;

        public int Money
        {
            get { return money; }
            set
            {
                money = value;
                OnPropertyChanged("Money");
            }
        }
        private int result;

        public int Result
        {
            get { return result; }
            set
            {
                result = value;
                OnPropertyChanged("Result");
            }
        }


        public Ocommand(int total, int result)
        {
            this.Total = total;
            //this.Money = money;
            this.Result = this.Money - this.Total;
        }

        public void DDB()
        {
            this.Total += 3500;
        }
        public void JMB()
        {
            this.Total += 1000;
        }
        public void SD()
        {
            this.Total += 3500;
        }
        public void UM()
        {
            this.Total += 5000;
        }
        public void KB()
        {
            this.Total += 2000;
        }
        public void TG()
        {
            this.Total += 3000;
        }
        public void DG()
        {
            this.Total += 1000;
        }
        public void CG()
        {
            this.Total += 1500;
        }
        public void RM()
        {
            this.Total += 2500;
        }

        public void Cancel()
        {
            this.Total = 0;
            this.Result = 0;
        }

        public void Clear()
        {
            this.Total = 0;
            this.Result = 0;
            this.Money = 0;

        }
   
    }
}
