using System;

namespace Lib.Restaurant
{
    public class MealBuilder
    {
        public Meal BuildVegMeal()
        {
            Meal meal = new Meal();
            meal.AddItem(new VegBurger());
            meal.AddItem(new Coke());
            return meal;
        }
    }
}
