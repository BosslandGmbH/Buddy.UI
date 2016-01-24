using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;
using Buddy.UI.Core.Interfaces;

namespace Buddy.UI.Core.Themes
{
	public static class ThemeManager
	{
		static ThemeManager()
		{
			InitializeThemes();
			InitializeAccents();
		}

		/// <summary>
		///     Gets the available accent colors.
		/// </summary>
		private static ObservableCollection<IAccentColor> Accents { get; } = new ObservableCollection<IAccentColor>();

		/// <summary>
		///     Gets the available themes.
		/// </summary>
		private static ObservableCollection<ITheme> Themes { get; } = new ObservableCollection<ITheme>();

	    public static Maybe<IAccentColor> TryGetAccent(string name)
	    {Requires.NotNullOrEmpty(name, nameof(name));

	        var ret = Accents.FirstOrDefault(v => v.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

	        return ret == null ? new Maybe<IAccentColor>() : new Maybe<IAccentColor>(ret);
	    }

	    public static Maybe<ITheme> TryGetTheme(string name)
	    {
	        Requires.NotNull(name, nameof(name));

	        var ret = Themes.FirstOrDefault(v => v.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

	        return ret == null ? new Maybe<ITheme>() : new Maybe<ITheme>(ret);
	    }

		private static void InitializeThemes()
		{
			string[] themes =
			{
				"pack://application:,,,/MahApps.Metro;component/Styles/Accents/BaseLight.xaml",
				"pack://application:,,,/MahApps.Metro;component/Styles/Accents/BaseDark.xaml"
			};

			Themes.Clear();

			foreach (var t in themes)
			{
				var dic = new ResourceDictionary {Source = new Uri(t)};

				var theme = new Theme {Name = Path.GetFileNameWithoutExtension(t), ResourceDictionary = dic};

				Themes.Add(theme);
			}
		}

		private static void InitializeAccents()
		{
			string[] accents =
			{
				"pack://application:,,,/MahApps.Metro;component/Styles/Accents/Amber.xaml",
				"pack://application:,,,/MahApps.Metro;component/Styles/Accents/Blue.xaml",
				"pack://application:,,,/MahApps.Metro;component/Styles/Accents/Brown.xaml",
				"pack://application:,,,/MahApps.Metro;component/Styles/Accents/Cobalt.xaml",
				"pack://application:,,,/MahApps.Metro;component/Styles/Accents/Crimson.xaml",
				"pack://application:,,,/MahApps.Metro;component/Styles/Accents/Cyan.xaml",
				"pack://application:,,,/MahApps.Metro;component/Styles/Accents/Emerald.xaml",
				"pack://application:,,,/MahApps.Metro;component/Styles/Accents/Green.xaml",
				"pack://application:,,,/MahApps.Metro;component/Styles/Accents/Indigo.xaml",
				"pack://application:,,,/MahApps.Metro;component/Styles/Accents/Lime.xaml",
				"pack://application:,,,/MahApps.Metro;component/Styles/Accents/Magenta.xaml",
				"pack://application:,,,/MahApps.Metro;component/Styles/Accents/Mauve.xaml",
				"pack://application:,,,/MahApps.Metro;component/Styles/Accents/Olive.xaml",
				"pack://application:,,,/MahApps.Metro;component/Styles/Accents/Orange.xaml",
				"pack://application:,,,/MahApps.Metro;component/Styles/Accents/Pink.xaml",
				"pack://application:,,,/MahApps.Metro;component/Styles/Accents/Purple.xaml",
				"pack://application:,,,/MahApps.Metro;component/Styles/Accents/Red.xaml",
				"pack://application:,,,/MahApps.Metro;component/Styles/Accents/Sienna.xaml",
				"pack://application:,,,/MahApps.Metro;component/Styles/Accents/Steel.xaml",
				"pack://application:,,,/MahApps.Metro;component/Styles/Accents/Taupe.xaml",
				"pack://application:,,,/MahApps.Metro;component/Styles/Accents/Teal.xaml",
				"pack://application:,,,/MahApps.Metro;component/Styles/Accents/Violet.xaml",
				"pack://application:,,,/MahApps.Metro;component/Styles/Accents/Yellow.xaml"
			};

			Accents.Clear();

			foreach (var a in accents)
			{
				var dic = new ResourceDictionary {Source = new Uri(a)};

				var accent = new AccentColor(dic, Path.GetFileNameWithoutExtension(a));

				Accents.Add(accent);
			}
		}
	}
}