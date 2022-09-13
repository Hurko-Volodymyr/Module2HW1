using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger_HW1
{
    /// <summary>
    /// Main Program.
    /// </summary>
    public class Actions
    {
        /// <summary>
        /// Gets or sets starts the App.
        /// </summary>
        public static string? ErrorMessage { get; set; }

        public static Result First()
        {
            Logger.Instance.Log(DateTime.Now, LogType.Info, $"{nameof(First)}");
            return new Result { Status = true };
        }

        public static Result Second()
        {
            Logger.Instance.Log(DateTime.Now, LogType.Warning, $"{nameof(Second)}");
            return new Result { Status = true };
        }

        public static Result Third()
        {
            Logger.Instance.Log(DateTime.Now, LogType.Error, nameof(Third));
            return new Result { Status = false, ErrorMessage = "broken" };
        }
    }
}
