namespace RadioDing;

internal class Program
{
    static void Main(string[] args)
    {
        RadioStation r538 =  new RadioStation();

        r538.Message += OntvangstMethodes.ViaPostduif;
        r538.Message += OntvangstMethodes.ViaSMS;
        r538.Message += OntvangstMethodes.ViaRooksignalen;
        r538.Message += OntvangstMethodes.ViaEmail;
        r538.Message += OntvangstMethodes.ViaTelegram;
        r538.Message += OntvangstMethodes.ViaPostduif;
        r538.Message += OntvangstMethodes.ViaSMS;
        r538.Message += OntvangstMethodes.ViaRooksignalen;
        r538.Message += OntvangstMethodes.ViaEmail;
        r538.Message += OntvangstMethodes.ViaTelegram;
        r538.Message += OntvangstMethodes.ViaPostduif;
        r538.Message += OntvangstMethodes.ViaSMS;
        r538.Message += OntvangstMethodes.ViaRooksignalen;
        r538.Message += OntvangstMethodes.ViaEmail;
        r538.Message += OntvangstMethodes.ViaTelegram;

        r538.Broadcast();
    }
}