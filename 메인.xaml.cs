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
    /// 메인.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class 메인 : Page
    {
        public 메인()
        {
            InitializeComponent();
            this.DataContext = new MainViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/상품결제.xaml", UriKind.Relative));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/재고조회.xaml", UriKind.Relative));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
           NavigationService.Navigate(new Uri("/점주메뉴.xaml", UriKind.Relative));
        }

       
    }
}
