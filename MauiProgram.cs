﻿using CarList.Services;
using CarList.ViewModels;
using Microsoft.Extensions.Logging;

namespace CarList;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<CarServices>();
		builder.Services.AddSingleton<CarListViewModel>();
		builder.Services.AddSingleton<MainPage>();

		return builder.Build();
	}
}
