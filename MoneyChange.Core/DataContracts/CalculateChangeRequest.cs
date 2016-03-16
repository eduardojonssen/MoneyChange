using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyChange.Core.Model {

	public sealed class CalculateChangeRequest : AbstractRequest {

		public CalculateChangeRequest() { }

		public long PaidAmountInCents { get; set; }

		public long ProductAmountInCents { get; set; }

		protected override void Validate() {

			if (this.PaidAmountInCents < 0) {
				AddError("PaidAmountInCents", "Valores informados não podem ser negativos");
			}

			if (this.ProductAmountInCents < 0) {
				AddError("ProductAmountInCents", "Valores informados não podem ser negativos");
			}

			long changeAmountInCents = this.PaidAmountInCents - this.ProductAmountInCents;
			if (changeAmountInCents < 0) {
				AddError("PaidAmountInCents", "Valor pago menor que valor do produto.");
			}
		}
	}
}
