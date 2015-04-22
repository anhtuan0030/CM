using Cirrious.MvvmCross.ViewModels;
using CM.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Core.ViewModels
{
    public class ListTeacherViewModel : MvxViewModel
    {
        private readonly ITeacherService _teacherService;

        public ListTeacherViewModel(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        public async void Init(string Username)
        {
            //var result = await _teacherService.GetTeachers();
            ListData = await _teacherService.GetTeachers();
        }

        private IEnumerable<Teachers> _listData;
        public IEnumerable<Teachers> ListData
        {
            get { return _listData; }
            set { _listData = value; RaisePropertyChanged(() => ListData); }
        }

        public void ShowTeacherDetail(int id)
        {
            ShowViewModel<TeacherViewModel>(new { TeacherId = id });
        }

        //--------------Student info---------------------------------

        public void ShowStudentDetail(string username)
        {
            ShowViewModel<StudentViewModel>(new { UserName = username });
        }
        public void GotoLogin()
        {
            ShowViewModel<LoginViewModel>();
        }
    }
}
