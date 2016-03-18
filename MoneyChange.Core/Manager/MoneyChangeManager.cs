using MoneyChange.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyChange.Core.Processor;
using MoneyChange.Core.DataContracts;
using MoneyChange.Core.Utility;
using Dlp.Framework.Container;


namespace MoneyChange.Core {
	public class MoneyChangeManager {

		public MoneyChangeManager() {

			IocFactory.Register(
				Component.FromThisAssembly("MoneyChange.Core.Utility")
				);
		}

		public CalculateChangeResponse CalculateChange(CalculateChangeRequest request) {

			MoneyChangeLog.Log(request, "Request");

			CalculateChangeResponse response = new CalculateChangeResponse();

			try {
				// Verifica se os dados recebidos são válidos.
				if (request.IsValid == false) {
					response.OperationReport = request.ValidationReport;
					return response;
				}

				long changeAmount = request.PaidAmountInCents - request.ProductAmountInCents;

				
				long remainingChange = changeAmount;
				List<ChangeData> changeDataList = new List<ChangeData>();
				while (remainingChange != 0) {
					AbstractProcessor processor = Processor.ProcessorFactory.Create(remainingChange);

					if (processor == null) {

						response.Success = false;
						response.OperationReport.Add(new Report() { Field = "", Message = "Não foi possível processar o seu troco." });
						return response;
					}
					
					IDictionary<long, long> processorChange = processor.Calculate(remainingChange);

					ChangeData changeData = new ChangeData() { Name = processor.GetName(), ChangeDictionary = processorChange };
					changeDataList.Add(changeData);

					long processorChangeAmount = processorChange.Sum(x => x.Key * x.Value);
					remainingChange -= processorChangeAmount;
				}
				
				response.TotalAmount = changeAmount;
				response.ChangeDataList = changeDataList;
				response.Success = true;
			}
				
			catch (Exception ex) {
				response.OperationReport.Add(new Report { Field = "", Message = "Não foi possível processar sua solicitação, por favor tente novamente." });
				MoneyChangeLog.Log(ex.ToString(), "Exception");
			}
			finally {
				MoneyChangeLog.Log(response, "Response");
			}

			return response;

		}


	}
}
