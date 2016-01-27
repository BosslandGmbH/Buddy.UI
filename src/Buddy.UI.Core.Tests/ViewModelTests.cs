using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Buddy.UI.Core.Tests
{
	[TestClass]
	public class ViewModelTests : ViewModel
	{
		private bool _someProperty;
		
		[TestMethod]
		public void ViewModel_SetProperty_WithValueSucceeds()
		{
			SetProperty(ref _someProperty, true);

			Assert.IsTrue(_someProperty);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void ViewModel_SetProperty_ThrowsWithoutValidCaller()
		{
			SetProperty(ref _someProperty, true, string.Empty);
		}
	}
}
