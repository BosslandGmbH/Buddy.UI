using System;
using System.Windows.Input;

namespace Buddy.UI.Core
{
	/// <summary>
	///     Provides a default implementation for a simple command.
	/// </summary>
	public class RelayCommand : ICommand
	{
		private readonly Func<bool> _canExecute;
		private readonly Action<object> _executor;

		/// <summary>
		///     Initializes a new instance of the <see cref="RelayCommand" /> class.
		/// </summary>
		/// <param name="action">The action to be invoked when this command is triggered.</param>
		/// <exception cref="System.ArgumentNullException"></exception>
		public RelayCommand(Action<object> action)
		{
			if (action == null)
				throw new ArgumentNullException(nameof(action));

			_executor = action;
		}

		/// <summary>
		///     Initializes a new instance of the <see cref="RelayCommand" /> class.
		/// </summary>
		/// <param name="action">The action to be invoked when this command is triggered.</param>
		/// <param name="canExecute">Precondition determining whether this command can be executed or not.</param>
		public RelayCommand(Action<object> action, Func<bool> canExecute) : this(action)
		{
			if (canExecute == null)
				throw new ArgumentNullException(nameof(canExecute));

			_canExecute = canExecute;
		}

		/// <summary>
		///     Determines whether this command can be executed.
		/// </summary>
		/// <param name="parameter">The parameter.</param>
		/// <returns></returns>
		public bool CanExecute(object parameter)
		{
			if (_canExecute == null)
				return true;

			return _canExecute();
		}

		/// <summary>
		///     Executes this command.
		/// </summary>
		/// <param name="parameter">The parameter.</param>
		public void Execute(object parameter)
		{
			_executor(parameter);
		}

		public event EventHandler CanExecuteChanged;

		/// <summary>
		///     Determines whether this command can be executed.
		/// </summary>
		/// <returns></returns>
		public bool CanExecute()
		{
			return CanExecute(null);
		}
	}
}