using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfTest.View.UserControls {
	/// <summary>
	/// Interaction logic for TitleBar.xaml
	/// </summary>
	public partial class TitleBar : UserControl {
		private Window parent;

		private bool forceQuit = false;
		public bool ForceQuit { get; set; }


		public TitleBar() {
			InitializeComponent();

			// TODO: Replace with better solution
			// This call is needed to satisfy constructor
			parent = Window.GetWindow(this);

			// This call actually gets the parent window
			Loaded += (sender, args) => { 
				parent = Window.GetWindow(this);
				lbl_WindowName.Content = parent.Title;
			};
		}

		private void TitleBar_Loaded(object sender, RoutedEventArgs e) {
			throw new NotImplementedException();
		}

		private void btn_Close_Click(object sender, RoutedEventArgs e) {
			if (forceQuit) {
				Application.Current.Shutdown();
			}
			else {
				parent.Close();
			}
		}

		private void btn_Maximize_Click(object sender, RoutedEventArgs e) {
			if (parent.WindowState == WindowState.Maximized) {
				parent.WindowState = WindowState.Normal;
				btn_Maximize.Content = "O";
			}
			else {
				parent.WindowState = WindowState.Maximized;
				btn_Maximize.Content = "o";
			}
		}

		private void btn_Minimize_Click(object sender, RoutedEventArgs e) {
			if (parent != null) {
				parent.WindowState = WindowState.Minimized;
			}
		}

		private void mi_DarkModeToogle_Click(object sender, RoutedEventArgs e) {

		}

		private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
			parent.DragMove();
		}
	}
}
