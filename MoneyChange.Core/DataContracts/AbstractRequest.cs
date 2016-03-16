using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyChange.Core.Model {
	
	public abstract class AbstractRequest {

		public AbstractRequest() {
			_validationReport = new List<Report>();
		}

		internal bool IsValid {
			get {
				this._validationReport.Clear();
				this.Validate();
				return (this._validationReport.Any() == false);
			}
		}

		private List<Report> _validationReport;

		internal List<Report> ValidationReport {
			get {
				return _validationReport.ToList();
			}
		}

		protected void AddError(string field, string message) {

			this._validationReport.Add(new Report { Field = this.GetType().Name + "." + field, Message = message });
		}

		protected abstract void Validate();
	}
}
