using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Core.Services
{
    public class StudentService: IStudentService 
    {
        public List<ViewModels.StudentViewModel> SelectListStudent(ViewModels.StudentViewModel ObjectSearch)
        {
            throw new NotImplementedException();
        }

        public ViewModels.StudentViewModel SelectByKey(decimal? id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(ViewModels.StudentViewModel ObjectData)
        {
            throw new NotImplementedException();
        }

        public bool Update(ViewModels.StudentViewModel ObjectData)
        {
            throw new NotImplementedException();
        }
    }
}
