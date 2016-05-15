class ExtensionMethods
{
	static void Main()
{
	int[] ints = {1,2,3,4,5,6,1,2,3,4};
	ints.OrderBy(g=>g);
	foreach(int i in ints)
{
	Console.WriteLine(i + " ");
}
}

}
