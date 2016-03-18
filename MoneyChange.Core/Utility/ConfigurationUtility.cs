using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyChange.Core.Utility {

	public sealed class ConfigurationUtility : IConfigurationUtility {

		public ConfigurationUtility() { }

		public string MoneyChangeLogPath {
			get { return ConfigurationManager.AppSettings["MoneyChangeLogPath"]; }
		}

		public string MoneyChangeLogType {
			get { return ConfigurationManager.AppSettings["MoneyChangeLogType"]; }
		}

		public bool IsLogEnabled {
			get {
				return bool.Parse(ConfigurationManager.AppSettings["IsLogEnabled"]);
			}
		}
	}
}
