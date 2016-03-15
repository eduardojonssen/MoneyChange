using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyChange.Core.Processor {
	internal class CoinProcessor : AbstractProcessor {

		public CoinProcessor() {}

		public override string GetName() {
			return "Coin";
		}

		protected override List<long> GetUnitsList() {

			List<long> coinsList = new List<long>() {
					100, 50, 25, 10, 5, 1
				};

			return coinsList;
		}

	}
}
