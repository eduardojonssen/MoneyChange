using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoneyChange.Core;
using MoneyChange.Core.Model;
using Dlp.Framework.Container;
using MoneyChange.Core.Utility;
using MoneyChange.Test.Mocks;

namespace MoneyChange.Test {
	[TestClass]
	public class MoneyChangeManagerTest {
		[TestMethod]
		public void CalculateChange_Test() {

			IocFactory.Register(
					Component.For<IConfigurationUtility>()
					.ImplementedBy<ConfigurationUtilityMock>()
				);

			MoneyChangeManager manager = new MoneyChangeManager();

			CalculateChangeRequest request = new CalculateChangeRequest();

			request.PaidAmountInCents = 1000;
			request.ProductAmountInCents = 500;

			CalculateChangeResponse response = manager.CalculateChange(request);

			Assert.IsNotNull(response);
			Assert.IsTrue(response.Success);
			Assert.IsNotNull(response.ChangeDataList);
			Assert.AreEqual(1, response.ChangeDataList.Count);

		}
	}
}
