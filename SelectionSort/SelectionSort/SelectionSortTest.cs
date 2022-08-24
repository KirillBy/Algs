using FluentAssertions;

namespace SelectionSort;

public class UnitTest1
{
    [Fact]
    public void SelectionSortTest()
    {
        var arr = new List<int>() { 5, 3, 6, 2, 10 };
        var expectedArr = new List<int>() { 2, 3, 5, 6, 10 };
        
        //Act
        var sortedArr = SelectionSort(arr);
        
        //Assert
        expectedArr.Should().BeEquivalentTo(expectedArr);
        Assert.Equal(expectedArr[0], sortedArr[0]);
        Assert.Equal(expectedArr[4], sortedArr[4]);
    }

    public int[] SelectionSort(List<int> arr)
    {
        var result = new int[arr.Count];
        for (int i = 0; i < result.Length; i++)
        {
            var smallest = FindSmallestIndex(arr);
            result[i] = arr[smallest];
            arr.RemoveAt(smallest);
        }

        return result;
    }

    private int FindSmallestIndex(List<int> arr)
    {
        int smallest = arr[0];
        int smallestIndex = 0;

        for (int i = 0; i < arr.Count; i++)
        {
            if (arr[i] < smallest)
            {
                smallest = arr[i];
                smallestIndex = i;
            }
        }
        
        return smallestIndex;
    }
}