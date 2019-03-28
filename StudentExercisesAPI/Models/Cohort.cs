using System;
using System.Collections.Generic;
using System.Text;

namespace StudentExercisesAPI.Models
{
    public class Cohort
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
        public List<String> StudentList { get; set; } = new List<String>();
        public List<String> InstructorList { get; set; } = new List<String>();
        public List<Instructor> Instructors { get; set; } = new List<Instructor>();
    }
}
