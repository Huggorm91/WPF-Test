using System.Windows;

namespace WpfTest {
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		private void btn_Close_Click(object sender, RoutedEventArgs e) {
			Application.Current.Shutdown();
        }

		private void btn_Maximize_Click(object sender, RoutedEventArgs e) {
			if (WindowState == WindowState.Maximized) {
				WindowState = WindowState.Normal;
			}
			else {
				WindowState = WindowState.Maximized;
			}
		}

		private void btn_Minimize_Click(object sender, RoutedEventArgs e) {
			WindowState = WindowState.Minimized;
		}
	}
}