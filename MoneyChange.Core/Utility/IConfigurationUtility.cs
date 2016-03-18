using System;
namespace MoneyChange.Core.Utility {
	
	public interface IConfigurationUtility {
		bool IsLogEnabled { get; }
		string MoneyChangeLogPath { get; }
		string MoneyChangeLogType { get; }
	}
}
