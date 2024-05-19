using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridWithObservable.Model
{
    internal class Student
    {
        public string Name { get; set; } = String.Empty;
        public int Age { get; set; } = 0;
        public bool isSoccerPlayer { get; set; } = true;


        private Gender thegender;

        public Gender TheGender
        {
            get { return thegender; }
            set { thegender = value; }
        }


        public static ObservableCollection<Student> GetStudents()
        {
            var allStudents = new ObservableCollection<Student>();
            allStudents.Add(new Student() { Name = "John", Age = 45, isSoccerPlayer = true, TheGender = Gender.Male });
            allStudents.Add(new Student() { Name = "Jane", Age = 22, isSoccerPlayer = true, TheGender = Gender.Female });

            return allStudents;

        }


        public enum Gender
        {
            Male, Female
        }
    }
}
