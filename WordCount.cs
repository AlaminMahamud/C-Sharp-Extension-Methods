namespace ExtensionMethods
{
	public static class MyExtensions
	{
		public static int WordCount
		{
			return str.Split(new char[]{' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
		}
	}	
}