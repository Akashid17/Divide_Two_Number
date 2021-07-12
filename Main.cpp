/*
Program to divide two numbers
*/

#include<iostream>
using namespace std;

class Arithmetic
{
	public:
		int Divide(int,int);
};

int Arithmetic::Divide(int iNo1, int iNo2)
{
	if(iNo2 == 0)
	{
		return 0;
	}

	return(iNo1/iNo2);
}

int main(int argc, char const *argv[])
{
	int iValue1 = 15, iValue2 = 5;

	Arithmetic dobj;

	int iAns = dobj.Divide(iValue1,iValue2);

	cout<<iAns<<endl;

	return 0;
}
