﻿using System.Collections.Generic;

namespace StudentExercisesAPI.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public int CohortId { get; set; }
        public string CohortName { get; set; }
        public Cohort Cohort { get; set; }
        public List<Exercise> Exercises { get; set; } = new List<Exercise>();
        public List<Exercise> StudentList { get; set; } = new List<Exercise>();
    }
}
