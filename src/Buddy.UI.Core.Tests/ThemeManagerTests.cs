using System;
using System.Windows;
using Buddy.UI.Core.Themes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Buddy.UI.Core.Tests
{
	[TestClass]
	public class ThemeManagerTests
	{
		[TestInitialize]
		public void Setup()
		{
			// Required to register bourgeoise XAML URI schemes
			if (!UriParser.IsKnownScheme("pack"))
				new Application();
		}

		[TestMethod]
		public void ThemeManager_Default_ContainsThemes()
		{
		    var b = ThemeManager.TryGetTheme("BaseDark");

			Assert.IsTrue(b.HasValue && b.Value != null);
		}

		[TestMethod]
		public void ThemeManager_Default_ContainsAccents()
		{
		    var b = ThemeManager.TryGetAccent("Blue");

			Assert.IsTrue(b.HasValue && b.Value != null);
		}
	}
}
