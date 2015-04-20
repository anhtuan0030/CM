using CM.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Core.Services
{
    public interface ICourseService
    {
        List<CourseViewModel> SelectListStudent(CourseViewModel ObjectSearch);
        CourseViewModel SelectByKey(decimal? id);
        bool Insert(CourseViewModel ObjectData);
        bool Update(CourseViewModel ObjectData);
    }
}
