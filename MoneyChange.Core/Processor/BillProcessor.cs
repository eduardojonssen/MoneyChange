using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyChange.Core.Processor {
	internal class BillProcessor : AbstractProcessor {

		public override string GetName() {
			return "Bill";
		}

		protected override List<long> GetUnitsList() {

			List<long> billsList = new List<long>() {
					10000, 5000, 2000, 1000, 500, 200
				};

			return billsList;
		}

	}
}
