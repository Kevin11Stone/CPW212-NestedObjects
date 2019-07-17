using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjectsSample
{
    /// <summary>
    /// Represents a single college course
    /// </summary>
    class Course
    {
        /// <summary>
        /// Creates a course object with an empty student roster
        /// Constructor that prevents a null-reference exception. 
        /// </summary>
        public Course()
        {
            Roster = new List<Student>();
        }

        /// <summary>
        /// The unique course number
        /// ex. CPW 212
        /// </summary>
        public string CourseNumber { get; set; }

        /// <summary>
        /// The official course title
        /// ex. Advanced .NET
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The number of college credits received for
        /// completing the course successfully
        /// </summary>
        public byte NumberOfCredits { get; set; }

        /// <summary>
        /// The offical course description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The students currently enrolled in the course
        /// </summary>
        public List<Student> Roster { get; set; }

        /// <summary>
        /// What to display
        /// </summary>
        public string CourseDisplay
        {
            get
            {
                return $"{CourseNumber} {Title}";
            }
            // no set, just for display purposes
        }



    }
}
