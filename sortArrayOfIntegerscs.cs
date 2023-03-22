using System;

Console.WriteLine("Sorting array of integers");
int [] k = {3,2,7,6,9,4,8};

for(int i=0; i<k.Length; i++)
{
	for(int j=i; j<(k.Length)-1; j++)
	{
		if(k[j]> k[j+1])
		{
			int temp = k[j];
			k[j] = k[j+1];
			k[j+1] = temp;
			
		}
	}
	
}

Console.Write("Array after sorting : ");	
foreach(int num in k)
{
	Console.Write(num);	
}


