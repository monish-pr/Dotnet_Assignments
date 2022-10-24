namespace TempService.Tests;

public class Tests
{
    private Temp? TempCalc { get; set; }

    [SetUp]
    public void Setup()
    {
        TempCalc = new Temp(); 
    }

    [Test]
    public void TestCTF()
    {
        double temp_in_C = 50.0;
        double temp_in_F = TempCalc.CTF(temp_in_C);
        Assert.AreEqual(122,temp_in_F);
    }

    [Test]
    public void TestFTC()
    {
        double temp_in_F = 52.8;
        double temp_in_C = TempCalc.FTC(temp_in_F);
        Assert.AreEqual(11.56, temp_in_C);
    }
}