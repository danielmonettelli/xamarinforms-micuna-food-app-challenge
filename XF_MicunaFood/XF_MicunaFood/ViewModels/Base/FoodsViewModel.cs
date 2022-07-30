using MvvmHelpers;
using XF_MicunaFood.Models;

namespace XF_MicunaFood.ViewModels
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
            get => varietyFoods;
            set => SetProperty(ref varietyFoods, value);
        }

        public string Name_Food
        {
            get => name_food;
            set => SetProperty(ref name_food, value);
        }

        public string Image_Food
        {
            get => image_food;
            set => SetProperty(ref image_food, value);
        }

        public double Price_Food
        {
            get => price_food;
            set => SetProperty(ref price_food, value);
        }

        public string Short_Description_Food
        {
            get => short_description_food;
            set => SetProperty(ref short_description_food, value);
        }

        public string Long_Description_Food
        {
            get => long_description_food;
            set => SetProperty(ref long_description_food, value);
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
