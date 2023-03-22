using System;

Console.WriteLine("Finding largest numnber");
int [] k = {3,2,7,6,9,4,8};
int largestNum = 0;
int secondLargestNumber= 0;
foreach (int i in k)
{
	if(i > largestNum)
	{
		secondLargestNumber = largestNum;
		largestNum = i;
	}
	else if(i > secondLargestNumber)
	{
		secondLargestNumber = i;
	}
}

Console.WriteLine("Second largest number in array is : " + secondLargestNumber);