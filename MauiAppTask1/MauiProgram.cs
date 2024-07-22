using Microsoft.Extensions.Logging;

namespace MauiAppTask1
{
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
                    fonts.AddFont("EduAUVICWANTHand-VariableFont_wght.ttf", "EduAU");
                    fonts.AddFont("Cinzel-VariableFont_wght.ttf", "Cinzel");
                    fonts.AddFont("Pacifico-Regular.ttf", "Pacifico");
                    fonts.AddFont("MaterialSymbolsOutlined.ttf", "SymbolsOutlined");
                    fonts.AddFont("MaterialSymbolsRounded.ttf", "SymbolsRounded");
                    fonts.AddFont("MaterialSymbolsSharp.ttf", "SymbolsSharp");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
