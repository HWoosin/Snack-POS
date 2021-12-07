using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 편의점_포스MVVM
{
    class WorkerViewModel
    {
        Worker wk = null;

        public WorkerViewModel()
        {
            wk = new Worker();
            AddWorker();
        }

        ObservableCollection<Worker> _workerDatas = null;
        public ObservableCollection<Worker> WorkerDatas
        {
            get
            {
                if (_workerDatas == null)
                {
                    _workerDatas = new ObservableCollection<Worker>();
                }
                return _workerDatas;
            }
            set
            {
                _workerDatas = value;
            }
         }

        public void AddWorker()
        {
            Worker wk = new Worker();
            wk.Name = "황우신";
            wk.Age = "24";
            wk.Phone = "01012345678";
            wk.Address = "경기 안양";

            WorkerDatas.Add(wk);
        }
       
    }
}

