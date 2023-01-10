namespace draft
{
    class Cars
    {
        public enum Colors { NULL, Red, Black, White, Khaki};

        public int YearOfManufacturing{
            private set; get;
        }

        public int Price
        {
            private set; get;
        }

        public string Mark
        {
            private set; get;
        }

        public Colors Color
        {
            private set; get;
        }

        public Cars(string mark, int price, int yearOfManufacturing, Colors color)
        {
            Mark = mark;
            Price = price;
            YearOfManufacturing = yearOfManufacturing;
            Color = color;
        }
    }
}
