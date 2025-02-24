
namespace Pizza_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            toppings
            string[] toppingsAvailable = new string[] { "Mushrooms", "Basil", "Chicken", "Olives", "Pepperoni", "Sausage" }
            Console.WriteLine("How many toppings do you want?");
            int toppingsWanted = Convert.ToInt32(Console.ReadLine());
            int[]topping = new int[toppingsWanted];
            for (int i = 0; i < toppingsWanted; i++)
            {
               Console.WriteLine("What topping do you want?")
                   
                   if (Console.ReadLine()).Contains(toppingsAvailable)
                       toppings = Console.ReadLine()
                     else
                         Console.WriteLine("You have either added the same topping twice: choose another, or input an unavailable topping.")
                    
                   
            }
            char pizzaSize;
            float smallPizza = 2.50
            float medPizza = 4.50
            float largePizza = 7.25
            float toppingCost = 0.75
            float cost;
            Console.Write("What size pizza do you want? (S for small, M for medium, L for large)")
            cost = (toppingCost*toppingsWanted) + pizzaSize
                Console.WriteLine("The cost is: ") + cost

                

                
 
            //string[] toppings = new string[toppi];

        }
    }
}
