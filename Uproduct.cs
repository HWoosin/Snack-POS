using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace 편의점_포스MVVM
{
    class Uproduct :Notifier
    {
        public string Name { get; set; }
        public string Maker { get; set; }
        public int Price { get; set; }

        private int count;
        public int Count
        {
            get { return count; }
            set
            {
                count = value;
                OnPropertyChanged("Count");
            }
        }
        
    }
}

