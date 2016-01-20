using Buddy.UI.Core;

namespace Buddy.UI.ViewModels
{
	public class MainWindowViewModel : ViewModel
	{
		private static MainWindowViewModel _instance;

		private MainWindowViewModel()
		{
		}

		public static MainWindowViewModel Instance => _instance ?? (_instance = new MainWindowViewModel());
	}
}