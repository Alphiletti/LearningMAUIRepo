﻿using CollectionViewDemo.MVMM.Views;

namespace CollectionViewDemo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new ProductsView();
	}
}
