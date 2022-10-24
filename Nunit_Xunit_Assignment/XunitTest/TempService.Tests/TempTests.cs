namespace TempService.Tests;

public class UnitTests
{
    [Fact]
    public void TestCTF()
    {
        Temp t = new Temp();
        double Temperature_in_Celsius = 50.0;
        double Temperature_in_Farenheit = t.CTF(Temperature_in_Celsius);

        Assert.Equal(122, Temperature_in_Farenheit);
    }

    [Fact]
    public void TestFTC()
    {
        Temp t = new Temp();
        double Temperature_in_Farenheit = 52.8;
        double Temperature_in_Celsius = t.FTC(Temperature_in_Farenheit);

        Assert.Equal(11.56, Temperature_in_Celsius);
    }
}