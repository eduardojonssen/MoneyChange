using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyChange.Core.Processor {
	internal class CandyProcessor : AbstractProcessor {
		public override string GetName() {
			return "Candy";
		}

		internal override List<long> GetUnitsList() {

			List<long> candyList = new List<long>() {
					3, 1
				};

			return candyList;
		}
	}
}
