﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbucks
{
    public class Barrista : Person
    {
        public Inventory inventory;
        public Customer customer;

        public Barrista()
        {
            this.inventory = new Inventory();
            this.customer = new Customer();
        }
      
        //public  (bool isAvailable, decimal price) Greeting(string choice)
        //{
        //    if (this.inventory.drinks.Any(drink => drink.Name == choice))
        //    {
        //        Drink foundDrink = this.inventory.drinks.Where(drink => drink.Name == choice).First();
        //        return (true, foundDrink.Price);
        //    }
        //    return (false, 0);
        //}

        public (bool isAvailable, decimal price) Greeting(string choice)
        {
            //choice = this.customer.FavDrinks[0].Name;
            foreach (FavDrinks d in this.customer.FavDrinks)
            {
                choice = d.Name;
                if (this.inventory.drinks.Any(drink => drink.Name == choice))
                {
                    Drink foundDrink = this.inventory.drinks.Where(drink => drink.Name == choice).First();
                    return (true, foundDrink.Price);
                }
                //return (false, 0);
            }
            return (false, 0);
        }         

        public void Serve(List<FavDrinks> favDrinks)
        {

            Drink customerDrink = this.inventory.drinks.Where(drink => drink.Name == FavDrinks);
            this.inventory.drinks.Remove(customerDrink);
            Console.WriteLine($"{customerDrink} is served.");
            Console.ReadKey();
        }

        internal (bool isAvailable, decimal price) Greeting(List<FavDrinks> favDrinks)
        {
            return (false, 0);
        }
    }
}
