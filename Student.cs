using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics {
    class Student {
        public string? name;
        public int age;
        public string? group;

        public Student() { name = "Неизвестно"; age = 18; group = "Неизвестно"; }

        public Student(string name) { this.name = name; age = 18; group = "Неизвестно"; }

        public Student(string name, int age) { this.name = name; this.age = age; group = "Неизвестно"; }

        public Student(string name, int age, string group) { this.name = name; this.age = age; this.group = group; }

        public void PrintInfo() {
            Console.WriteLine($"Имя: {name}, Возраст: {age}, Группа: {group}");
        }

        public bool IsAdult() {
            return age >= 18;
        }
    }
}