using System.Windows;
using MahApps.Metro.Controls;

namespace Melody.View
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml.
  /// </summary>
  public partial class MainWindow : MetroWindow
  {
    public MainWindow()
    {
    }

    private void ButtonClose_Click(object sender, RoutedEventArgs e)
    {
      Application.Current.Shutdown();
    }

    private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
    {
      ButtonOpenMenu.Visibility = Visibility.Collapsed;
      ButtonCloseMenu.Visibility = Visibility.Visible;
    }

    private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
    {
      ButtonOpenMenu.Visibility = Visibility.Visible;
      ButtonCloseMenu.Visibility = Visibility.Collapsed;
    }
  }
}
