using DeLaSalle.TaxCalculator.App.Taxes;
using DeLaSalle.TaxCalculator.Core.Entities;

namespace DeLaSalle.TaxCalculator.Test;


public class ISRCalculatorServiceShould
{
    
    [Fact]
    public void GetISR_WhenSalaryGreaterThan0_1AndLessThan7735()
    {
        //arrage
        double isrExpected = 115.19980799999999;
        var salary = new Salary { Amount = 6000};
        var sut = new ISRCalculatorService();
        
        //act
        double result = sut.GetISR(salary);
        
        Console.WriteLine(result);
        //assert
        Assert.Equal(isrExpected, result);
    }
    
    [Fact]
    public void GetISR_WhenSalaryGreaterThan7735AndLessThan65651_07()
    {
        //arrage
        double isrExpected = 165.46935999999997;
        var salary = new Salary { Amount = 8000};
        var sut = new ISRCalculatorService();
        
        //act
        double result = sut.GetISR(salary);
        
        Console.WriteLine(result);
        //assert
        Assert.Equal(isrExpected, result);
    }
    
    [Fact]
    public void GetISR_WhenSalaryGreaterThan65651_08AndLessThan115375_90()
    {
        //arrage
        double isrExpected = 7592.302496;
        var salary = new Salary { Amount = 100000};
        var sut = new ISRCalculatorService();
        
        //act
        double result = sut.GetISR(salary);
        
        Console.WriteLine(result);
        //assert
        Assert.Equal(isrExpected, result);
    }
    
    [Fact]
    public void GetISR_WhenSalaryGreaterThan115375_91AndLessThan134119_41()
    {
        //arrage
        double isrExpected = 11605.0544;
        var salary = new Salary { Amount = 130000};
        var sut = new ISRCalculatorService();
        
        //act
        double result = sut.GetISR(salary);
        
        Console.WriteLine(result);
        //assert
        Assert.Equal(isrExpected, result);
    }
    
    [Fact]
    public void GetISR_WhenSalaryGreaterThan134119_42AndLessThan160577_65()
    {
        //arrage
        double isrExpected = 15109.959935999997;
        var salary = new Salary { Amount = 150000};
        var sut = new ISRCalculatorService();
        
        //act
        double result = sut.GetISR(salary);
        
        Console.WriteLine(result);
        //assert
        Assert.Equal(isrExpected, result);
    }
    
    [Fact]
    public void GetISR_WhenSalaryGreaterThan160577_66AndLessThan323862()
    {
        //arrage
        double isrExpected = 25426.081610400004;
        var salary = new Salary { Amount = 200000};
        var sut = new ISRCalculatorService();
        
        //act
        double result = sut.GetISR(salary);
        
        Console.WriteLine(result);
        //assert
        Assert.Equal(isrExpected, result);
    }
    
    [Fact]
    public void GetISR_WhenSalaryGreaterThan323862_01AndLessThan510451()
    {
        //arrage
        double isrExpected = 93310.665248;
        var salary = new Salary { Amount = 500000};
        var sut = new ISRCalculatorService();
        
        //act
        double result = sut.GetISR(salary);
        
        Console.WriteLine(result);
        //assert
        Assert.Equal(isrExpected, result);
    }
    
    [Fact]
    public void GetISR_WhenSalaryGreaterThan510451_01AndLessThan974535_03()
    {
        //arrage
        double isrExpected = 212633.437;
        var salary = new Salary { Amount = 900000};
        var sut = new ISRCalculatorService();
        
        //act
        double result = sut.GetISR(salary);
        
        Console.WriteLine(result);
        //assert
        Assert.Equal(isrExpected, result);
    }
    
    [Fact]
    public void GetISR_WhenSalaryGreaterThan974535_04AndLessThan1299380_04()
    {
        //arrage
        double isrExpected = 243142.7372;
        var salary = new Salary { Amount = 1000000};
        var sut = new ISRCalculatorService();
        
        //act
        double result = sut.GetISR(salary);
        
        Console.WriteLine(result);
        //assert
        Assert.Equal(isrExpected, result);
    }
    
    [Fact]
    public void GetISR_WhenSalaryGreaterThan1299380_05AndLessThan3898140_12()
    {
        //arrage
        double isrExpected = 917155.1230000001;
        var salary = new Salary { Amount = 3000000};
        var sut = new ISRCalculatorService();
        
        //act
        double result = sut.GetISR(salary);
        
        Console.WriteLine(result);
        //assert
        Assert.Equal(isrExpected, result);
    }
    
    [Fact]
    public void GetISR_WhenSalaryGreaterThan3898140_13()
    {
        //arrage
        double isrExpected = 1258173.7145;
        var salary = new Salary { Amount = 4000000};
        var sut = new ISRCalculatorService();
        
        //act
        double result = sut.GetISR(salary);
        
        Console.WriteLine(result);
        //assert
        Assert.Equal(isrExpected, result);
    }
}