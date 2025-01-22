namespace BlazingPizza.Data;

public class PizzaService
{
    public async Task<Pizza[]> GetPizzasAsync()
    {
        // intentional delay for async call
        await Task.Delay(5000);

        var pizzas = new List<Pizza>
        {
            new Pizza { 
                Id = 1, 
                OrderId = 53511,
                Special = new PizzaSpecial { Name = "The Baconatorizor", BasePrice =  11.99M, Description = "It has EVERY kind of bacon", ImageUrl="img/pizzas/bacon.jpg"},
            },
        };

        return pizzas.ToArray();
    }
}