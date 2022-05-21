using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consult
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList list = new ArrayList();
            //Console.WriteLine(list.Capacity);//размер пустого list
            //list.Add(123);
            //Console.WriteLine(list.Capacity);//размер list Add(123);
            //Console.WriteLine(list.Count);//колличество элементов в list
            //list.Add("Hello world");
            //list.Add(123.1);
            //list.Add("C");
            //list.Add(true);
            //list.Add(new Student());
            //list.Add(new Person());
            //Console.WriteLine($"После добавления элементов {list.Capacity}, {list.Count}");
            //Student student = new Student { Gpa = 4, Name = "Siko" };
            //Person person = new Student { Gpa = 10, Name = "okis" };
            //// ВСЕ НАСЛЕДУЕТСЯ ОТ Object
            //foreach (var item in list)
            //{
            //    if(item is Student)//проверка на преобразование object v student
            //    {
            //        Console.WriteLine(((Student)item).Gpa = 5);
            //        Console.WriteLine((item as Student).Gpa = 10);
            //    }
            //}

            //Console.WriteLine(new String('-', 100));

            //List<Student> students = new List<Student>() //круглые скобки это конструктор по умолчанию
            //{
            //    new Student{Name = "Amina", Gpa = 5},
            //    new Student{Name = "Sabit", Gpa = 4}
            //};
            //foreach (Student item in students)
            //{
            //    Console.WriteLine(item.Name);
            //    Console.WriteLine(item.Gpa);
            //}

            //List<Job> jobs = new List<Job>
            //{
            //    new Job("Sabur", "FOX", 33, true),
            //    new Job("Sabur2", "FOX2", 34, false),
            //    new Job("Sabur3", "FOX3", 35, true)
            //};
            //foreach (Job item in jobs)
            //{
            //    Console.WriteLine(item);

            //}


            //Hashtable

            //Hashtable hashtable = new Hashtable();
            //hashtable.Add("Madiyr", "Teacher");
            //hashtable.Add("Saba", "Student");
            //hashtable.Add("Amina", "Student");
            ////hashtable.Add("Amina", "Worker");//ключи не должны повторятся
            //var value = hashtable["Saba"];
            //Console.WriteLine(value);
            //foreach (var item in hashtable.Keys)
            //{
            //    Console.WriteLine(item);//выводит имена
            //}
            //foreach (var item in hashtable.Values)
            //{
            //    Console.WriteLine(item);//выводит значение
            //}


            //Console.WriteLine(hashtable.ContainsKey("Amina")); //bool проверяет есть ли такой ключ
            //Console.WriteLine(hashtable.ContainsValue("Student")); //bool проверяет есть ли такое значение



            //Dictionary
            Dictionary<string, int> dict = new Dictionary<string, int>()
            {
                {"qqq", 111 },
                {"www", 222 },
                {"eee", 333 }
            };
            try
            {
                dict.Add("qqq", 111);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}, {item.Value}");
            }

            dict.Remove("qqq");//удалить

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}, {item.Value}");
            }
            Console.WriteLine("Program ended");
            
            








        }
    }
    class Person 
    {
        private string _name { get; set; }
        //private string _surName { get; set; }

        public void SetName(string value) 
        {
            if(value != "BadWord")
            {
                _name = value;
            }
        }
        public string GetName()
        {
            if(_name == null)
            {
                return _name;
            }
            return "Имя не задано!";
        }

        private string _surName;

        public string SurName
        {
            get 
            {
                if (_surName == null)
                {
                    return _surName;
                }
                return "Фамилия не задана!";
            }
            set 
            {
                if (value != "BadWord")
                {
                    _surName = value;
                }
            }
        }
        private int _age;

        public int Age
        {
            get 
            {
                if( _age != 0)
                {
                    return _age;
                }
                return 1;// "Возраст не задан";
            }
            set 
            { 
                if(value < 0 || value > 100)
                _age = value; 
            }
        }


    }
    class Student : Person 
    {
        public double Gpa { get; set; } //оценка
    }
    class Job : Person
    {
        public string SurName { get; set; }
        public int Age  { get; set; }
        public bool Sex  { get; set; }

        public Job() { }
        public Job(string name, string surName, int age, bool sex) 
        {
            Name = name;
            SurName = surName;
            Age = age;
            Sex = sex;
        }
        public override string ToString() =>
            Sex ? $"Это мужчина, с именем {Name} и фамилией {SurName}, возрастом {Age}" : $"Это женщина, с именем {Name}и фамилией {SurName}, возрастом {Age}";
        //{
        //    return Sex ? $"Это мужчина, с именем {Name} и фамилией {SurName}, возрастом {Age}"
        //                : $"Это женщина, с именем {Name}и фамилией {SurName}, возрастом {Age}";
        //    //if (Sex)
        //    //{
        //    //    return $"Это мужчина, с именем {Name} и фамилией {SurName}, возрастом {Age}";
        //    //}
        //    //return $"Это женщина, с именем {Name}и фамилией {SurName}, возрастом {Age}";
        //}

    }
}
