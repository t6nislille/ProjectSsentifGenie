using Windows.Gaming.Preview.GamesEnumeration;

namespace ProjectSsentifGenie.Views;

public partial class GymPage : ContentPage
{
	public GymPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        gymlist.ItemsSource = GymServices.GetGymList();
    }

    private void BackButton_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushModalAsync(new StartPage());
    }
}