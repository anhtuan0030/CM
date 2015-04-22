using Cirrious.MvvmCross.ViewModels;
using CM.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Core.ViewModels
{
    public class TeacherViewModel : MvxViewModel
    {
        private readonly ITeacherService _tearcher;
        private readonly MvxCommand _command;
        public TeacherViewModel(ITeacherService teacher)
        {
            _tearcher = teacher;
            
        }



        public async void Init(int TeacherId)
        {
            //var result = await _teacherService.GetTeachers();
            var result = await _tearcher.SelectTeacherByKey(TeacherId);
            TeacherId = result.TeacherId;
            FullName = result.Fullname;
            Subject = result.Subject;
            ImagePath = result.ImagePath;
            Email = result.Email;
            PhoneNumber = result.PhoneNumber;
            Description = result.Description;
        }




        private int _teacherId ;
        public int TeacherId
        {
            get { return _teacherId; }
            set { _teacherId = value; RaisePropertyChanged(() => TeacherId); }
        }

        private string _fullName = string.Empty;
        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; RaisePropertyChanged(() => FullName); }
        }

        private string _subject = string.Empty;
        public string Subject
        {
            get { return _subject; }
            set { _subject = value; RaisePropertyChanged(() => Subject); }
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
