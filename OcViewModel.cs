using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace 편의점_포스MVVM
{
    class OcViewModel:Notifier
    {
        private Ocommand ocommand;
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
        



        public RelayCommand 떡볶이추가해 { get; set; }
        public RelayCommand 순대추가해 { get; set; }
        public RelayCommand 김밥추가해 { get; set; }
        public RelayCommand 어묵탕추가해 { get; set; }
        public RelayCommand 주먹밥추가해 { get; set; }
        public RelayCommand 닭꼬치추가해 { get; set; }
        public RelayCommand 떡꼬치추가해 { get; set; }
        public RelayCommand 라면추가해 { get; set; }
        public RelayCommand 튀김추가해 { get; set; }
        public RelayCommand 취소 { get; set; }
        public RelayCommand 계산 { get; set; }
        public RelayCommand 초기화 { get; set; }
       

        public OcViewModel()
        {
            ocommand = new Ocommand(0,0);
            떡볶이추가해 = new RelayCommand(DDBC);
            순대추가해 = new RelayCommand(SDC);
            김밥추가해 = new RelayCommand(KBC);
            어묵탕추가해 = new RelayCommand(UMC);
            주먹밥추가해 = new RelayCommand(JMBC);
            닭꼬치추가해 = new RelayCommand(CGC);
            떡꼬치추가해 = new RelayCommand(DGC);
            라면추가해 = new RelayCommand(RMC);
            튀김추가해 = new RelayCommand(TGC);
            취소 = new RelayCommand(CancelC);
            계산 = new RelayCommand(결제, CanExecute);
            초기화 = new RelayCommand(ClearC);
            

        }

        private bool CanExecute(object obj)
        {
            return true;
        }

        private void 결제(object obj)
        {
            Result = Money - Total;
            if (Result < 0)
                MessageBox.Show("받은 금액이 부족합니다.", "결제미완료");

            else
            {
                MessageBox.Show($"거스름돈:{ Result.ToString(" #,##0원")}", "결제완료");
              
            }
        }

        private void DDBC(object o)
        {
            ocommand.DDB();
            Total = ocommand.Total;

        }
        private void SDC(object o)
        {
            ocommand.SD();
            Total = ocommand.Total;

        }
        private void KBC(object o)
        {
            ocommand.KB();
            Total = ocommand.Total;

        }
        private void UMC(object o)
        {
            ocommand.UM();
            Total = ocommand.Total;

        }
        private void JMBC(object o)
        {
            ocommand.JMB();
            Total = ocommand.Total;

        }
        private void CGC(object o)
        {
            ocommand.CG();
            Total = ocommand.Total;

        }
        private void DGC(object o)
        {
            ocommand.DG();
            Total = ocommand.Total;

        }
        private void RMC(object o)
        {
            ocommand.RM();
            Total = ocommand.Total;

        }
        private void TGC(object o)
        {
            ocommand.TG();
            Total = ocommand.Total;

        }
        private void CancelC(object o)
        {
            ocommand.Cancel();
            Total = ocommand.Total;

        }
        private void ClearC(object o)
        {
            ocommand.Clear();
            Total = ocommand.Total;
            Money = ocommand.Money;
            Result = ocommand.Result;

        }
   
    }
}
