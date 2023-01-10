using NavigationDemo.Utilities.NavUtilities;

namespace NavigationDemo.MVMM.Views;

public partial class FinalPage : ContentPage
{
	public FinalPage()
	{
		InitializeComponent();
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		NavUtilites.Examine(Navigation);
	}
	private void Button_Clicked(object sender, EventArgs e)
	{
		Navigation.PopAsync();
	}

	private void Button_Clicked_1(object sender, EventArgs e)
	{
		//Navigation.PopToRootAsync();
		NavUtilites.InsertPage(Navigation);
	}
}