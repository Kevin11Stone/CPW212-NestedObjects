using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjectsSample
{
    /// <summary>
    /// Represents an individual student
    /// </summary>
    class Student
    {
        /// <summary>
        /// The legal first and last names
        /// ex. Jane Doe
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// The student's school provided email address
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Student's mailing address
        /// </summary>
        public string HomeAddress { get; set; }

        /// <summary>
        /// The student's Home phone number
        /// </summary>
        public string Phone { get; set; }

    }
}
