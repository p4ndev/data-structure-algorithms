namespace LC4;

public static class SecondApproach
{
    public static double Execute(int[] nums1, int[] nums2)
    {
        if (nums1.Length == 0 && nums2.Length == 0)
            return 0;

        bool isTotalEven = false;
        int middle = -1, sum = 0;
        LinkedListNode<int>? current;
        double output = 0, median = 0;
        int[] arr = new int[nums1.Length + nums2.Length];
        bool isFirstLarger = (nums1.Length > nums2.Length);
        int[] remainingItems = (isFirstLarger ? nums2 : nums1);
        LinkedList<int> merged = new(isFirstLarger ? nums1 : nums2);

        foreach (int item in remainingItems)
        {
            current = merged.First;
            while (current is not null)
            {
                if(item < current.Value)
                {
                    if(current.Previous is null || current.Previous.Value > item)
                    {
                        merged.AddBefore(current, item);
                        break;
                    }
                }
                else if (item == current.Value)
                {
                    merged.AddBefore(current, item);
                    break;
                }
                else if (item > current.Value)
                {
                    if(current.Next is null || current.Next.Value > item)
                    {
                        merged.AddAfter(current, item);
                        break;
                    }
                }

                current = current.Next;
            }
        }

        isTotalEven = (merged.Count % 2 == 0);
        middle = (merged.Count / 2);
        arr = merged.ToArray();

        if (isTotalEven)
        {
            sum = (arr[middle - 1] + arr[middle]);
            median = ((double)sum / 2);
            output = Math.Round(median, 5);
        }
        else
            output = (double)arr[middle];

        return output;
    }
}
























/*
 * var nums1 = new int[] { 1, 2, 6, 7 };
var nums2 = new int[] { 2, 2, 2, 2, 4, 4 };
//double expected = 2.0;

// var output = LC4.FirstApproach.Execute(nums1, nums2);
// 2060 / 2099 testcases passed (wrong answers)

var output = LC4.SecondApproach.Execute(nums1, nums2);

//Console.WriteLine(output.ToString("F5"));
//Console.WriteLine(expected.ToString("F5"));

Console.ReadKey();















LinkedList<int>         merged  = new(nums1);


while (current is not null)
{
    Console.Write("{0} ", current.Value);
    current = current.Next;
}

Console.WriteLine(); 
*/