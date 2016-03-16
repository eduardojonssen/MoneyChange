using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyChange.Core.Processor {

	internal static class ProcessorFactory {

		public static AbstractProcessor Create(long amount) {

			List<AbstractProcessor> processorList = new List<AbstractProcessor>();
			processorList.Add(new BillProcessor());
			processorList.Add(new CoinProcessor());
			processorList.Add(new CandyProcessor());
			processorList.Add(new SilverProcessor());

			//adicionar novos processadores acima desta linha

			foreach (AbstractProcessor processor in processorList.OrderByDescending(x => x.GetUnitsList().Min())) {

				if (amount >= processor.GetUnitsList().Min())
					return processor;
			}

			return null;
		}
	}
}
