using System.Windows;

namespace Buddy.UI.Core.Interfaces
{
	/// <summary>
	///     Interface all types representing something stylable should implement.
	/// </summary>
	public interface IStylable
	{
		/// <summary>
		///     Gets the resource dictionary containing the resources that describe this style.
		/// </summary>
		ResourceDictionary ResourceDictionary { get; }

		/// <summary>
		///     Applies the styling changes.
		/// </summary>
		void Apply();
	}
}