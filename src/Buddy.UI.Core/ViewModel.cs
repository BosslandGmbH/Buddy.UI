using System.ComponentModel;
using System.Runtime.CompilerServices;
using Buddy.UI.Core.Annotations;
using Buddy.UI.Core.Interfaces;

namespace Buddy.UI.Core
{
	/// <summary>
	///     Provides a base type for View Models.
	/// </summary>
	public abstract class ViewModel : IViewModel
	{
		public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
		///     Notifies the property's value has changed. CallerMemberName is used to deduce the name of the property changing.
		/// </summary>
		/// <param name="propertyName">Name of the property.</param>
		[NotifyPropertyChangedInvocator]
		public virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}