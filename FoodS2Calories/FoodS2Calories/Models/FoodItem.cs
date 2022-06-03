using SQLite;

namespace FoodS2Calories
{
    public class FoodItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public double Notes { get; set; }

        public double Lipids { get; set; }

        public double Glicids { get; set; }

        public double Weight { get; set; }

        public int Exist {
            get
            {
                return 1;
            }
        }

        public double Total
        {
            get
            {
                
                return ((Lipids*4 + Glicids*9 + Notes*4) * Weight /100) ;
            }
        }


        public bool Done { get; set; }

        public bool Units { get; set; }

    }
}

