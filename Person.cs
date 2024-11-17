using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Биохимический_анализ_крови
{
	public class Person
	{
		public int PatientID;
		public string PIN; //Personal identification number
		public string Name;
		public string Surname;
		public string Patronymic;
		public string Birthday;
		public string Address;
		public string Phone_number;

		public Person(int ID,string pin,string name,string surname,string patron,string birth,string add,string Phnum)
		{
			PatientID = ID;
			PIN = pin;
			Name = name;
			Surname = surname;
			Patronymic= patron;
			Birthday = birth;
			Address = add;
			Phone_number = Phnum;
		}
		public Person() { }
	}
}
