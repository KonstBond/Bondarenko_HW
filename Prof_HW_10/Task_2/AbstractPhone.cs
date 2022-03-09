using System;


namespace Task_2
{
    public abstract class AbstractPhone
    {
        public void Phone()
        {
            ResourceProvider();
            Manufacturer();
            SalesMarket();
        }

        protected abstract void ResourceProvider();
        protected abstract void Manufacturer();
        protected abstract void SalesMarket();
    }
}
