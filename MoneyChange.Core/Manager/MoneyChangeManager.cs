using MoneyChange.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyChange.Core.Processor;


namespace MoneyChange.Core {
	public class MoneyChangeManager {
		public CalculateChangeResponse CalculateChange(CalculateChangeRequest request) {

			CalculateChangeResponse response = new CalculateChangeResponse();

			try {
				// Verifica se os dados recebidos são válidos.
				if (request.IsValid == false) {
					response.OperationReport = request.ValidationReport;
					return response;
				}

				long changeAmount = request.PaidAmountInCents - request.ProductAmountInCents;

				BillProcessor billProcessor = new BillProcessor();
				IDictionary<long, long> numberOfBills = billProcessor.Calculate(changeAmount);

				response.NumberOfBillsByValue = numberOfBills;

				long amountInBills = 0;
				foreach (KeyValuePair<long, long> kv in numberOfBills) {
					amountInBills += kv.Key * kv.Value;
				}

				long remainingChangeAmount = changeAmount - amountInBills;

				if (remainingChangeAmount != 0) {
					
					CoinProcessor coinProcessor = new CoinProcessor();
					IDictionary<long, long> numberOfCoins = coinProcessor.Calculate(remainingChangeAmount);
					response.NumberOfCoinsByValue = numberOfCoins;
				}

				response.TotalAmount = changeAmount;

				response.Success = true;

			}
			catch (Exception ex) {
				response.OperationReport.Add(new Report { Field = "", Message = "Não foi possível processar sua solicitação, por favor tente novamente." });
				throw;
			}

			return response;

		}


	}
}
