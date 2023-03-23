using System;
using System.Collections;

Console.WriteLine("Print the sum of pair in given array");
int [] k = {3,2,7,6,9,4,8};
ArrayList sum_list = new ArrayList();
for(int i=0; i<k.Length; i=i+2)
{
    if(i+1 < k.Length)
    {
    int curr_item = k[i];
    int next_item = k[i+1];
    sum_list.Add(curr_item + next_item);
    }
    else
    {
        sum_list.Add(k[i]);
    }

}

Console.WriteLine("Array after sum : ");	
foreach(int num in sum_list)
{
	Console.WriteLine(num);
}
