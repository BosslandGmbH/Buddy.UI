using System.Collections.Generic;
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

		/// <summary>
		/// Assigns the specified value to the specified property and raises the PropertyChanged event.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="field">The field.</param>
		/// <param name="value">The value.</param>
		/// <param name="propertyName">Name of the property.</param>
		protected virtual void SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
		{
			Requires.NotNullOrEmpty(propertyName, nameof(propertyName));

			if (EqualityComparer<T>.Default.Equals(field, value))
				return;

			field = value;
			NotifyPropertyChanged(propertyName);
		}
	}
}