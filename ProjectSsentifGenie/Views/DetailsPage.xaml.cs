namespace ProjectSsentifGenie.Views;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(Exercise exercise)
	{
		InitializeComponent();
		this.BindingContext = exercise;
	}

    //private void BackButton_Clicked(System.Object sender, System.EventArgs e)
    //{
    //    Navigation.PushModalAsync(new StartPage());
    //}

	async void BackButton_Clicked(System.Object sender, System.EventArgs e)
	{
		await Navigation.PopAsync();
	}
}