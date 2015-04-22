using Parse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Core.Services
{
   public class TeacherService :ITeacherService
    {
        private const string AppKey = "HBRj11q16Ma3RjHgYbEkvlqCJXf9M6ukw0jJcfsT";
        private const string AppRestKey = "qRht3wqVKvISvnsm20Z2K960dqZfn9cBBa4fxl00";
        private const string DotNetKey = "HwCpVJvemedpvSIIYTve46Yp6QIkRQ9xirYfzHaV";


        public TeacherService()
        {
            ParseObject.RegisterSubclass<Teachers>();
            ParseClient.Initialize(AppKey, DotNetKey);
        }

        public List<ViewModels.TeacherViewModel> SelectListTeacher(ViewModels.TeacherViewModel ObjectSearch)
        {
            throw new NotImplementedException();
        }


        public ViewModels.TeacherViewModel SelectTeacherByKey(decimal? id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Teachers>> GetTeachers()
        {
            var query3 = new ParseQuery<Teachers>();

            var result = await query3.FindAsync();
            return result;
        }
    }


   [ParseClassName("Teachers")]
   public class Teachers : ParseObject
   {
       [ParseFieldName("TeacherId")]
       public int TeacherId
       {
           get { return GetProperty<int>(); }
           set { SetProperty<int>(value); }
       }

       [ParseFieldName("Fullname")]
       public string Fullname
       {
           get { return GetProperty<string>(); }
           set { SetProperty<string>(value); }
       }

       [ParseFieldName("Username")]
       public string Username
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

       [ParseFieldName("Subject")]
       public string Subject
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

       [ParseFieldName("ImagePath")]
       public string ImagePath
       {
           get { return GetProperty<string>(); }
           set { SetProperty<string>(value); }
       }
   }
}
