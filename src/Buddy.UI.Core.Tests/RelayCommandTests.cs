using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Buddy.UI.Core.Tests
{
	[TestClass]
	public class RelayCommandTests
	{
		[TestMethod]
		public void RelayCommand_Construction_WithoutCanExecuteCanActuallyExecute()
		{
			var count = 0;
			var cmd = new RelayCommand(o => count = (int) o);

			if (cmd.CanExecute())
				cmd.Execute(15);

			Assert.AreEqual(15, count);
		}

		[TestMethod]
		[ExpectedException(typeof (ArgumentNullException))]
		public void RelayCommand_Construction_NullArgumentThrows()
		{
			var cmd = new RelayCommand(null);
		}

		[TestMethod]
		public void RelayCommand_CanExecute_CanExecuteWhenTrue()
		{
			var count = 0;
			var cmd = new RelayCommand(o => count = (int) o, () => true);

			Assert.IsTrue(cmd.CanExecute());
		}

		[TestMethod]
		public void RelayCommand_CanExecute_CanNotExecuteWhenFalse()
		{
			var count = 0;
			var cmd = new RelayCommand(o => count = (int) o, () => false);

			Assert.IsFalse(cmd.CanExecute());
		}
	}
}