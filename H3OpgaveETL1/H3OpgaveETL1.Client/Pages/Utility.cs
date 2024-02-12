namespace H3OpgaveETL1.Client.Pages
{
    public class Utility
    {
        public static string GetMyCurrentDir()
        {
            //         string saveTo = Directory.GetCurrentDirectory();
            string saveTo = "C:\\Users\\Lucas Lupin Kramhöft\\Source\\H3\\BigData1\\H3OpgaveETL1\\H3OpgaveETL1\\H3OpgaveETL1.Client\\Code\\C02Emission.csv";
            saveTo = Path.Combine(saveTo);
            return saveTo;
        }
    }
}
