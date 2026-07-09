namespace LC1;

public class TwoSumTests
{
    public static IEnumerable<object[]> NoInputData => [
        [
            new int[]{ },
            0,
            (0, new int[] {})
        ]
    ];

    [Theory]
    [MemberData(nameof(NoInputData))]
    public void NoInput(int[] input, int target, (int total, int[] indexes) expectations)
        => Validate(input, target, expectations);

    public static IEnumerable<object[]> SingleInputData => [
        [
            new int[]{ 1 },
            0,
            (0, new int[] { 1 })
        ]
    ];

    [Theory]
    [MemberData(nameof(SingleInputData))]
    public void SingleInput(int[] input, int target, (int total, int[] indexes) expectations)
        => Validate(input, target, expectations);

    public static IEnumerable<object[]> RegularInputData => [
        [
            new[] { 2, 7, 11, 15 },
            9,
            (2, new[] { 0, 1 })
        ]
    ];

    [Theory]
    [MemberData(nameof(RegularInputData))]
    public void RegularInput(int[] input, int target, (int total, int[] indexes) expectations)
        => Validate(input, target, expectations);

    public static IEnumerable<object[]> LargeInputData => [
        [
            new[] { 2, 7, 11, 15, 19, 24, 29, 35, 42, 58 },
            35,
            (2, new[] { 2, 5 })
        ]
    ];

    [Theory]
    [MemberData(nameof(LargeInputData))]
    public void LargeInput(int[] input, int target, (int total, int[] indexes) expectations)
        => Validate(input, target, expectations);

    public static IEnumerable<object[]> MiddleInputData => [
        [
            new[] { 2, 7, 11, 15, 19, 24, 29, 35, 42, 58 },
            43,
            (2, new[] { 4, 5 })
        ]
    ];

    [Theory]
    [MemberData(nameof(MiddleInputData))]
    public void MiddleInput(int[] input, int target, (int total, int[] indexes) expectations)
        => Validate(input, target, expectations);

    private void Validate(int[] input, int target, (int total, int[] indexes) expectations)
    {
        // Act
        int[] results = Problems.LC1.TwoSum(input, target);

        // Assert
        Assert.NotNull(results);
        Assert.Equal(expectations.total, results.Length);

        for (int i = 0; i < results.Length; i++)
            Assert.Equal(expectations.indexes[i], results[i]);
    }
}
