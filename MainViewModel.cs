using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace 편의점_포스MVVM
{
    class MainViewModel
    {
        public string Name { get; set; }

        public MainCommand ShowMsg { get; set; }

        public MainViewModel()
        {
            ShowMsg = new MainCommand(Execute, CanExecute);
        }

        private bool CanExecute(object arg)
        {
            return true;
        }

        private void Execute(object obj)
        {
            if (Name == null)
                MessageBox.Show("근무자를 입력하십시오.");

            else
            MessageBox.Show($"근무를 시작합니다! <<근무자:{Name}>>","근무자 교대");
        }
    }
}
