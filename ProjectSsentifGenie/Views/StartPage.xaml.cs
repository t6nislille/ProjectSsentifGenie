namespace ProjectSsentifGenie.Views;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
	}

    private void PullDay_Clicked(System.Object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new PullDay());
    }

    private void PushDay_Clicked(System.Object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new PushDay());
    }

    private void LegDay_Clicked(System.Object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new LegDay());
    }

    private void GymList_Clicked(System.Object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new GymPage());
    }
}