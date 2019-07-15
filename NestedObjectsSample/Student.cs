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
        // field created through full implemented property
        private string _fullName;
        private string _emailAddress;

        /// <summary>
        /// Overriding 
        /// </summary>
        /// <param name="fullName"></param>
        public Student(string fullName)
        {
            FullName = fullName;
        }

        /// <summary>
        /// The legal first and last names
        /// ex. Jane Doe
        /// </summary>
        public string FullName
        {
            get { return _fullName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("FullName can't be null or whitespace");
                }
                _fullName = value;
            }
        }

        /// <summary>
        /// The student's school provided email address
        /// </summary>
        public string EmailAddress
        {
            get { return _emailAddress; }
            set
            {
                // maybe use REGEX for more strict validation
                if (value.EndsWith("@student.cptc.edu"))
                {
                    _emailAddress = value;
                }
                else
                {
                    throw new ArgumentException("Email must end with @student.cptc.edu");
                }
            }
        }

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
