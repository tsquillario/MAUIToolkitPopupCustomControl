using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace ToolkitPopupCustomControl;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.RegisterViewModels()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});



#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();


	}

    public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddTransient<MainPage>();
        mauiAppBuilder.Services.AddTransient<MainViewModel>();
        mauiAppBuilder.Services.AddTransient<Popup1>();
        mauiAppBuilder.Services.AddTransient<PopupViewModel>();
        return mauiAppBuilder;
    }
}
