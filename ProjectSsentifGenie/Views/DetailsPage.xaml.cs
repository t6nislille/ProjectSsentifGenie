namespace ProjectSsentifGenie.Views;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(Exercise exercise)
	{
		InitializeComponent();
		BindingContext = exercise;
	}
}