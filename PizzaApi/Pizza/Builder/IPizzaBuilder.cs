namespace PizzaApi.Pizza.Builder
{
    public interface IPizzaBuilder
    {
        void Reset();
        void SetSize(string size);
        void SetName(string name);
        void AddTopping(List<string> ingredients);
        void AddSauce();
        void AddCheese();
        void AddBase();
        CookPizza GetPizza();
    }
}
