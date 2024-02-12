using System.Security.Cryptography.X509Certificates;

namespace App
{
	//Encapulsation of  c# 
	/*class Area
	{
		public double length;
		public double breadth;
		public int height;

		public void Rectangle() => Console.WriteLine("Area of rectangle:"+length*breadth);
		public void Square() => Console.WriteLine("Area of Square"+length*length);
		public void Triangle() => Console.WriteLine("Area of Triangle"+length*breadth*height);


	}*/
	//  Inhertitance of the C#
	// singel and muti-level inhertance 
	/*public class Car
	 {
	 public string Name = "Xuv";

	 public void Sound()
	 {
		 Console.WriteLine("tooooo  ,tooooooooo");
	 }
	 }
	 public class Car2 : Car
	 {
	 public String Name2 = "Tvs";

	  public void Colour() 
	 {
		 Console.WriteLine("Red");
	 }
	 } 
 public class Car3 : Car2
 {

	 public string Name11 = "TATA";



 }
	*/
	/*Whenever a method that is having to same name and different paramter is called method overloading 
	 * and A method that is having parameter same and differnt method name 

	public class Meth
	{
		public String name;
		public void Feel(String Name)
		{

			this.name = Name;
			Console.WriteLine("It feels sooo" + name);
		}
		public void Feel(String Name, int a)
		{

			this.name = Name;
			Console.WriteLine("It feels sooo" + name + "My age is " + a);
		}

		public void Love(String Name, int age)
		{
			Console.WriteLine("This is My name:"+Name);
			Console.WriteLine("This is age"+age);
		}
		public void Love1(String Name, int age){
		Console.WriteLine("This is my name:"+Name);
		Console.WriteLine("This is age"+age);
		
		}
	}

	*/

	// Constructor
      class ConstructorEx
	  {
		String name;
		int Age;

		public ConstructorEx(string name, int age)
		{
			this.name = name;
			Age = age;
			Console.WriteLine("My name is :" +name+"  "+ "age is "+age);
		}
	}





		public class Pro
		{
			static void Main(string[] args)
			{
			ConstructorEx constructorEx	=new ConstructorEx("yashwanth",23);

			}
		}


	
}
	