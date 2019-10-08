using System.Windows;
using MahApps.Metro.Controls;

namespace Melody.View
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml.
  /// </summary>
  public partial class Main : MetroWindow
  {
    public Main()
    {
    }

    private void ButtonClose_Click(object sender, RoutedEventArgs e)
    {
      Application.Current.Shutdown();
    }

    private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
    {
      this.ButtonOpenMenu.Visibility = Visibility.Collapsed;
      this.ButtonCloseMenu.Visibility = Visibility.Visible;
    }

    private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
    {
      this.ButtonOpenMenu.Visibility = Visibility.Visible;
      this.ButtonCloseMenu.Visibility = Visibility.Collapsed;
    }
  }
}
