using System;
using System.Windows.Media;

namespace Buddy.UI.Core.Interfaces
{
	/// <summary>
	///     Interface any type representing an accent color should implement.
	/// </summary>
	public interface IAccentColor : IStylable, IEquatable<IAccentColor>
	{
		/// <summary>
		///     Gets the accent color's brush.
		/// </summary>
		Brush Brush { get; }

		/// <summary>
		///     Gets the name of this brush.
		/// </summary>
		string Name { get; }
	}
}