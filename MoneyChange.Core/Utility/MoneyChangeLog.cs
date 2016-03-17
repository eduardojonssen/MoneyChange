using Dlp.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MoneyChange.Core.Utility {
	public class MoneyChangeLog {


		public static void Log(object logObject, string type, [CallerMemberName] string logMethod = "") {

			//Serializer.JsonSerialize();

			var path = @"c:/Logs/MoneyChangeLog.txt";
			if (Directory.Exists(Path.GetDirectoryName(path)) == false) {
				Directory.CreateDirectory(Path.GetDirectoryName(path));
			}

			string serializedObject = Serializer.JsonSerialize(logObject);
			string message = string.Format("{0} | {1} | {2} | {3}", DateTime.UtcNow, type, logMethod, serializedObject); 

			using (StreamWriter writer = new StreamWriter(path, true)) {				
				writer.WriteLine(message);
			}

			var cs = "MoneyChange";
			if (!EventLog.SourceExists(cs)) {
				EventLog.CreateEventSource(cs, "Application");
			}

			EventLog.WriteEntry(cs, message, EventLogEntryType.Error);
		}
	}
}
