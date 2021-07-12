/*
Program to divide two numbers
*/

using System;

class Arithmetic
{
	public
	
	int Divide(int iNo1, int iNo2)
	{
		int iAns = 0;

		if(iNo2 == 0)
		{
			return -1;
		}

		iAns = iNo1/iNo2;

		return iAns;
	}
}

class main
{
	static void Main(string[] Arg)
	{
		int iValue1 = 15, iValue2 = 5;

		int iRet = 0;

		Arithmetic aobj = new Arithmetic();

		iRet = aobj.Divide(iValue1,iValue2);

		Console.WriteLine("Division is "+iRet);
	}
}
