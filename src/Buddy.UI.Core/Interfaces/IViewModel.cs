using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Buddy.UI.Core.Interfaces
{
	/// <summary>
	///     Interface that all types representing a view model should implement.
	/// </summary>
	public interface IViewModel : INotifyPropertyChanged
	{
		/// <summary>
		///     Notifies the property's value has changed. CallerMemberName is used to deduce the name of the property changing.
		/// </summary>
		/// <param name="propertyName">Name of the property.</param>
		void NotifyPropertyChanged([CallerMemberName] string propertyName = null);
	}
}