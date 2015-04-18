using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Core.ViewModels
{
    public class CourseViewModel : MvxViewModel
    {
        private int _studentId;
        public int StudentId
        {
            get { return _studentId; }
            set { _studentId = value; RaisePropertyChanged(() => StudentId); }
        }

        private int _teacherId;
        public int TeacherId
        {
            get { return _teacherId; }
            set { _teacherId = value; RaisePropertyChanged(() => TeacherId); }
        }

        private DateTime _startDate;
        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; RaisePropertyChanged(() => StartDate); }
        }

        private DateTime _endDate;
        public DateTime EndDate
        {
            get { return _endDate; }
            set { _endDate = value; RaisePropertyChanged(() => EndDate); }
        }

        private string _schedule = string.Empty;
        public string Schedule
        {
            get { return _schedule; }
            set { _schedule = value; RaisePropertyChanged(() => Schedule); }
        }

        private string _remark = string.Empty;
        public string Remark
        {
            get { return _remark; }
            set { _remark = value; RaisePropertyChanged(() => Remark); }
        }

        private int _status;
        public int Status
        {
            get { return _status; }
            set { _status = value; RaisePropertyChanged(() => Status); }
        }
    }
}
