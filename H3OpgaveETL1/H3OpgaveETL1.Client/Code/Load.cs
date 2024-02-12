namespace H3OpgaveETL1.Client.Code
{
    public class Load
    {
        public bool LoadToCsv(string saveTo, string csv)
        {
            bool success = true;
            try
            {
                File.WriteAllText(saveTo, csv);
            }
            catch (Exception e)
            {
                success = false; 
            }

            return success;
        }
 
    }
}
