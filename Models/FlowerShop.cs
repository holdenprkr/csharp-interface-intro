using System.Collections.Generic;

namespace FlowerShop
{
    public class FlowerShop
    {
        public string Name { get; set; }

        public List<Rose> Roses = new List<Rose>();

        public List<Dandelion> Dandelions = new List<Dandelion>();

        public List<Sunflower> Sunflowers = new List<Sunflower>();

        public List<Violet> Violets = new List<Violet>();

        public List<IMothersDay> MakeMothersDayArrangement()
        {
            List<IMothersDay> Arrangement = new List<IMothersDay>();
            Arrangement.Add(new Rose());
            Arrangement.Add(new Rose());
            Arrangement.Add(new Violet());
            Arrangement.Add(new Violet());
            Arrangement.Add(new Violet());

            return Arrangement;
        }

        public List<IBirthDay> MakeBirthDayArrangement()
        {
            List<IBirthDay> Arrangement = new List<IBirthDay>();
            Arrangement.Add(new Dandelion());
            Arrangement.Add(new Dandelion());
            Arrangement.Add(new Sunflower());
            Arrangement.Add(new Sunflower());
            Arrangement.Add(new Sunflower());

            return Arrangement;
        }

        public List<IGetWell> MakeGetWellArrangement()
        {
            List<IGetWell> Arrangement = new List<IGetWell>();
            Arrangement.Add(new Tulip());
            Arrangement.Add(new Tulip());
            Arrangement.Add(new Tulip());

            return Arrangement;
        }

    }
}