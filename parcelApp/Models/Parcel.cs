namespace parcelApp.Models
{
    class Parcel
    {
        public int Weight { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }
        public int Volume { get; set; }
        public int Cost { get; set; }
        private static List<Parcel> packages = new List<Parcel>();

        public Parcel(int height, int width, int length, int weight)
        {
            Weight = weight;
            Height = height;
            Width = width;
            Length = length;
            packages.Add(this);
        }

        public static List<Parcel> GetAll()
        {
            return packages;
        }

        public void doubleWeight()
        {
            Weight = Weight * 2;
        }

        public void VolumeTotal()
        {
					Volume = Height * Width * Length;
        }


    }
}