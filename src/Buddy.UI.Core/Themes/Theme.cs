using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using Buddy.UI.Core.Interfaces;

namespace Buddy.UI.Core.Themes
{
	/// <summary>
	///     Provides a base implementation for a theme.
	/// </summary>
	[DebuggerDisplay("Theme: {Name}")]
	[DisplayName("{Name}")]
	public class Theme : ITheme
	{
		public ResourceDictionary ResourceDictionary { get; internal set; }

		public void Apply()
		{
			throw new NotImplementedException();
		}

		public string Name { get; internal set; }

		#region Implementation of IEquatable<ITheme>

		/// <summary>
		///     Indicates whether the current object is equal to another object of the same type.
		/// </summary>
		/// <param name="other">The other.</param>
		/// <returns></returns>
		public bool Equals(ITheme other)
		{
			if (other == null)
				return false;

			return Name == other.Name;
		}

		#endregion
	}
}