using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PancakeView;
using Xamarin.Forms.Xaml;
using XF_MicunaFood.Models;
using XF_MicunaFood.ViewModels.Base;
using XF_MicunaFood.ViewModels.Home;

namespace XF_MicunaFood.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        private readonly HomeViewModel homeViewModel;

        public HomePage()
        {
            InitializeComponent();

            BindingContext = homeViewModel = new HomeViewModel();

            FilterCategory();
        }

        void FilterCategory()
        {
            SelectedCategory_Tapped(CategoryList.Children[3], null);
        }

        private void SelectedCategory_Tapped(object sender, EventArgs e)
        {
            var surfaceCategory = sender as VisualElement;
            var parent = surfaceCategory.Parent as FlexLayout;

            foreach (View child in parent.Children)
            {
                VisualStateManager.GoToState(child, "Normal");
                ChangeFontIconColor(child, false);
            }
            VisualStateManager.GoToState(surfaceCategory, "Selected");
            ChangeFontIconColor(surfaceCategory, true);
        }

        void ChangeFontIconColor(VisualElement child, bool isSelected)
        {
            var imageCategory = child.FindByName<Label>("ImageCategory");
            var labelCategory = child.FindByName<Label>("LabelCategory");

            string visualState = isSelected ? "Selected" : "Normal";
            VisualStateManager.GoToState(imageCategory, visualState);

            homeViewModel.GetItemsForCategory(labelCategory.Text, isSelected);
        }

        private async void CollectionView_SelectedItem(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = e.CurrentSelection.FirstOrDefault();

            if (selectedItem != null)
            {
                await Task.Delay(350);
                await Navigation.PushAsync(new FoodDetailPage(selectedItem as FoodsViewModel));
            }

            collectionView_MicunaFood.SelectedItem = null;
        }
    }
}