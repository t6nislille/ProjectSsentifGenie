namespace ProjectSsentifGenie.Views;

public partial class PushDay : ContentPage
{
	public PushDay()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        pushday.ItemsSource = ExerciseServices.GetPushExercises();
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