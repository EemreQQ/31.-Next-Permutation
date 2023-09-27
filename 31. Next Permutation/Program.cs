using System.Collections;

public class Solution
{
    public void NextPermutation(int[] nums)
    {
        if (nums.Length == 1)
            foreach (var item in nums)
            {
                Console.Write(item);
                break;
            }
        else
        {
            var Index = 0;
            var counter = 1;
            var number = 0;
            var smaller = -1;
            var temp = 0;
            var i = 0;
            while (nums[nums.Length - 2 - i] >= nums[(nums.Length - 1) - i])
            {
                counter++;
                i++;
                if (i > nums.Length - 2) break;
            }
            if (counter == nums.Length)
            {
                Array.Reverse(nums);

                foreach (var item in nums)
                {
                    Console.Write(item);
                }
            }
            else
            {
                number = nums[nums.Length - 2 - i];
                Index = nums.Length - 2 - i + 1;
                smaller = nums[nums.Length - 2 - i + 1] - number;
                for (int j = nums.Length - 2 - i + 1; j < nums.Length - 2 - i + counter; j++)
                {
                    if (number >= nums[j] || number >= nums[j + 1]) continue;
                    if (smaller > (nums[j + 1] - number))
                    {
                        smaller = nums[j + 1] - number;
                        Index = j + 1;
                    }
                    else
                    {
                        Index = j;
                    }
                }
                temp = nums[nums.Length - 2 - i];
                nums[nums.Length - 2 - i] = nums[Index];
                nums[Index] = temp;

                Array.Sort(nums, nums.Length - 2 - i + 1, counter);

                foreach (var item in nums)
                {
                    Console.Write(item);
                }
            }
        }
    }
static void Main()
    {
        Solution solution = new Solution();
        int[] ints = { 5, 4, 7, 5, 3, 2 }; 
        solution.NextPermutation(ints);
    }

}