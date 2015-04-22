using Cirrious.MvvmCross.ViewModels;
using CM.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Core.ViewModels
{
    public class StudentViewModel : MvxViewModel
    {
        private readonly IStudentService _studentSrv;
        private readonly MvxCommand _command;
        public StudentViewModel(IStudentService serviceSrv)
        {
            _studentSrv = serviceSrv;

        }
        public async void Init(string userName)
        {
           
            var result = await _studentSrv.GetByUserName(userName);
            StudentId = result.StudentId;
            FullName = result.FullName;
            Password = result.Password;
            ImagePath = result.ImagePath;
            Email = result.Email;
            PhoneNumber = result.PhoneNumber;
            Description = result.Description;
        }

        private int _studentId;
        public int StudentId
        {
            get { return _studentId; }
            set { _studentId = value; RaisePropertyChanged(() => StudentId); }
        }

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

        private string _fullName = string.Empty;
        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; RaisePropertyChanged(() => FullName); }
        }

        private DateTime _DOB;
        public DateTime DOB
        {
            get { return _DOB; }
            set { _DOB = value; RaisePropertyChanged(() => DOB); }
        }

        private string _imagePath = string.Empty;
        public string ImagePath
        {
            get { return _imagePath; }
            set { _imagePath = value; RaisePropertyChanged(() => ImagePath); }
        }

        private string _email = string.Empty;
        public string Email
        {
            get { return _email; }
            set { _email = value; RaisePropertyChanged(() => Email); }
        }


        private string _phoneNumber = string.Empty;
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; RaisePropertyChanged(() => PhoneNumber); }
        }

        private string _description = string.Empty;
        public string Description
        {
            get { return _description; }
            set { _description = value; RaisePropertyChanged(() => Description); }
        }
    }
}
