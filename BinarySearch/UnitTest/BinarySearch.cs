namespace UnitTest;

public class UnitTest1
{
    [Fact]
    public void BinarySearch_ElementExist_ReturnCorrectIndex()
    {
        var list = new List<int>() { 1, 3, 5, 6, 9 };
        var index = BinarySearch(list, 3);
        Assert.Equal(1, index);
    }
    
    [Fact]
    public void BinarySearch_ElementNotExist_ReturnNull()
    {
        var list = new List<int>() { 1, 3, 5, 6, 9 };
        var index = BinarySearch(list, 4);
        Assert.Null(index);
    }
    
    private int? BinarySearch(IList<int> list, int element)
    {
        var low = 0;
        var high = list.Count() - 1;
    
        while (low <= high)
        {
            var medium = (low + high) / 2;
            var guess = list[medium];
            if (guess.Equals(element))
                return medium;
        
            if (guess > element)
                high = medium - 1;
            else
                low = medium + 1;
        }

        return null;
    }  
}