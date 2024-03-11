

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

	private void FrameOnClicked(object sender, EventArgs args){
		FrameSobre.IsVisible = true;
	}

	private void FrameVoltar(object sender, EventArgs args){
		FrameSobre.IsVisible = false;
	}
}