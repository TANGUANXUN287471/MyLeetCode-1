namespace LeetCode1;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = {3,3, 5,6, 3, 8};
        int target = 6;

        int [] result = Calc(nums, target);
        foreach (var n in result)
        {
            Console.WriteLine(n);
        }
    }

    static int[] Calc(int[] nums, int target)
    {
        int[] arr;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                int result = nums[i] + nums[j];
                if (result == target && i != j)
                {
                    return arr = new int[] { i, j };
                }
            }
        }

        return arr = new int[]{};
    }

    
}
