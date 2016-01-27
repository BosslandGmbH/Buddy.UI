using Buddy.UI.Core;
using Buddy.UI.Core.Themes;

namespace Buddy.UI.ViewModels
{
	public class MainWindowViewModel : ViewModel
	{
		private static MainWindowViewModel _instance;

		private MainWindowViewModel()
		{
			ThemeManager.Initialize();
		}

		public static MainWindowViewModel Instance => _instance ?? (_instance = new MainWindowViewModel());
	}
}