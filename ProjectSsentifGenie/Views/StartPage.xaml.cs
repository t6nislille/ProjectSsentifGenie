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
}