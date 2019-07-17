﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjectsSample
{
    /// <summary>
    /// Represents an individual instructor
    /// </summary>
    class Instructor
    {
        public Instructor()
        {
            CourseLoad = new List<Course>();
        }


        /// <summary>
        /// The offical @student.cptc.edu work email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The location of the office in building/room format
        /// ex. B11R112
        /// </summary>
        public string OfficeLocation { get; set; }

        /// <summary>
        /// The 4 digit extension
        /// </summary>
        public string OfficePhone { get; set; }

        /// <summary>
        /// The first and last name
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// The courses the instructor is currently teaching
        /// </summary>
        public List<Course> CourseLoad { get; set; }

        // won't use this, instead just added another constructor to
        // ensure CourseLoad isn't null
        public void AddCourse( Course c )
        {
            if (CourseLoad == null)
            {
                CourseLoad = new List<Course>();
            }
            CourseLoad.Add(c);
        }


    }
}
