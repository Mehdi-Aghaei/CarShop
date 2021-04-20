using System;
using System.Collections.Generic;
using System.Text;

namespace CarStoreCommonLibrary
{
    public class Store
    {
        public List<Car> CarList { get; set; }
        public List<Car> ShoppingList { get; set; }
        public Store()
        {
            CarList = new List<Car>();
            ShoppingList = new List<Car>();
    
        }
        public decimal CheckOut()
        {
            decimal totalCost = 0;
            foreach (Car cars in ShoppingList)
            {
                totalCost += cars.Price;
            }
            ShoppingList.Clear();
            return totalCost;
        }
    }
}
