using Buddy.UI.ViewModels;

namespace Buddy.UI
{
	/// <summary>
	///     Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow
	{
		public MainWindow()
		{
			InitializeComponent();
			DataContext = MainWindowViewModel.Instance;
		}
	}
}