using System;
using MyLibrary;

namespace MyApplication
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			MyClass test = new MyClass (){ MyName="Steven"};
			Console.WriteLine ("Hello {0}!", test.MyName);
		}
	}
}
