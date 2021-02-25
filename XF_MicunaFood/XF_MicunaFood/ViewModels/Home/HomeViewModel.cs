using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using XF_MicunaFood.Models;
using XF_MicunaFood.ViewModels.Base;
using XF_MicunaFood.CodeFontIcons;
using MvvmHelpers;

namespace XF_MicunaFood.ViewModels.Home
{
    public class HomeViewModel : BaseViewModel
    {
        public ObservableRangeCollection<Food> Foods { get; set; }
        public ObservableRangeCollection<Category> Categories { get; set; }
        public ObservableRangeCollection<FoodsViewModel> DynamicFoods { get; set; }

        public HomeViewModel()
        {

            DynamicFoods = new ObservableRangeCollection<FoodsViewModel>();

            Categories = new ObservableRangeCollection<Category>
            {
                new Category
                {
                    Name_Category="Fast food",
                    Image_Category=MonettelliFontIcons.icon_fast_food_line
                },
                new Category
                {
                    Name_Category="Dessert",
                    Image_Category=MonettelliFontIcons.icon_dessert_line
                },
                new Category
                {
                    Name_Category="Beer",
                    Image_Category=MonettelliFontIcons.icon_beer_line
                },
                new Category
                {
                    Name_Category="Gourmet Food",
                    Image_Category=MonettelliFontIcons.icon_gourmet_food_line
                },

            };

            Foods = new ObservableRangeCollection<Food>
            {
                new Food
                {
                    Id=1,
                    VarietyFoods=new VarietyFood
                    {
                          Name_VarietyFood="Gourmet Food",
                          Image_VarietyFood=MonettelliFontIcons.icon_gourmet_food_line
                    },
                    Name_Food="Black ramen",
                    Image_Food="https://raw.githubusercontent.com/danielmonettelli/Area51/main/Foods/img_black_ramen.png",
                    Price_Food=30.00,
                    Short_Description_Food="Thick and milky broth with an intense flavor.",
                    Long_Description_Food="Our Hakata Black Ramen is a rich and thick stock tonkotsu ramen typical of the Hakata area, in Fukuoka (south of the country), which is made by cooking pork bones for hours to obtain a thick and milky broth with an intense flavor that is It is accompanied by strong flavors such as garlic or ginger, resulting in a powerful umami."
                },
                new Food
                {
                    Id=2,
                    VarietyFoods=new VarietyFood
                    {
                        Name_VarietyFood="Gourmet Food",
                        Image_VarietyFood=MonettelliFontIcons.icon_gourmet_food_line
                    },
                    Name_Food="Avocado of the gods",
                    Image_Food="https://raw.githubusercontent.com/danielmonettelli/Area51/main/Foods/img_avocado_of_the_gods.png",
                    Price_Food=14.00,
                    Short_Description_Food="Whole wheat toast with avocado cream and boiled egg.",
                    Long_Description_Food="From time to time we also like to have toast for breakfast. And since we know that many of you do not know very well what to accompany them, here is an idea of ​​a complete and healthy breakfast: whole wheat toast with avocado cream and boiled egg, the perfect combination to fill you with energy."
                },
                new Food
                {
                    Id=3,
                    VarietyFoods=new VarietyFood
                    {
                      Name_VarietyFood="Gourmet Food",
                      Image_VarietyFood=MonettelliFontIcons.icon_gourmet_food_line
                    },
                    Name_Food="Arctic salad",
                    Image_Food="https://raw.githubusercontent.com/danielmonettelli/Area51/main/Foods/img_arctic_salad.png",
                    Price_Food=26.99,
                    Short_Description_Food="Lorem ipsum dolor sit amet",
                    Long_Description_Food="Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum."
                },
                new Food
                {
                    Id=4,
                    VarietyFoods=new VarietyFood
                    {
                        Name_VarietyFood="Gourmet Food",
                        Image_VarietyFood=MonettelliFontIcons.icon_gourmet_food_line
                    },
                    Name_Food="Vegetable streaky",
                    Image_Food="https://raw.githubusercontent.com/danielmonettelli/Area51/main/Foods/img_vegetable_streaky.png",
                    Price_Food=19.55,
                    Short_Description_Food="Lorem ipsum dolor sit amet",
                    Long_Description_Food="Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum."
                },
                new Food
                {
                    Id=5,
                    VarietyFoods=new VarietyFood
                    {
                        Name_VarietyFood="Gourmet Food",
                        Image_VarietyFood=MonettelliFontIcons.icon_gourmet_food_line
                    },
                    Name_Food="Pumpkin cream",
                    Image_Food="https://raw.githubusercontent.com/danielmonettelli/Area51/main/Foods/img_pumpkin_cream.png",
                    Price_Food=27.55,
                    Short_Description_Food="Lorem ipsum dolor sit amet",
                    Long_Description_Food="Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum."
                },
                new Food
                {
                    Id=6,
                    VarietyFoods=new VarietyFood
                    {
                        Name_VarietyFood="Gourmet Food",
                        Image_VarietyFood=MonettelliFontIcons.icon_gourmet_food_line
                    },
                    Name_Food="Paradise salad",
                    Image_Food="https://raw.githubusercontent.com/danielmonettelli/Area51/main/Foods/img_paradise_salad.png",
                    Price_Food=24.75,
                    Short_Description_Food="Lorem ipsum dolor sit amet",
                    Long_Description_Food="Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum."
                },
                new Food
                {
                    Id=7,
                    VarietyFoods=new VarietyFood
                    {
                        Name_VarietyFood="Gourmet Food",
                        Image_VarietyFood=MonettelliFontIcons.icon_gourmet_food_line
                    },
                    Name_Food="Fruit salad",
                    Image_Food="https://raw.githubusercontent.com/danielmonettelli/Area51/main/Foods/img_fruit_salad.png",
                    Price_Food=19.15,
                    Short_Description_Food="Lorem ipsum dolor sit amet",
                    Long_Description_Food="Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum."
                },
                new Food
                {
                    Id=8,
                    VarietyFoods=new VarietyFood
                    {
                        Name_VarietyFood="Fast food",
                        Image_VarietyFood=MonettelliFontIcons.icon_fast_food_line
                    },
                    Name_Food="Cheese Shack Burger",
                    Image_Food="https://raw.githubusercontent.com/danielmonettelli/Area51/main/Fast_Foods/img_cheese_shack_burger.png",
                    Price_Food=5.99,
                    Short_Description_Food="Lorem ipsum dolor sit amet",
                    Long_Description_Food="Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum."
                },
                new Food
                {
                    Id=9,
                    VarietyFoods=new VarietyFood
                    {
                        Name_VarietyFood="Fast food",
                        Image_VarietyFood=MonettelliFontIcons.icon_fast_food_line
                    },
                    Name_Food="Patty Bun",
                    Image_Food="https://raw.githubusercontent.com/danielmonettelli/Area51/main/Fast_Foods/img_patty_bun.png",
                    Price_Food=8.99,
                    Short_Description_Food="Lorem ipsum dolor sit amet",
                    Long_Description_Food="Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum."
                },
                new Food
                {
                    Id=10,
                    VarietyFoods=new VarietyFood
                    {
                        Name_VarietyFood="Fast food",
                        Image_VarietyFood=MonettelliFontIcons.icon_fast_food_line
                    },
                    Name_Food="Vegetarian Hamburger",
                    Image_Food="https://raw.githubusercontent.com/danielmonettelli/Area51/main/Fast_Foods/img_vegetarian_hamburger.png",
                    Price_Food=12.59,
                    Short_Description_Food="Lorem ipsum dolor sit amet",
                    Long_Description_Food="Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum."
                },
                new Food
                {
                    Id=11,
                    VarietyFoods=new VarietyFood
                    {
                        Name_VarietyFood="Dessert",
                        Image_VarietyFood=MonettelliFontIcons.icon_dessert_line
                    },
                    Name_Food="Chocolate Gradient",
                    Image_Food="https://raw.githubusercontent.com/danielmonettelli/Area51/main/Ice_Creams/img_chocolate_gradient.png",
                    Price_Food=12.49,
                    Short_Description_Food="Lorem ipsum dolor sit amet",
                    Long_Description_Food="Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum."
                },
                new Food
                {
                    Id=12,
                    VarietyFoods=new VarietyFood
                    {
                        Name_VarietyFood="Dessert",
                        Image_VarietyFood=MonettelliFontIcons.icon_dessert_line
                    },
                    Name_Food="Creamy Fusion",
                    Image_Food="https://raw.githubusercontent.com/danielmonettelli/Area51/main/Ice_Creams/img_creamy_fusion.png",
                    Price_Food=16.89,
                    Short_Description_Food="Lorem ipsum dolor sit amet",
                    Long_Description_Food="Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum."
                },
                new Food
                {
                    Id=13,
                    VarietyFoods=new VarietyFood
                    {
                        Name_VarietyFood="Dessert",
                        Image_VarietyFood=MonettelliFontIcons.icon_dessert_line
                    },
                    Name_Food="Magic Cone",
                    Image_Food="https://raw.githubusercontent.com/danielmonettelli/Area51/main/Ice_Creams/img_magic_cone.png",
                    Price_Food=27.49,
                    Short_Description_Food="Lorem ipsum dolor sit amet",
                    Long_Description_Food="Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum."
                },
                new Food
                {
                    Id=14,
                    VarietyFoods=new VarietyFood
                    {
                        Name_VarietyFood="Dessert",
                        Image_VarietyFood=MonettelliFontIcons.icon_dessert_line
                    },
                    Name_Food="Sweet Oasis",
                    Image_Food="https://raw.githubusercontent.com/danielmonettelli/Area51/main/Ice_Creams/img_sweet_oasis.png",
                    Price_Food=32.59,
                    Short_Description_Food="Lorem ipsum dolor sit amet",
                    Long_Description_Food="Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum."
                },
                new Food
                {
                    Id=15,
                    VarietyFoods=new VarietyFood
                    {
                        Name_VarietyFood="Beer",
                        Image_VarietyFood=MonettelliFontIcons.icon_beer_line
                    },
                    Name_Food="Bintang",
                    Image_Food="https://raw.githubusercontent.com/danielmonettelli/Area51/main/Beers/img_bintang.png",
                    Price_Food=5.59,
                    Short_Description_Food="Lorem ipsum dolor sit amet",
                    Long_Description_Food="Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum."
                },
                new Food
                {
                    Id=16,
                    VarietyFoods=new VarietyFood
                    {
                        Name_VarietyFood="Beer",
                        Image_VarietyFood=MonettelliFontIcons.icon_beer_line
                    },
                    Name_Food="Carlsberg",
                    Image_Food="https://raw.githubusercontent.com/danielmonettelli/Area51/main/Beers/img_carlsberg.png",
                    Price_Food=4.99,
                    Short_Description_Food="Lorem ipsum dolor sit amet",
                    Long_Description_Food="Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum."
                },
                new Food
                {
                    Id=17,
                    VarietyFoods=new VarietyFood
                    {
                        Name_VarietyFood="Beer",
                        Image_VarietyFood=MonettelliFontIcons.icon_beer_line
                    },
                    Name_Food="Corona",
                    Image_Food="https://raw.githubusercontent.com/danielmonettelli/Area51/main/Beers/img_corona.png",
                    Price_Food=9.99,
                    Short_Description_Food="Lorem ipsum dolor sit amet",
                    Long_Description_Food="Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum."
                },
            };
        }

        public void GetItemsForCategory(string obj, bool isSelected)
        {
            DynamicFoods.Clear();

            var items = Foods.Where(f => f.VarietyFoods.Name_VarietyFood.Contains(obj)).ToList();

            if (isSelected == true)
                foreach (var item in items)
                {
                    DynamicFoods.Add(new FoodsViewModel(item));
                }
        }
    }
}