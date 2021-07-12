/*
Program to divide two numbers
*/

import java.lang.*;

class Arithmetic
{
	int Divide(int iNo1, int iNo2)
	{
		int iAns = 0;

		if(iNo2 > iNo1)
		{
			return -1;
		}

		iAns = iNo1/iNo2;

		return iAns;
	}
}

class Main
{
	public static void main(String arg[])
	{
		int iValue1 = 15, iValue2 = 5;
		int iRet = 0;

		Arithmetic aobj = new Arithmetic();

		iRet = aobj.Divide(iValue1,iValue2);

		System.out.println("Division is "+iRet);
	}
}
