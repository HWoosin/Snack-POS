using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace 편의점_포스MVVM
{
    /// <summary>
    /// 재고조회.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class 재고조회 : Page
    {
        

        public 재고조회()
        {
            InitializeComponent();
            this.DataContext = new UproductViewModel();
        }

    
    }
}
