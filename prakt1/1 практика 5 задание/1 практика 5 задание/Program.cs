using System;

using System.Collections.Generic;

using System.Text;



namespace _1_практика_5_задание

{

    class Program

    {

        static void Main(string[] args)

        {

            Manager p = new Manager("Tony", "Allen", 32, Person.Genders.Male, "+79160809398", "Óëèöà Ïóøêèíà, äîì Êîëîòóøêèíà");

            Console.WriteLine(p.ToString());

            Console.ReadKey();

        }



        public class Person

        {

            public string firstName;

            public string lastName;

            public int age;

            public Genders gender;



            public Person(string _firstName, string _lastName, int _age, Genders _gender)

            {

                firstName = _firstName;

                lastName = _lastName;

                age = _age;

                gender = _gender;

            }



            public override string ToString()

            {

                return firstName + " " + lastName + " (" + gender + "), age " + age;

            }



            public enum Genders : int { Male, Female };

        }



        public class Manager : Person

        {

            public string PhoneNumber;

            public string OfficeLocation;

            public Manager(string _firstName, string _lastName, int _age, Genders _gender, string

            _phoneNumber, string _officeLocation) : base(_firstName, _lastName, _age, _gender)

            {

                PhoneNumber = _phoneNumber; OfficeLocation = _officeLocation;

            }

            public override string ToString()

            {

                return base.ToString() + ", " + PhoneNumber + ", " + OfficeLocation;

            }



        }

    }

}