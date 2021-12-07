using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 편의점_포스MVVM
{
   class OrderViewModel
    {
        Order or = null;

        public OrderViewModel()
        {
            or = new Order();
            AddOrder();
        }

        ObservableCollection<Order> _orderDatas = null;
        public ObservableCollection<Order> OrderDatas
        {
            get
            {
                if (_orderDatas == null)
                {
                    _orderDatas = new ObservableCollection<Order>();
                }
                return _orderDatas;
            }
            set
            {
                _orderDatas = value;
            }
        }

        public void AddOrder()
        {
            Order or1 = new Order();
            or1.Name = "떡볶이";
            or1.Price = 3500;

            OrderDatas.Add(or1);
            
            Order or2 = new Order();
            or2.Name = "순대";
            or2.Price = 3500;

            OrderDatas.Add(or2);

            Order or3 = new Order();
            or3.Name = "튀김";
            or3.Price = 3000;

            OrderDatas.Add(or3);

            Order or4 = new Order();
            or4.Name = "어묵탕";
            or4.Price = 5000;

            OrderDatas.Add(or4);

            Order or5 = new Order();
            or5.Name = "떡꼬치";
            or5.Price = 1000;

            OrderDatas.Add(or5);

            Order or6 = new Order();
            or6.Name = "라면";
            or6.Price = 2500;

            OrderDatas.Add(or6);

            Order or7 = new Order();
            or7.Name = "닭꼬치";
            or7.Price = 1500;

            OrderDatas.Add(or7);

            Order or8 = new Order();
            or8.Name = "김밥";
            or8.Price = 2000;

            OrderDatas.Add(or8);

            Order or9 = new Order();
            or9.Name = "주먹밥";
            or9.Price = 1000;

            OrderDatas.Add(or9);

        }

    }
}
