using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get { return DateTime.Now.Year - Birthday.Year; } }
        public DateTime Birthday { get; set; }

        public Student(int id, string name, string surname, DateTime birthday)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Birthday = birthday;
        }

        public override string ToString()
        {
            return $"{Id}-ий студент по списку\n " +
                $"Имя студента {Name}\n " +
                $"Фамилия студента {Surname}\n " +
                $"Дата рождения {Birthday}\n " +
                $"Возраст {Age}\n " +
                $"__________________";
        }
    }
}
