using System;
using System.Collections.Generic;
using CleanArch.Application.ViewModels;
using System.Text;

namespace CleanArch.Application.Interfaces
{
    public interface ICourseService
    {
        public CourseViewModel GetCourses();
    }
}
