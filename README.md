# SortUtility
Hey! I made this simple sortUntility for educational purposes. It serves to briefly teach how a sorting system works in C#.

## How Works

The algorithm compares two numbers in the array reference and checks the larger one. If the previous number is greater it will reverse the positions, until the array is sorted.

## How to Use

Set in SortUtility.Sort() your numbers array. Ex:

int[] numbers  =  new  int[]
{
	1, 7, 9, 6, 3, 9, 11, 4, 5, 3, 23
};

SortUtility.Sort(numbers);

//Output [1, 3, 3, 4, 5, 6, 7, 9, 9, 11, 23]

Console.WriteLine("[{0}]", string.Join(", ", numbers));

Console.ReadKey();
