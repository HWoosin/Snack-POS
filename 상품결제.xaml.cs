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
    /// 상품결제.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class 상품결제 : Page
    {
        public 상품결제()
        {
            InitializeComponent();
           
            this.DataContext = new OcViewModel();
        }

        private void 결제_Click(object sender, RoutedEventArgs e)
        {
            취소.IsEnabled = false;
        }

        private void 초기화_Click(object sender, RoutedEventArgs e)
        {
            취소.IsEnabled = true;
        }

    }
}
