using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Study
{
    //referencia: https://www.c-sharpcorner.com/UploadFile/SukeshMarla/learn-design-pattern-builder-pattern/
    // acessado em 24/5/2019

    class Builder
    {
        public static void Main(string[] args)
        {
            /*AbstractHappyMeal objMealBuilder = new McAlooTikkiHappyMeal();
            Director2 objDirector = new Director2();
            HappyMeal objMeal = objDirector.GetHappyMeal(objMealBuilder);

            objMealBuilder = new McVeggieHappyMeal();
            objDirector = new Director2();
            objMeal = objDirector.GetHappyMeal(objMealBuilder);

            objMealBuilder = new ChickenMcGrillHappyMeal();
            objDirector = new Director2();
            objMeal = objDirector.GetHappyMeal(objMealBuilder);
            */
        }
    }
    public class HappyMeal { }
    public class McAlooTikkiHappyMeal { }
    public abstract class AbstractHappyMeal
    {
        internal HappyMeal happyMeal;
        public void CreateHappyMeal()
        {
            happyMeal = new HappyMeal();
        }
        public HappyMeal GetHappyMeal()
        {
            return happyMeal;
        }
        public abstract void AddBurger();
        public abstract void AddColdDrink();
        public abstract void AddToy();
    }

    public class ChickenMcGrillHappyMeal : AbstractHappyMeal
    {
        public override void AddBurger()
        {
            //happyMeal.Burger = new ChickenMcGrill();
        }
        public override void AddColdDrink()
        {
            //happyMeal.ColdDrink = new Coke();
        }
        public override void AddToy()
        {
            //happyMeal.Toy = new IceAgeToy();
        }
    }
    public class McVeggieHappyMeal : AbstractHappyMeal
    {
        public override void AddBurger()
        {
            //happyMeal.Burger = new McVeggie();
        }
        public override void AddColdDrink()
        {
            //happyMeal.ColdDrink = new Coke();
        }
        public override void AddToy()
        {
            //happyMeal.Toy = new IceAgeToy();
        }
    }

    public class Director2
    {
        public HappyMeal GetHappyMeal(AbstractHappyMeal HappyMealBuilder)
        {
            HappyMealBuilder.CreateHappyMeal();
            HappyMealBuilder.AddBurger();
            HappyMealBuilder.AddColdDrink();
            HappyMealBuilder.AddToy();
            return HappyMealBuilder.GetHappyMeal();
        }
    }
}
