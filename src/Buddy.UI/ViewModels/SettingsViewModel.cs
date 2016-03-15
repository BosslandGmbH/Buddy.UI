using System.Collections.ObjectModel;
using Buddy.UI.Core;
using Buddy.UI.Core.Interfaces;
using Buddy.UI.Core.Themes;

namespace Buddy.UI.ViewModels
{
	public class SettingsViewModel : ViewModel
	{
		private static SettingsViewModel _instance;

		public static SettingsViewModel Instance => _instance ?? (_instance = new SettingsViewModel());

		private SettingsViewModel()
		{
			
		}

		public ObservableCollection<ITheme> Themes => ThemeManager.Themes;

		public ObservableCollection<IAccentColor> Accents => ThemeManager.Accents; 

		private int _selectedThemeIndex;

		public int SelectedThemeIndex
		{
			get { return _selectedThemeIndex; }
			set
			{
				if (value < 0)
					return;

				SetProperty(ref _selectedThemeIndex, value);

				var t = ThemeManager.Themes[value];
			    t.Apply();
			}
		}

		private int _selectedAccentIndex;

		public int SelectedAccentIndex
		{
			get { return _selectedAccentIndex;}
			set
			{
				if (value < 0)
					return;

				SetProperty(ref _selectedAccentIndex, value);

				var a = ThemeManager.Accents[value];
			    a.Apply();
			}
		}
	}
}
