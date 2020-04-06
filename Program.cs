using System;

namespace HW_04_04_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Sulton = new Employee("Sulton","Qodirov",1);
        }
    }
    class Employee{
        public string name{get;set;}
        public string lastName{get;set;}
        private int Experience;
        public int experience{
            get{
                return Experience;
            }
            set{
                if(value>=0&&value<=50)Experience=value;
            }
        }
        public int salary = 0;
        public int tax;
        public string position;

        public Employee(string name,string lastName,int experience){
            this.name = name;
            this.lastName = lastName;
            this.experience = experience;
            checkTheExpersiens(experience);
            inputInfo();
        }

        public void checkTheExpersiens(int i){
            if(i<=2&&i>=0){
                position = "Junior";
                salary = 1500;
            }else if(i>=3&&i<=4){
                position = "Middle";
                salary = 2500;
            }else if(i>=5&&i<=7){
                position = "Senior";
                salary = 4000;
            }else if(i<=7&&i>=9){
                position = "Team Leader";
                salary = 5000;
            }else if(i>10){
                position = "Project Manager";
                salary = 6000;
            }
            tax = ((salary*13)/100)+((salary*1)/100);

        }


        public void inputInfo(){
            System.Console.WriteLine("Имя: "+name);
            System.Console.WriteLine("Фамилия: "+lastName);
            System.Console.WriteLine("Должность: "+position);
            System.Console.WriteLine("Полная Зарплата: "+salary);
            System.Console.WriteLine("Налог 13% и +1% пенсионный фонд: "+ tax);
            System.Console.WriteLine("Зарплата к выплате: "+(salary-tax));
        }


        
    }
}
