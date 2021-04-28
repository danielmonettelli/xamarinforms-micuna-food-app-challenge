using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using XF_MicunaFood.Models;
using MvvmHelpers;
using XF_MicunaFood.Services;

namespace XF_MicunaFood.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public ObservableRangeCollection<Food> Foods { get; set; }
        public ObservableRangeCollection<Category> Categories { get; set; }
        public ObservableRangeCollection<FoodsViewModel> DynamicFoods { get; set; }

        public HomeViewModel()
        {
            Categories = new ObservableRangeCollection<Category>();
            Categories.AddRange(Repository.Categories);

            Foods = new ObservableRangeCollection<Food>();
            Foods.AddRange(Repository.Foods);

            DynamicFoods = new ObservableRangeCollection<FoodsViewModel>();
        }

        public void GetItemsForCategory(object obj, bool isSelected)
        {
            DynamicFoods.Clear();

            var items = Foods.Where(f => f.VarietyFoods.Name_VarietyFood.Contains(obj.ToString())).ToList();

            if (isSelected == true)
                foreach (var item in items)
                {
                    DynamicFoods.Add(new FoodsViewModel(item));
                }
        }
    }
}