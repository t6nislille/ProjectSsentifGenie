namespace ProjectSsentifGenie.Views;

public partial class PullDay : ContentPage
{
	public PullDay()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        pullday.ItemsSource = ExerciseServices.GetExercises();
    }

    private void BackButton_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushModalAsync(new StartPage());
    }
}