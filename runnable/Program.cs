using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

var benchmark = new NextGreaterElement();
List<int> tmp;

benchmark.Setup();

Console.WriteLine("I/P: [{0}]", string.Join(", ", benchmark.arr));
Console.WriteLine();

Console.WriteLine("O/P: [{0}]", string.Join(", ", benchmark.exp));
Console.WriteLine();

tmp = benchmark.Naive();
Console.WriteLine(string.Join(", ", tmp));
Console.WriteLine("Equal: {0}", tmp.SequenceEqual(benchmark.exp));
Console.WriteLine();

tmp = benchmark.Linq_Naive();
Console.WriteLine(string.Join(", ", tmp));
Console.WriteLine("Equal: {0}", tmp.SequenceEqual(benchmark.exp));
Console.WriteLine();

tmp = benchmark.Monotomic_Stack();
Console.WriteLine(string.Join(", ", tmp));
Console.WriteLine("Equal: {0}", tmp.SequenceEqual(benchmark.exp));
Console.WriteLine();

BenchmarkRunner.Run<NextGreaterElement>();

public class NextGreaterElement
{
    public int[] arr = [];
    public int[] exp = [];

    [GlobalSetup]
    public void Setup()
    {
        //arr = [6, 8, 0, 1, 3];
        //exp = [8, -1, 1, 3, -1];

        //arr = [9, 4, 6, 15, 2];
        //exp = [15, 6, 15, -1, -1];

        //arr = [2, 1, 5, 2, 9];
        //exp = [5, 5, 9, 9, -1];

        arr = [
            100, 1, 99, 2, 98, 3, 97, 4, 96, 5,
            95, 6, 94, 7, 93, 8, 92, 9, 91, 10,
            90, 11, 89, 12, 88, 13, 87, 14, 86, 15,
            85, 16, 84, 17, 83, 18, 82, 19, 81, 20,
            80, 21, 79, 22, 78, 23, 77, 24, 76, 25,
            75, 26, 74, 27, 73, 28, 72, 29, 71, 30,
            70, 31, 69, 32, 68, 33, 67, 34, 66, 35,
            65, 36, 64, 37, 63, 38, 62, 39, 61, 40,
            60, 41, 59, 42, 58, 43, 57, 44, 56, 45,
            55, 46, 54, 47, 53, 48, 52, 49, 51, 50
        ];

        exp = [
            -1, 99, -1, 98, -1, 97, -1, 96, -1, 95,
            -1, 94, -1, 93, -1, 92, -1, 91, -1, 90,
            -1, 89, -1, 88, -1, 87, -1, 86, -1, 85,
            -1, 84, -1, 83, -1, 82, -1, 81, -1, 80,
            -1, 79, -1, 78, -1, 77, -1, 76, -1, 75,
            -1, 74, -1, 73, -1, 72, -1, 71, -1, 70,
            -1, 69, -1, 68, -1, 67, -1, 66, -1, 65,
            -1, 64, -1, 63, -1, 62, -1, 61, -1, 60,
            -1, 59, -1, 58, -1, 57, -1, 56, -1, 55,
            -1, 54, -1, 53, -1, 52, -1, 51, -1, -1
        ];

        //arr = Enumerable.Range(1, 1_000_000).Reverse().ToArray();
        //exp = Enumerable.Repeat(-1, 1_000_000).ToArray();
    }

    [Benchmark]
    public List<int> Naive()
    {
        List<int> output = Enumerable.Repeat(-1, arr.Length).ToList();

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] < arr[j])
                {
                    output[i] = arr[j];
                    break;
                }
            }
        }

        return output;
    }

    [Benchmark]
    public List<int> Linq_Naive()
    {
        List<int> output = new();

        for (int i = 0; i < arr.Length; i++)
        {
            var element = arr
                .Skip(i + 1)
                .Where(a => arr[i] < a)
                .DefaultIfEmpty(-1)
                .First();

            output.Add(element);
        }

        return output;
    }

    [Benchmark]
    public List<int> Monotomic_Stack()
    {
        Stack<int> storage = new();

        List<int> output = Enumerable.Repeat(-1, arr.Length).ToList();

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            while (storage.Count > 0 && storage.Peek() <= arr[i])
                storage.Pop();

            if (storage.Count > 0)
                output[i] = storage.Peek();

            storage.Push(arr[i]);
        }

        return output;
    }
}