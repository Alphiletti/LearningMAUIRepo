using CollectionViewDemo.MVMM.ViewModels;

namespace CollectionViewDemo.MVMM.Views;

public partial class DataView : ContentPage
{
	public DataView()
	{
		InitializeComponent();
		BindingContext = new DataViewModels();
	}
}