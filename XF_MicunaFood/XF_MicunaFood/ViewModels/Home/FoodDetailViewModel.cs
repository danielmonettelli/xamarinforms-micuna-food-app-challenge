using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XF_MicunaFood.Services;

namespace XF_MicunaFood.ViewModels
{
    public class FoodDetailViewModel : BaseViewModel
    {
        public FoodsViewModel SelectedFood { get; set; }

        public FoodDetailViewModel(FoodsViewModel selectedFoodsViewModel)
        {
            var selectedItem = Repository.Foods.Where(f => f.Name_Food.Equals(selectedFoodsViewModel.Name_Food)).FirstOrDefault();

            SelectedFood = new FoodsViewModel(selectedItem);
        }
    }
}
