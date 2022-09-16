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
            Random rnd = new Random();
            Result result = new Result();
            StringWriter sw = new ();
            Console.SetOut(sw);

            for (var i = 0; i < 100; i++)
            {
                int index = rnd.Next(1, 4);
                if (index == 1)
                {
                    Actions.First();
                }
                else if (index == 2)
                {
                    Actions.Second();
                }
                else if (index == 3)
                {
                    Actions.Third();
                    if (result.Status == false)
                    {
                        Logger.Instance.Log(DateTime.Now, LogType.Error, nameof(Actions.Third) + "/ Action failed by a reason: " + Actions.ErrorMessage);
                    }
                }
                else
                {
                    Console.WriteLine("Error");
                }

                string str = sw.GetStringBuilder().ToString();
                File.WriteAllText("log.txt", str);
            }
        }
    }
}