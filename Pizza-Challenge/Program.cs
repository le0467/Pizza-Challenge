
namespace Pizza_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string toppings;
            string[] toppingsAvailable = new string[] { "Mushrooms", "Basil", "Chicken", "Olives", "Pepperoni", "Sausage" }
            Console.WriteLine("How many toppings do you want?");
            int toppingsWanted = Convert.ToInt32(Console.ReadLine());
            int[]topping = new int[toppingsWanted];
            for (int i = 0; i < toppingsWanted; i++)
            {
                Console.WriteLine("What topping do you want?"); 

                if (Console.ReadLine())toppingsAvailable);
                toppings = Console.ReadLine();
                     else
                    Console.WriteLine("You have either added the same topping twice: choose another, or input an unavailable topping.");
                    
                   
            }
            int pizzaSize;
            float smallPizza = 2.50f;
            float medPizza = 4.50f;
            float largePizza = 7.25f;
            float toppingCost = 0.75f;
            float cost;
            Console.Write("What size pizza do you want? (S for small, M for medium, L for large)")
            pizzaSize = Convert.ToInt32(Console.ReadLine());
            if (pizzaSize == 'S') {
                pizzaSize = Convert.ToInt32(smallPizza)
                    
                    }

            cost = (toppingCost * toppingsWanted) + pizzaSize;
               Console.WriteLine("The cost is: ") + cost;

                

                
 
            //string[] toppings = new string[toppi];

        }
    }
}
