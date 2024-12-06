/*
 Дан отсортированный массив чисел. Нужно вернуть отсортированный массив квадратов этих чисел.

Input: nums = [-3, -1, 0, 1, 1, 6, 12, 20]
Output: squares = [0, 1, 1, 1, 9, 36, 144, 400]
*/

int[] array = [-3, -1, 0, 1, 1, 6, 12, 20];

Console.WriteLine(string.Join(",", GetSquares(array)));

int[] GetSquares(int[] input)
{
    int[] result = new int[input.Length];
    
    int leftIndex = 0;
    int rightIndex = input.Length - 1;
    int leftValue = 0;
    int rightValue = 0;

    int outputIndex = rightIndex;

    while (leftIndex != rightIndex)
    {
        leftValue = input[leftIndex] * input[leftIndex];
        rightValue = input[rightIndex] * input[rightIndex];

        if (rightValue >= leftValue)
        {
            result[outputIndex--] = rightValue;
            rightIndex--;
        }
       
        if (rightValue <= leftValue)
        {
            result[outputIndex--] = leftValue;
            leftIndex++;
        }
    }

    return result;
}