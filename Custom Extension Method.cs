/// first create a static class
/// carefully write the class access modifier, you will always want your extension methods to be accessible
/// create a static method
/// parameter will be prefixed with this i.e. this Strinig str
/// use using statement to call extension method
/// call them as if they were instance methods
/// first param will always be the object where itself is invoked


namespace CustomExtensions
{
	/// Extension Methods must be defined in a static class
	public static class StringExtension
	{

		/// This is the Extension Method
		/// first parameter takes the "this" modifier
		/// and specifies the type for which the method is defined
		public static int WordCount(this String str)
		{
			return str.Split(new char[]{' ', '.', ','}, StringSplitOptions.RemoveEmptyEntries).Length;
		}
	}

}


namespace ExtensionMethods_Simple
{
	/// Import the Extension Method Namespace
	using CustomExtensions;
	class Program
	{
		static void Main(string[] args)
		{
			string s = "The Quick Brown Fox Jumped over the lazy dog";
			int i = s.WordCount();
			System.Console.WriteLine("WordCount of is {0}", i);
		}
	}
}