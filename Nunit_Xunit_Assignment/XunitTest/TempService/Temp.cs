namespace TempService;
public class Temp: ITemp
{
    public double CTF(double Temperature)
    {
        return Math.Round(1.8*(Temperature)+32,2);
    }

    public double FTC(double Temperature)
    {
        return Math.Round((Temperature-32)/1.8,2);
    }   
    
    public static void Main(){
        Temp TempConvert = new Temp();
        Console.WriteLine(TempConvert.CTF(50));
        Console.WriteLine(TempConvert.FTC(52.8));
    }
}
