using System;

namespace Apstract_Class_Interface{

        public abstract class Person {

            private String name;
            private String adress;  


            public Person (String name){
                this.name=name;

            }
            public String getName(){
                return this.name;
            }
            public String changeAdress(String adress){
                return this.adress=adress;
            }
            public void giveDayOff(){
                Console.WriteLine("Day off is givet to Person "+ this.name);
            }
            public void promote(int percentage){
                Console.WriteLine("Promoted Person is "+this.name);
                giveDayOff();
                incresePay(percentage);//coling abstract method that not yet implemented
            }
            public abstract Boolean incresePay(int percent);//we define abstract method
 
    }

}