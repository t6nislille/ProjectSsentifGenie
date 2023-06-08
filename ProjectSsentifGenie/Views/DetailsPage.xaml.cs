namespace ProjectSsentifGenie.Views;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(Exercise exercise)
	{
		InitializeComponent();
		BindingContext = exercise;
	}

	async void BackButton_Clicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}
}