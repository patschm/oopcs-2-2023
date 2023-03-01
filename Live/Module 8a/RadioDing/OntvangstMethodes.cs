
namespace RadioDing;

internal class OntvangstMethodes
{
    public static void ViaSMS(string msg)
    {
        Console.WriteLine($"Via SMS ontvangen: {msg}");
    }
    public static void ViaEmail(string msg)
    {
        Console.WriteLine($"Via Email ontvangen: {msg}");
    }
    public static void ViaKabel(string msg)
    {
        Console.WriteLine($"Via Kabel ontvangen: {msg}");
    }
    public static void ViaTelegram(string msg)
    {
        Console.WriteLine($"Via Telegram ontvangen: {msg}");
    }
    public static void ViaPostduif(string msg)
    {
        Console.WriteLine($"Via Postduif ontvangen: {msg}");
    }
    public static void ViaRooksignalen(string msg)
    {
        Console.WriteLine($"Via Rooksignalen ontvangen: {msg}");
    }
}
