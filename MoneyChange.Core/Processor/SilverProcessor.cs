using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyChange.Core.Processor {
	internal class SilverProcessor : AbstractProcessor {
		public override string GetName() {
			return "Silver";
		}

		internal override List<long> GetUnitsList() {

			List<long> silverList = new List<long>() {
					100000, 50000
				};

			return silverList;
		}
	}
}
