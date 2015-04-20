using CM.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Core.Services
{
    public interface IStudentService
    {
        List<StudentViewModel> SelectListStudent(StudentViewModel ObjectSearch);
        StudentViewModel SelectByKey(decimal? id);
        bool Insert(StudentViewModel ObjectData);
        bool Update(StudentViewModel ObjectData);
    }
}
