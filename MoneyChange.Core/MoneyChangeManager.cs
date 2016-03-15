using MoneyChange.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

				List<long> coinsList = new List<long>() {
					100, 50, 25, 10, 5, 1
				};


				long changeAmountInCents = request.PaidAmountInCents - request.ProductAmountInCents;

				IDictionary<long, long> numberOfCoins = CalculateCoins(coinsList, changeAmountInCents);

				IDictionary<long, long> billList = new Dictionary<long, long>();
				billList.Add(1, 100)
				billList.Add("banana", 200)
				billList.Add(1, 100)
				billList.Add(1, 100);
				IDictionary<long, long> billList = new KeyValuePair<long, long>(12, 4);




				response.NumberOfCoinsByValue = numberOfCoins;
				response.TotalAmount = changeAmountInCents;

				response.Success = true;

			}
			catch (Exception ex) {
				response.OperationReport.Add(new Report { Field = "", Message = "Não foi possível processar sua solicitação, por favor tente novamente." });
				throw;
			}

			return response;

		}

		private IDictionary<long, long> CalculateCoins(List<long> coinsList, long changeAmountInCents) {

			IDictionary<long, long> coinDictionary = new Dictionary<long, long>();

			long amountLeft = changeAmountInCents;

			foreach (var coin in coinsList.OrderByDescending(x => x)) {
				long coinsQuantity = amountLeft / coin;
				amountLeft = amountLeft % coin;
				coinDictionary.Add(coin, coinsQuantity);
			}

			return coinDictionary;
		}

	}
}
