namespace ProjectSsentifGenie.Views;

public partial class LegDay : ContentPage
{
	public LegDay()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        legday.ItemsSource = ExerciseServices.GetLegExercises();
    }

    private void BackButton_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushModalAsync(new StartPage());
    }

    private void Details_Clicked(System.Object sender, SelectionChangedEventArgs e)
    {
        Navigation.PushModalAsync(new DetailsPage(e.CurrentSelection.First() as Exercise));
    }

}