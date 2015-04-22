using Parse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Core.Services
{
    public class StudentService : IStudentService
    {
         private const string AppKey = "HBRj11q16Ma3RjHgYbEkvlqCJXf9M6ukw0jJcfsT";
        private const string AppRestKey = "qRht3wqVKvISvnsm20Z2K960dqZfn9cBBa4fxl00";
        private const string DotNetKey = "HwCpVJvemedpvSIIYTve46Yp6QIkRQ9xirYfzHaV";


        public StudentService()
        {
            ParseObject.RegisterSubclass<Student>();
            ParseClient.Initialize(AppKey, DotNetKey);
        }



        public Task<Student> GetByUserName(string userName)
        {
            //Student objx = new Student
            //{
            //    FullName = "Nguyễn Đỗ Long Phi",
            //    Description = "Test Insert student",
            //    StudentId = 69,
            //    UserName = "ndlongphi",
            //    DOB = DateTime.Now,
            //    ImagePath = "http://linkhay2.vcmedia.vn/thumbs/avatars/user_uploaded/SupperMen2_120.jpg",
            //    PhoneNumber = "01688888888"
            //};
            //objx.SaveAsync();
            var query3 = from student in new ParseQuery<Student>() where student.UserName == "ndlongphi" select student;

            var result = query3.FirstAsync();
            return result;
        }

        public void InsertItem()
        {
            Student objx = new Student
            {
                FullName = "Nguyễn Đỗ Long Phi",
                Description = "Test Insert student",
                StudentId = 69,
                UserName = "ndlongphi",
                DOB = DateTime.Now,
                ImagePath = "http://linkhay2.vcmedia.vn/thumbs/avatars/user_uploaded/SupperMen2_120.jpg",
                PhoneNumber = "01688888888"
            };
            objx.SaveAsync();
        }
    }

    [ParseClassName("Student")]
    public class Student : ParseObject
    {


        [ParseFieldName("StudentId")]
        public int StudentId
        {
            get { return GetProperty<int>(); }
            set { SetProperty<int>(value); }
        }
        [ParseFieldName("UserName")]
        public string UserName
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }

        [ParseFieldName("Password")]
        public string Password
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }

        [ParseFieldName("FullName")]
        public string FullName
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }

        [ParseFieldName("DOB")]
        public DateTime DOB
        {
            get { return GetProperty<DateTime>(); }
            set { SetProperty<DateTime>(value); }
        }

        [ParseFieldName("ImagePath")]
        public string ImagePath
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }

        [ParseFieldName("Email")]
        public string Email
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }


        [ParseFieldName("PhoneNumber")]
        public string PhoneNumber
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }

        [ParseFieldName("Description")]
        public string Description
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }
    }
}
