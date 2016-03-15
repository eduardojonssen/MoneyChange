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
			//adicionar novos processadores acima desta linha

			foreach (AbstractProcessor processor in processorList) {
				//TODO: implementar logica
			}
		}
	}
}
