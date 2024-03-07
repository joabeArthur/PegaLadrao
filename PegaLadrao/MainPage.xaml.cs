

using Microsoft.Maui.Controls;

namespace PegaLadrao;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void ClicaeComeca(object sender, EventArgs args)
	{
		Application.Current.MainPage = new PlayPage();
	}
}