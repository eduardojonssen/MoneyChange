using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyChange.Core.DataContracts {
	public class ChangeData {

		public string Name { get; set; }

		public IDictionary<long, long> ChangeDictionary { get; set; }
	}
}
