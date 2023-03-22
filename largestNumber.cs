using System;

Console.WriteLine("Finding largest numnber");
int [] k = {3,2,7,6,9,4,8};
int largestNum = 0;

foreach (int i in k)
{
	if(i > largestNum)
	{
		largestNum = i;
	}
}

Console.WriteLine("Largest number in array is : " + largestNum);