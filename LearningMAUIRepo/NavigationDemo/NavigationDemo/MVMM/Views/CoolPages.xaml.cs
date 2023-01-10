using NavigationDemo.Utilities.NavUtilities;

namespace NavigationDemo.MVMM.Views;

public partial class CoolPages : ContentPage
{
	public CoolPages()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        NavUtilites.Examine(Navigation);
    }

    protected override bool OnBackButtonPressed()
    {
        return true;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();
    }
}