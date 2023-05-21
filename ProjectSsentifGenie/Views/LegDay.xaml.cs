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

}