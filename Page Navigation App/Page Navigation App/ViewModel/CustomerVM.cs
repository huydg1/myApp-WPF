using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Page_Navigation_App.Model;

namespace Page_Navigation_App.ViewModel
{
    class CustomerVM : Utilities.ViewModelBase
    {
        private readonly PageModel _pageModel;
        public int CustomerID
        {
            get { return _pageModel.CustomerCount; }
            set { _pageModel.CustomerCount = value; OnPropertyChanged(); }
        }

        public CustomerVM()
        {
            _pageModel = new PageModel();
            DateTime d1 = Convert.ToDateTime("05/15/2023");
            DateTime d2 = Convert.ToDateTime(DateTime.Now.ToString("MM/dd/yyyy"));
            TimeSpan time = d2.Subtract(d1);
            int days = Convert.ToInt32(time.Days);
            CustomerID = days;
        }
    }
}
