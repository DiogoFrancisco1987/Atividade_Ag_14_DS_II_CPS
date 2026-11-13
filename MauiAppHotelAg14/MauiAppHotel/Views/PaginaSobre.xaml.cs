namespace MauiAppHotel.Views;

public partial class PaginaSobre : ContentPage
{
	public PaginaSobre()
	{
		InitializeComponent();
	}

	private async void OnVoltarClicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}
}