using Dlp.Framework;
using Dlp.Framework.Container;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MoneyChange.Core.Utility {

	public class MoneyChangeLog {

		public static void Log(object logObject, string type, [CallerMemberName] string logMethod = "") {

			IConfigurationUtility configurationUtility = IocFactory.Resolve<IConfigurationUtility>();

			if (configurationUtility.IsLogEnabled == false) { return; }

			string serializedObject = Serializer.JsonSerialize(logObject);
			string message = string.Format("{0} | {1} | {2} | {3}", DateTime.UtcNow, type, logMethod, serializedObject);

			if (configurationUtility.MoneyChangeLogType.Equals("EventViewer", StringComparison.OrdinalIgnoreCase)) {
				var cs = "MoneyChange";
				if (!EventLog.SourceExists(cs)) {
					EventLog.CreateEventSource(cs, "Application");
				}

				EventLog.WriteEntry(cs, message, EventLogEntryType.Error);
			}
			else if (configurationUtility.MoneyChangeLogType.Equals("File", StringComparison.OrdinalIgnoreCase)) {

				var path = configurationUtility.MoneyChangeLogPath;

				if (Directory.Exists(Path.GetDirectoryName(path)) == false) {
					Directory.CreateDirectory(Path.GetDirectoryName(path));
				}
				using (StreamWriter writer = new StreamWriter(path, true)) {
					writer.WriteLine(message);
				}
			}
		}
	}
}
