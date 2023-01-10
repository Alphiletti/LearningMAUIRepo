using CollectionViewDemo.MVMM.ViewModels;

namespace CollectionViewDemo.MVMM.Views;

public partial class LayoutsPage : ContentPage
{
	public LayoutsPage()
	{
		InitializeComponent();
		BindingContext = new DataViewModels();
	}

	private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		var element = e.CurrentSelection;
	}
}