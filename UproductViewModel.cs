using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace 편의점_포스MVVM
{
    class UproductViewModel
    {
        Uproduct up = null;
        
        public UproductViewModel()
        {
            up = new Uproduct();
            AddProduct();
        }
        
        ObservableCollection<Uproduct> _productDatas = null;
        public ObservableCollection<Uproduct> ProductDatas
        {
            get
            {
                if (_productDatas == null)
                {
                    _productDatas = new ObservableCollection<Uproduct>();
                }
                return _productDatas;
            }
            set
            {
                _productDatas = value;
            }
        }

        public void AddProduct()
        {
            Uproduct up1 = new Uproduct();
            up1.Name = "떡";
            up1.Maker= "풀무원";
            up1.Price = 10000;
            up1.Count = 10;

            ProductDatas.Add(up1);

            Uproduct up2 = new Uproduct();
            up2.Name = "고추장";
            up2.Maker = "청정원";
            up2.Price = 4000;
            up2.Count = 1;

            ProductDatas.Add(up2);

            Uproduct up3 = new Uproduct();
            up3.Name = "대파";
            up3.Maker = "농/수산도매";
            up3.Price = 5000;
            up3.Count = 5;

            ProductDatas.Add(up3);

            Uproduct up4 = new Uproduct();
            up4.Name = "어묵";
            up4.Maker = "부산어묵";
            up4.Price = 3500;
            up4.Count = 15;

            ProductDatas.Add(up4);
        }
       
    }
}

