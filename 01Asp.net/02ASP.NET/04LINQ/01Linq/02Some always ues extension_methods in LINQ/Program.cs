using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _02Some_always_ues_extension_methods_in_LINQ {
    class Program {
        static void Main(string[] args){
            List<Employee> list = new List<Employee>();
            list.Add(new Employee { Id = 1, Name = "jerry", Age = 28, Gender = true, Salary = 5000 });
            list.Add(new Employee { Id = 2, Name = "jim", Age = 33, Gender = true, Salary = 3000 });
            list.Add(new Employee { Id = 3, Name = "lily", Age = 35, Gender = false, Salary = 9000 });
            list.Add(new Employee { Id = 4, Name = "lucky", Age = 16, Gender = false, Salary = 2000 });
            list.Add(new Employee { Id = 5, Name = "kimi", Age = 25, Gender = true, Salary = 1000 });
            list.Add(new Employee { Id = 6, Name = "nancy", Age = 35, Gender = false, Salary = 8000 });
            list.Add(new Employee { Id = 7, Name = "zack", Age = 35, Gender = true, Salary = 8500 });
            list.Add(new Employee { Id = 8, Name = "jack", Age = 33, Gender = true, Salary = 8000 });

            //C#
            var news = list.Where(a => a.Salary > 3000).OrderBy(a => a.Age).Select(a => new { a.Age, a.Name, gender = a.Gender ? "男" : "女" });
            foreach (var item in news){
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine();
            //查询语法
            var news2 = from employee1 in list where employee1.Salary > 3000 select new { employee1.Age, employee1.Name, gender = employee1.Gender ? "男" : "女" };
            foreach (var item in news2){
                Console.WriteLine(item);
            }
            
            

            //链式调用
            var x = list.Where(a => a.Id > 2).GroupBy(a => a.Age).OrderBy(a => a.Key).Take(3).Select(a =>
                new { nianling = a.Key, renshu = a.Count(), avg = a.Average(e => e.Salary) });
            foreach (var VARIABLE in x){
                Console.WriteLine(VARIABLE.nianling);
                Console.WriteLine(VARIABLE.renshu);
                Console.WriteLine(VARIABLE.avg);
            }
            IEnumerable<Employee> itemS = list.Where(a => a.Salary > 6000);
            List<Employee> toList = itemS.ToList();
            Employee[] toArray = itemS.ToArray();

            //max 年龄最大值
            var a = list.Max(a => a.Age);
            Console.WriteLine(a);

            //跳过两条数据，取得三条数据
            var item2 = list.Skip(2).Take(3);
            foreach (Employee employee in item2){
                Console.WriteLine(employee);
            }

            //多条件排序  年龄排序，如果年龄一样，按工资降序
            var item1 = list.OrderBy(a => a.Age).ThenByDescending(a => a.Salary);
            foreach (Employee employee in item1){
                Console.WriteLine(employee);
            }

            //根据名字的最后一个字符排序
            IEnumerable<Employee> lastChar = list.OrderByDescending(a => a.Name[a.Name.Length - 1]);
            foreach (Employee employee in lastChar){
                Console.WriteLine(employee);
            }

            //Random 随机排序
            Random random = new Random();
            IEnumerable<Employee> r1 = list.OrderByDescending(a => random.Next());
            foreach (Employee employee in r1){
                Console.WriteLine(employee);
            }

            //Guild 随机排序
            IEnumerable<Employee>
                g1 = list.OrderByDescending(e => Guid.NewGuid()); //生成一个Guild值，每次都不一样
            foreach (Employee employee in g1){
                Console.WriteLine(employee);
            }

            //Order
            IEnumerable<Employee> o1 = list.OrderBy(e => e.Age); //根据年龄正序排序并返回一个新集合，旧集合不受影响
            foreach (Employee employee in o1){
                Console.WriteLine(employee);
            }
            //OrderByDescending
            IEnumerable<Employee>
                o2 = list.OrderByDescending(e => e.Age); //根据年龄倒叙排序并返回一个新集合，旧集合不受影响
            foreach (Employee employee in o2){
                Console.WriteLine(employee);
            }

            //Single
            Employee e1 = list.Single(); //返回有且仅有的满足条件的一条数据，如果有多条或者没有，报错
            Console.WriteLine(e1);
            //SingleOrDefault
            Employee e2 = list.SingleOrDefault(a => a.Age > 50); //返回有且仅有的满足条件的一条数据，如果没有，则为默认值,多条，报错
            Console.WriteLine(e2);
            //First
            Employee e3 = list.First(a => a.Age > 30); //返回满足条件的所有数据中的第一条，如果一个没有，报错
            Console.WriteLine(e3);
            //FirstOrDefault
            Employee
                e4 = list.FirstOrDefault(a => a.Age > 300); //返回满足条件的所有数据中的第一条，如果一个没有，返回集合中数据默认值

            //where
            IEnumerable<Employee> newList = list.Where(a => a.Age > 20);
            foreach (Employee employee in newList){
                Console.WriteLine(employee);
            }
            //count
            Console.WriteLine(list.Count()); //总数居的条数
            Console.WriteLine(list.Count(a => a.Age > 20)); //满足条件的数据条数
            //Any
            Console.WriteLine(list.Any()); //是否至少有一条数据-true
            Console.WriteLine(list.Any(a => a.Age > 50)); //是否至少有一条数据满足条件-false
        }
    }
    class Employee {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }
        public int Salary { get; set; }
        public override string ToString(){
            return $"Id = {Id},Name = {Name},Age = {Age},Gender = {Gender},Salary = {Salary}.";
        }
    }
}