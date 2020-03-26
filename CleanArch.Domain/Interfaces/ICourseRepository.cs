﻿using CleanArch.Models.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Interfaces
{
    public interface ICourseRepository
    {
        public IEnumerable<Course> GetCourses();
    }
}
