using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyChange.Core.Processor {
	internal abstract class AbstractProcessor {

		public virtual string GetName() {
			return this.GetType().Name;
		}

		public virtual IDictionary<long,long> Calculate(long amount){

			IDictionary<long, long> unitDictionary = new Dictionary<long, long>();

			long amountLeft = amount;

			List<long> unitList = this.GetUnitsList();

			foreach (var unit in unitList.OrderByDescending(x => x)) {
				long unitQuantity = amountLeft / unit;
				amountLeft = amountLeft % unit;
				if (unitQuantity > 0) {

					unitDictionary.Add(unit, unitQuantity);
				}
			}

			return unitDictionary;
		
		}
		internal abstract List<long> GetUnitsList();

	}
}
