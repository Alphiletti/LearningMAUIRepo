using NavigationDemo.Utilities.NavUtilities;

namespace NavigationDemo.MVMM.Views;

public partial class NextPage : ContentPage
{
	public NextPage()
	{
		InitializeComponent();
	}

  //  public NextPage(string name)
  //  {
  //      InitializeComponent();
		//txtName.Text = name;
  //  } //ViewModel olmadan data geçirme
    protected override void OnAppearing()
    {
        base.OnAppearing();
        NavUtilites.Examine(Navigation);
    }
    private void Button_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new FinalPage());
	}

	private void Button_Clicked_1(object sender, EventArgs e)
	{
		Navigation.PopAsync();
	}
}