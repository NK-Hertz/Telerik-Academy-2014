namespace UsingCntrStructsAndLoops
{
    using System;
    public class Chef
    {
        private Bowl GetBowl()
        {
            //... 
        }
        private Potato GetPotato()
        {
            //...
        }
        private Carrot GetCarrot()
        {
            //...
        }
        private void Cut(Vegetable vegetable)
        {
            //...
        }
        private void Peel(Vegetable vegetable) 
        {
            //
        }
        public void Cook()
        {
            Potato potato = GetPotato();
            Peel(potato);
            Cut(potato);

            Bowl bowl = GetBowl();
            bowl.Add(potato);

            Carrot carrot = GetCarrot();
            Peel(carrot);
            Cut(carrot);
            bowl.Add(carrot);
        }
    }
}
