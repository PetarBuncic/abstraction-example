using System;

namespace Apstract_Class_Interface
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            Person [] persons = new Person[3];
            persons[0]=new Employee("Petar");
            persons[1]=new Employee("Bogdan");
            persons[2]=new Contractor("Drina");

            foreach(Person p in persons){
                p.promote(34);
            } 
        }
    }
    public class Employee : Person{

        public Employee(String name):base(name){}
        
       
        public override Boolean incresePay(int percent){
            Console.WriteLine($"Selary is increse for {percent} % "+getName());
            return true;


        }
    }
    public class Contractor : Person {

        public Contractor(String name): base(name){}

        public override Boolean incresePay(int percent){
            if(percent>30){
            Console.WriteLine($"This method is from contructor i can not increse pay for {percent} % "+getName());
            return false;
            }
            else{
               Console.WriteLine($"This method is from contructor i can not increse pay for {percent} % "+getName()); 
               return true;
            }
        }

    }

}
