using System;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_MicunaFood.ViewModels;

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

        private void FilterCategory()
        {
            SelectedCategory_Tapped(CategoryList.Children[3], null);
        }

        private void SelectedCategory_Tapped(object sender, EventArgs e)
        {
            VisualElement surfaceCategory = sender as VisualElement;
            FlexLayout parent = surfaceCategory.Parent as FlexLayout;

            foreach (View child in parent.Children)
            {
                VisualStateManager.GoToState(child, "Normal");
                ChangeFontIconColor(child, false);
            }
            VisualStateManager.GoToState(surfaceCategory, "Selected");
            ChangeFontIconColor(surfaceCategory, true);
        }

        private void ChangeFontIconColor(VisualElement child, bool isSelected)
        {
            Label imageCategory = child.FindByName<Label>("ImageCategory");
            Label labelCategory = child.FindByName<Label>("LabelCategory");

            string visualState = isSelected ? "Selected" : "Normal";
            VisualStateManager.GoToState(imageCategory, visualState);

            homeViewModel.GetItemsForCategory(labelCategory.Text, isSelected);
        }

        private async void CollectionView_SelectedItem(object sender, SelectionChangedEventArgs e)
        {
            object selectedItem = e.CurrentSelection.FirstOrDefault();

            if (selectedItem != null)
            {
                await Task.Delay(350);
                await Navigation.PushAsync(new FoodDetailPage(selectedItem as FoodsViewModel));
            }

            collectionView_MicunaFood.SelectedItem = null;
        }
    }
}