using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_MicunaFood.ViewModels;

namespace XF_MicunaFood.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FoodDetailPage : ContentPage
    {
        public FoodDetailPage(FoodsViewModel item)
        {
            InitializeComponent();

            BindingContext = new FoodDetailViewModel(item);
        }

        private async void ReturnPreviousPage_Tapped(object sender, EventArgs e)
        {
            await Task.Delay(350);
            await Navigation.PopAsync(true);
        }
    }
}