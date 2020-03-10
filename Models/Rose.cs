namespace FlowerShop
{
    public class Rose : IMothersDay
    {
        public string Color { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Cost { get; set; }
        public string WaterSchedule { get; set; }
        public bool Thorny { get; set; }
        public bool Fragrant { get; set; }
        public double StemLength { get; set; }

        public override string ToString()
        {
            return $"A fanciful {Color} {Name}";
        }
    }
}