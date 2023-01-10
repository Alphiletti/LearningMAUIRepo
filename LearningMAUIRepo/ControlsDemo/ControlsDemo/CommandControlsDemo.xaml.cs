namespace ControlsDemo;

public partial class CommandControlsDemo : ContentPage
{
	public CommandControlsDemo()
	{
		InitializeComponent();
	}

    private void btnTest_Clicked(object sender, EventArgs e)
    {
		DisplayAlert("Test", "This is a demo", "OK");
    }

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        string r1 = radio1.Content.ToString();
        string r2 = radio2.Content.ToString();
        string r3 = radio3.Content.ToString();
        string r4 = radio4.Content.ToString();
        if(radio1.IsChecked)
        {
            DisplayAlert($"{radio1.Content}", $"{e.Value}", "OK");
            DisplayAlert($"{radio2.Content}", $"{!e.Value}", "OK");
        }
        else
        {
            DisplayAlert($"{radio1.Content}", $"{!e.Value}", "OK");
            DisplayAlert($"{radio2.Content}", $"{e.Value}", "OK");
        }
    }

    private void searchControl_SearchButtonPressed(object sender, EventArgs e)
    {
        DisplayAlert("Searching", $"Searching: {searchControl.Text}", "OK");
    }

    private void SwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("SwipeView", $"Element Tapped", "OK");
    }
}