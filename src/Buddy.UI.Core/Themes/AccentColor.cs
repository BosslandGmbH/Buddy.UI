using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Media;
using Buddy.UI.Core.Interfaces;

namespace Buddy.UI.Core.Themes
{
	[DebuggerDisplay("Accent: {Name}")]
	public class AccentColor : IAccentColor
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="AccentColor" /> class.
		/// </summary>
		/// <param name="resourceDictionary">The resource dictionary.</param>
		/// <param name="name">The name.</param>
		/// <exception cref="System.ArgumentNullException"></exception>
		public AccentColor(ResourceDictionary resourceDictionary, string name)
		{
			if (resourceDictionary == null)
				throw new ArgumentNullException(nameof(resourceDictionary));

			ResourceDictionary = resourceDictionary;
			Name = name;
		}

		public ResourceDictionary ResourceDictionary { get; internal set; }

		public void Apply()
		{
			if (ResourceDictionary == null)
                throw new InvalidOperationException("Can not apply an accent color without a valid ResourceDictionary!");

		    ThemeManager.LoadResources(Name, ResourceDictionary);
		}

		/// <summary>
		///     Indicates whether the current object is equal to another object of the same type.
		/// </summary>
		/// <param name="other">The other.</param>
		/// <returns></returns>
		public bool Equals(IAccentColor other)
		{
			if (other == null)
				return false;

			return Name == other.Name;
		}

		public Brush Brush => (Brush) ResourceDictionary?["AccentColorBrush"];

		public string Name { get; }
	}
}