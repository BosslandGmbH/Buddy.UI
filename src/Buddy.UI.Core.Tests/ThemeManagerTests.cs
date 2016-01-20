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
			Assert.IsTrue(ThemeManager.Themes.Count > 0);
		}

		[TestMethod]
		public void ThemeManager_Default_ContainsAccents()
		{
			Assert.IsTrue(ThemeManager.Accents.Count > 0);
		}
	}
}
