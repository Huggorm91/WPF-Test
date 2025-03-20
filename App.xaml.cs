using System.Configuration;
using System.Data;
using System.Windows;

namespace WpfTest;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
	private static App? instance = null;

	public App() {
		instance ??= this;
	}

	public static void SetTheme(string fileName) {
		if (instance == null) return;

		instance.Resources.MergedDictionaries[0].Source = new Uri(GetThemePath(fileName), UriKind.Relative);
	}

	public static bool IsCurrentTheme(string fileName) {
		if (instance == null) return false;

		return instance.Resources.MergedDictionaries[0].Source == new Uri(GetThemePath(fileName), UriKind.Relative);
	}

	private static string GetThemePath(string fileName) {
		return $"/View/Styles/{fileName}.xaml";
	}
}
