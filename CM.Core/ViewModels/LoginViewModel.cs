using Cirrious.MvvmCross.ViewModels;
using CM.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Core.ViewModels
{
    public class LoginViewModel : MvxViewModel
    {
        //private readonly IStudentService _studentSrv;
        //private readonly MvxCommand _command;
        //public LoginViewModel(IStudentService serviceSrv)
        //{
        //    _studentSrv = serviceSrv;

        //}




        private string _userName = string.Empty;
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; RaisePropertyChanged(() => UserName); }
        }

        private string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { _password = value; RaisePropertyChanged(() => Password); }
        }
        private string _message = string.Empty;
        public string Message {
            get { return _message; }
            set { _message = value; RaisePropertyChanged(() => Message); }
        }
    }
}
