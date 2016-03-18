using MoneyChange.Core.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyChange.Test.Mocks {
	public sealed class ConfigurationUtilityMock : IConfigurationUtility {

		public bool IsLogEnabled {
			get { return true; }
		}

		public string MoneyChangeLogPath {
			get { return @"C:\logs\test\test.log"; }
		}

		public string MoneyChangeLogType {
			get { return "File"; }
		}
	}
}
