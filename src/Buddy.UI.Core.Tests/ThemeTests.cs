using System;
using System.Windows;
using Buddy.UI.Core.Interfaces;
using Buddy.UI.Core.Themes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Buddy.UI.Core.Tests
{
	[TestClass]
	public class ThemeTests
	{
		private Maybe<ITheme> _theme;

		[TestInitialize]
		public void Initialize()
		{
			// Required to register bourgeoise XAML URI schemes
			if (!UriParser.IsKnownScheme("pack"))
				new Application();

			_theme = ThemeManager.TryGetTheme("BaseDark");
		}

		[TestMethod]
		public void Theme_ResourceDictionary_Populated()
		{
			Assert.IsTrue(_theme.HasValue);
			Assert.IsNotNull(_theme.Value.ResourceDictionary);
			Assert.IsTrue(_theme.Value.ResourceDictionary.Count > 0);
		}

		[TestMethod]
		public void Theme_Equals_SameThemesAreEqual()
		{
			var left = ThemeManager.TryGetTheme("BaseDark");
			var right = ThemeManager.TryGetTheme("BaseDark");

			Assert.IsTrue(left.Equals(right));
		}

		[TestMethod]
		public void Theme_Equals_DifferentThemesNotEqual()
		{
			var left = ThemeManager.TryGetTheme("BaseDark");
			var right = ThemeManager.TryGetTheme("BaseLight");

			Assert.IsFalse(left.Equals(right));
		}
	}
}
