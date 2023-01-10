using NavigationDemo.MVMM.ViewModels;
using NavigationDemo.Utilities.NavUtilities;

namespace NavigationDemo.MVMM.Views;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
		BindingContext = new StartPageViewModel();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        NavUtilites.Examine(Navigation);
    }
    private void Button_Clicked(object sender, EventArgs e)
	{

		var currentViewModel = ((StartPageViewModel)BindingContext).Name;
		Navigation.PushAsync(new NextPage
		{
			BindingContext = new NextPageViewModel
			{
				Name = currentViewModel
			}
		});
		//NavUtilites.DeletePage(Navigation, "StartPage");
	}

	/*
	 Data passlamak i�in parametreli constructor olu�turuldu default kalacak �ekilde 
	buraya txtName.Text paslad�k. Data receive olacak sayfada da parametreden gelen de�eri 
	entrye atad�k. ViewModel kullanmadan b�yle yapabiliriz.
	 */
}