using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]


#region FontIcons Embedded 
// MATERIAL FONT ICONS
[assembly: ExportFont("materialdesignicons-webfont.ttf", Alias = "MaterialFontIcons")]
// CUSTOM FONT ICONS WITH "IconMoon" and "Fontello"
[assembly: ExportFont("monettelliuikitfonticons.ttf", Alias = "MonettelliFontIcons")]
#endregion


#region FontFamily Embedded 
#region FONTFAMILY [OpenSans]
[assembly: ExportFont("OpenSans-Bold.ttf", Alias = "OpenSans_Bold")]
[assembly: ExportFont("OpenSans-BoldItalic.ttf", Alias = "OpenSans_BoldItalic")]
[assembly: ExportFont("OpenSans-ExtraBold.ttf", Alias = "OpenSans_ExtraBold")]
[assembly: ExportFont("OpenSans-ExtraBoldItalic.ttf", Alias = "OpenSans_ExtraBoldItalic")]
[assembly: ExportFont("OpenSans-Italic.ttf", Alias = "OpenSans_Italic")]
[assembly: ExportFont("OpenSans-Light.ttf", Alias = "OpenSans_Light")]
[assembly: ExportFont("OpenSans-LightItalic.ttf", Alias = "OpenSans_LightItalic")]
[assembly: ExportFont("OpenSans-Regular.ttf", Alias = "OpenSans_Regular")]
[assembly: ExportFont("OpenSans-SemiBold.ttf", Alias = "OpenSans_SemiBold")]
[assembly: ExportFont("OpenSans-SemiBoldItalic.ttf", Alias = "OpenSans_SemiBoldItalic")]
#endregion
#endregion