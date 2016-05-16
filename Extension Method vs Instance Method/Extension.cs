namespace Extensions
{
	using System;
	using DefineIMyInterface;

	/// The following Extension methods can be accessed by the instance of 
	/// any class that implements IMyInterface

	public static class Extension
	{
		public static void MethodA(this IMyInterface myInterface, int i)
		{
			Console.WriteLine("Extension.MethodA(this IMyInterface myInterface, int i)");

		}

		public static void MethodA(this IMyInterface myInterface, string s)
		{
			Console.WriteLine("Extension.MethodA(this IMyInterface myInterface, string s)");
		}
		
		/// This method is never called in ExtensionMethodDemo, becaues each of the three classes A,B and C implements a method named MethodB
		/// that has a matching Signature

		public static void MethodB(this IMyInterface myInterface)
		{
			Console.WriteLine("Extension.MethodB(this IMyInterface myInterface)");
		}

	}

}