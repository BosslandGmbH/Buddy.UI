using System;

namespace Buddy.UI.Core.Interfaces
{
	/// <summary>
	///     Interface any type representing a theme should implement.
	/// </summary>
	public interface ITheme : IStylable, IEquatable<ITheme>
	{
		/// <summary>
		///     Gets the name of this theme.
		/// </summary>
		string Name { get; }
	}
}