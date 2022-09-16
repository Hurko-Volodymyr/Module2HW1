namespace Logger_HW1
{
    /// <summary>
    /// Main Program.
    /// </summary>
    public class Starter
    {
        /// <summary>
        /// Starts the App.
        /// </summary>
        public void Run()
        {
            Random rnd = new ();
            Result result = new ();
            StringWriter sw = new ();
            Console.SetOut(sw);

            for (var i = 0; i < 100; i++)
            {
                int index = rnd.Next(1, 4);
                if (index == 1)
                {
                    result = Actions.First();
                }
                else if (index == 2)
                {
                    result = Actions.Second();
                }
                else if (index == 3)
                {
                   result = Actions.Third();
                }
                else
                {
                    Console.WriteLine("Error");
                }

                if (result.Status == false)
                {
                    Logger.Instance.Log(DateTime.Now, LogType.Error, nameof(Actions.Third) + "/ Action failed by a reason: " + result.ErrorMessage);
                }

                string str = sw.GetStringBuilder().ToString();
                File.WriteAllText("log.txt", str);
            }
        }
    }
}