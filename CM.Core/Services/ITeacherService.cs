﻿using CM.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Core.Services
{
    public interface ITeacherService
    {
        List<TeacherViewModel> SelectListTeacher(TeacherViewModel ObjectSearch);
        Task<Teachers> SelectTeacherByKey(decimal? id);

        Task<IEnumerable<Teachers>> GetTeachers();
    }
}
