using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Buddy.UI.Core.Tests
{
	// ReSharper disable ExpressionIsAlwaysNull
	[TestClass]
	public class RequiresTests
	{
		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void Requires_NotNull_ThrowsIfNull()
		{
			object o = null;
			Requires.NotNull(o, nameof(o));
		}

		[TestMethod]
		public void Requires_NotNull_PassIfNonNull()
		{
			var s = "a";
			Requires.NotNull(s, nameof(s));
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void Requires_NotNullOrEmpty_ThrowsIfNull()
		{
			string s = null;
			Requires.NotNullOrEmpty(s, nameof(s));
		}

		[TestMethod]
		public void Requires_NotNullOrEmpty_PassIfNonNull()
		{
			var s = "s";
			Requires.NotNullOrEmpty(s, nameof(s));
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void Requires_NotNullOrWhitespace_ThrowsIfNull()
		{
			string s = null;
			Requires.NotNullOrWhitespace(s, nameof(s));
		}

		[TestMethod]
		public void Requires_NotNullOrWhitespace_PassIfNonNull()
		{
			var s = "s";
			Requires.NotNullOrWhitespace(s, nameof(s));
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void Requires_Condition_FalseThrows()
		{
			Requires.Condition(false, string.Empty);
		}

		[TestMethod]
		public void Requires_Condition_TruePasses()
		{
			Requires.Condition(true, string.Empty);
		}
	}
}
