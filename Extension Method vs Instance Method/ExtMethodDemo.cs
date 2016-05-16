//// In this code i am defining three class that implements IMyInterface.cs
/// and then i used those classes to test the Extension Methods

namespace ExtensionMethodsDemo1
{
	using System;
	using Extensions;
	using DefineIMyInterface;


	class A : IMyInterface
	{
		public void MethodB()
		{
			Console.WriteLine("A.MethodB()");
		}
	}

	class B : IMyInterface
	{
		public void MethodB()
		{
			Console.WriteLine("B.MethodB()");
		}

		public void MethodA(int i)
		{
			Console.WriteLine("B.MethodA(int i)");
		}	
	}

	class C : IMyInterface
	{
		public void MethodB()
		{
			Console.WriteLine("C.MethodB()");				
		}

		public void MethodA(object obj)
		{
			Console.WriteLine("C.MethodA()");
		}
	}


	class ExtMethodDemo
	{
		static void Main(string[] args)
		{
			// Declare an Instance Method of Class A, Class B and Class C
			A a = new A();
			B b = new B();
			C c = new C();

			// now for a,b and c i will call the following methods
			// -- Method A with an int Argument
			// -- Method A with an String Argument
			// -- Method B With no Argument


			// now for A
			// -- i will call methodA with an int argument
			// -- i will call methodA with an string argument
			// -- i will call methodB with no argument

			a.MethodA(1); // since there is no signature of a's instance method of "MethodA(int i)" it will call the Extension method
			a.MethodA("hello"); // no signature of a's instance method of "MethodA(string a)" it will call the Extension Method
			a.MethodB();


			// now for B
			// -- i will call methodA with an int argument
			// -- i will call methodA with an string argument
			// -- i will call methodB with no argument

			b.MethodA(1); 
			b.MethodA("hello"); // no signature of b's instance method of "MethodA(string a)" it will call the Extension Method
			b.MethodB();

			
			// now for C
			// -- i will call methodA with an int argument
			// -- i will call methodA with an string argument
			// -- i will call methodB with no argument

			c.MethodA(1); 
			c.MethodA("hello"); 
			c.MethodB();

				
		}
	}
 }