namespace Logger_HW1
{
    /// <summary>
    /// Main Program.
    /// </summary>
    public sealed class Logger
    {
        private static readonly Logger InstanceValue = new ();
        private readonly List<string> logs = new ();

        static Logger()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Logger"/> class.
        /// </summary>
        public Logger()
        {
        }

        /// <summary>
        /// Gets starts the App.
        /// </summary>
        public static Logger Instance
        {
            get
            {
                return InstanceValue;
            }
        }

        /// <summary>
        /// Write logs.
        /// </summary>
        /// <param name="time">time.</param>
        /// <param name="logType">type.</param>
        /// <param name="message">message.</param>
        public void Log(DateTime time, LogType logType, string message)
        {
            string fullMessage = $" {time}, {logType}, {message}";
            Console.WriteLine(fullMessage);
            this.logs.Add(fullMessage);
        }

        /// <summary>
        /// Write logs.
        /// </summary>
        /// <returns>List.</returns>
        public List<string> GetLogs()
        {
            return this.logs;
        }
    }
}