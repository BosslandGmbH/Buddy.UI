using System;
using System.Windows;
using Buddy.UI.Core.Interfaces;
using Buddy.UI.Core.Themes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Buddy.UI.Core.Tests
{
	[TestClass]
	public class AccentColorTests
	{
		private Maybe<IAccentColor> _accent;

		[TestInitialize]
		public void Initialize()
		{
			// Required to register bourgeoise XAML URI schemes
			if (!UriParser.IsKnownScheme("pack"))
				new Application();
			_accent = ThemeManager.TryGetAccent("Blue");
		}

		[TestMethod]
		public void AccentColor_ResourceDictionary_Populated()
		{
			Assert.IsTrue(_accent.HasValue);
			Assert.IsNotNull(_accent.Value.ResourceDictionary);
			Assert.IsTrue(_accent.Value.ResourceDictionary.Count > 0);
		}

		[TestMethod]
		public void AccentColor_Brush_HasBrush()
		{
			Assert.IsNotNull(_accent.Value.Brush);
		}

		[TestMethod]
		public void AccentColor_Equals_SameAccentsAreEqual()
		{
			var left = ThemeManager.TryGetAccent("Blue");
			var right = ThemeManager.TryGetAccent("Blue");

			Assert.IsTrue(left.Equals(right));
		}

		[TestMethod]
		public void AccentColor_Equals_DifferentAccentsNotEqual()
		{
			var left = ThemeManager.TryGetAccent("Blue");
			var right = ThemeManager.TryGetAccent("Red");

			Assert.IsFalse(left.Equals(right));
		}
	}
}