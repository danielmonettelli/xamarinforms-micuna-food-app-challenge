namespace XF_MicunaFood.Models
{
    public class Food
    {
        public int Id { get; set; }
        public VarietyFood VarietyFoods { get; set; }
        public string Name_Food { get; set; }
        public string Image_Food { get; set; }
        public double Price_Food { get; set; }
        public string Short_Description_Food { get; set; }
        public string Long_Description_Food { get; set; }
    }

    public class VarietyFood
    {
        public string Name_VarietyFood { get; set; }
        public string Image_VarietyFood { get; set; }
    }
}
