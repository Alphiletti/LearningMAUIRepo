﻿using NavigationDemo.MVMM.Views;

namespace NavigationDemo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new StartPage());
	}
}
