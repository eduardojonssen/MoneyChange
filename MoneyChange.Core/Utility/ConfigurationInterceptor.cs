using Dlp.Framework.Container.Interceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyChange.Core.Utility {
	public class ConfigurationInterceptor : IInterceptor {
		public void Intercept(IInvocation invocation) {

			// TODO: Antes.

			invocation.Proceed();

			// TODO: Depois.
		}
	}
}
