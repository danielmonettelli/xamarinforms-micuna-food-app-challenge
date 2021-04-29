using ImageFromXamarinUI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_MicunaFood.ViewModels;

namespace XF_MicunaFood.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FoodDetailPage : ContentPage
    {
        private readonly FoodDetailViewModel foodDetailViewModel;

        public FoodDetailPage(FoodsViewModel item)
        {
            InitializeComponent();

            BindingContext = foodDetailViewModel = new FoodDetailViewModel(item);
        }

        private async void ReturnPreviousPage_Tapped(object sender, EventArgs e)
        {
            await Task.Delay(350);
            await Navigation.PopAsync(true);
        }

        private async void ScreenshotAndShareFile_Tapped(object sender, EventArgs e)
        {
            if (imageForScreenshot.Source == null)
            {
                // Mode ImageFromXamarinUI
                var stream = await layoutMainParent.CaptureImageAsync(Color.White);
                imageForScreenshot.Source = ImageSource.FromStream(() => stream);

                // Mode Xamarin.Essentials.Screenshot
                //var screenshot = await Screenshot.CaptureAsync();
                //var stream = await screenshot.OpenReadAsync();
                //imageForScreenshot.Source = ImageSource.FromStream(() => stream);

                VisualStateManager.GoToState(stateFontIcon, "Selected");
                await this.DisplayToastAsync(message: "Successful screenshot", durationMilliseconds: 2000);
            }
            else
            {
                string fileName = "MicunaFood - " + foodDetailViewModel.SelectedFood.Name_Food + ".png";
                string fullPath = Path.Combine(FileSystem.CacheDirectory, fileName);

                var byteArray = await imageForScreenshot.GetImageAsPngAsync();
                File.WriteAllBytes(fullPath, byteArray);

                await Share.RequestAsync(new ShareFileRequest
                {
                    Title = "Data Transfer " + foodDetailViewModel.SelectedFood.Name_Food,
                    File = new ShareFile(fullPath, "image/png")
                });
            }
        }
    }
}