using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Cirrious.MvvmCross.WindowsPhone.Views;
using CM.Core.ViewModels;
using CM.Core.Services;

namespace CM.WinPhone.Views
{
    public partial class ListTeacherView : MvxPhonePage
    {
        public ListTeacherView()
        {
            InitializeComponent();
        }

        private void teacherListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var id = ((Teachers)teacherListBox.SelectedItem).TeacherId;
                ((ListTeacherViewModel)this.DataContext).ShowTeacherDetail(id);
        }



     

        private void MyInfo_Click(object sender, EventArgs e)
        {
            
            ((ListTeacherViewModel)this.DataContext).ShowStudentDetail("ndlongphi");
        }

        private void IntoLogin_Click(object sender, EventArgs e)
        {
            ((ListTeacherViewModel)this.DataContext).GotoLogin();
        }
    }
}