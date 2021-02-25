using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XF_MicunaFood.Models;
using XF_MicunaFood.ViewModels.Base;

namespace XF_MicunaFood.ViewModels.Home
{
    public class FoodDetailViewModel : BaseViewModel
    {
        private readonly HomeViewModel homeViewModel;
        public FoodsViewModel SelectedFood { get; set; }

        public FoodDetailViewModel(FoodsViewModel selectedFoodsViewModel)
        {
            homeViewModel = new HomeViewModel();

            var selectedItem = homeViewModel.Foods.Where(f => f.Name_Food.Equals(selectedFoodsViewModel.Name_Food)).FirstOrDefault();

            SelectedFood = new FoodsViewModel(selectedItem);
        }
    }
}
