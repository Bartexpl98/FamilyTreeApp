using System;
using System.Collections.Generic;

namespace FamilyTreeApp.Models
{
    public class Person
    {
        public Guid Id { get; set; } = Guid.NewGuid();  
        public string? Name { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public List<Person> Parents { get; set; } = new();
        public List<Person> Children { get; set; } = new();
        public TimeSpan AgeTimeSpan { get; set; }
        public int Age {get;  set;}

        //helper property
        public string Summary => $"{Name} ({DateOfBirth?.ToString("yyyy") ?? "Unknown"})";

        public Person(string name, DateTime? dob = null)
        {
            Name = name;
            DateOfBirth = dob;
            AgeTimeSpan = DateTime.Now - (dob ?? DateTime.Now);
            Age = AgeTimeSpan.Days / 365;
        }

        // Parameterless constructor for serialization/deserialization (could be useful for JSON/XML)
        public Person() { }
    }
}