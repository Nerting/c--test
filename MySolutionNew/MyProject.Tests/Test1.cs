using Microsoft.VisualStudio.TestTools.UnitTesting;


[TestClass]
public class MathTests
{
    [TestMethod]
    public void Add_ShouldReturnCorrectSum()
    {
        var result = MathOperations.Add(2.5, 3.5);
        Assert.AreEqual(6.0, result);
    }
    
    
    [TestMethod]
    public void Divide_ShouldReturnCorrectResult()
    {
       
        double a = 10.0;
        double b = 2.0;
        double expected = 5.0;
        
       
        double result = MathOperations.Divide(a, b);
        
        
        Assert.AreEqual(expected, result);
    }
    
    
}