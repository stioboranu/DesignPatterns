namespace AbstractFactoryDP
{
    // Abstract product interface
    interface IPizza
    {
        void Prepare();
        void Bake();
        void Cut();
        void Box();
    }

    // Concrete product: CheesePizza
    class CheesePizza : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing Cheese Pizza");
        }

        public void Bake()
        {
            Console.WriteLine("Baking Cheese Pizza");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting Cheese Pizza");
        }

        public void Box()
        {
            Console.WriteLine("Boxing Cheese Pizza");
        }
    }

    // Concrete product: PepperoniPizza
    class PepperoniPizza : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing Pepperoni Pizza");
        }

        public void Bake()
        {
            Console.WriteLine("Baking Pepperoni Pizza");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting Pepperoni Pizza");
        }

        public void Box()
        {
            Console.WriteLine("Boxing Pepperoni Pizza");
        }
    }

    // Abstract factory interface
    interface IPizzaFactory
    {
        IPizza CreatePizza();
    }

    // Concrete factory: CheesePizzaFactory
    class CheesePizzaFactory : IPizzaFactory
    {
        public IPizza CreatePizza()
        {
            return new CheesePizza();
        }
    }

    // Concrete factory: PepperoniPizzaFactory
    class PepperoniPizzaFactory : IPizzaFactory
    {
        public IPizza CreatePizza()
        {
            return new PepperoniPizza();
        }
    }

    // Pizza store
    class PizzaStore
    {
        private IPizzaFactory pizzaFactory;

        public PizzaStore(IPizzaFactory factory)
        {
            pizzaFactory = factory;
        }

        public void OrderPizza()
        {
            IPizza pizza = pizzaFactory.CreatePizza();

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
        }
    }

}
