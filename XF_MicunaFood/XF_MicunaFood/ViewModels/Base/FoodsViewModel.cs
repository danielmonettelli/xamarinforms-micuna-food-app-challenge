using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using XF_MicunaFood.Models;

namespace XF_MicunaFood.ViewModels.Base
{
    public class FoodsViewModel : BaseViewModel
    {
        private VarietyFood varietyFoods;
        private string name_food;
        private string image_food;
        private double price_food;
        private string short_description_food;
        private string long_description_food;

        public VarietyFood VarietyFoods
        {
            get { return varietyFoods; }
            set { SetProperty(ref varietyFoods, value); }
        }

        public string Name_Food
        {
            get { return name_food; }
            set { SetProperty(ref name_food, value); }
        }

        public string Image_Food
        {
            get { return image_food; }
            set { SetProperty(ref image_food, value); }
        }

        public double Price_Food
        {
            get { return price_food; }
            set { SetProperty(ref price_food, value); }
        }

        public string Short_Description_Food
        {
            get { return short_description_food; }
            set { SetProperty(ref short_description_food, value); }
        }

        public string Long_Description_Food
        {
            get { return long_description_food; }
            set { SetProperty(ref long_description_food, value); }
        }

        public FoodsViewModel(Food food)
        {
            VarietyFoods = food.VarietyFoods;
            Name_Food = food.Name_Food;
            Image_Food = food.Image_Food;
            Price_Food = food.Price_Food;
            Short_Description_Food = food.Short_Description_Food;
            Long_Description_Food = food.Long_Description_Food;
        }
    }
}
