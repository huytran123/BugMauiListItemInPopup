using CommunityToolkit.Maui.Views;

namespace DemoPopup;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		await this.ShowPopupAsync(new PickerPopup());
	}
}


