using AbstractFactoryDP;

//PizzaStore store = new PizzaStore();
//store.OrderPizza("cheese");
//store.OrderPizza("pepperoni");

IPizzaFactory cheesePizzaFactory = new CheesePizzaFactory();
IPizzaFactory pepperoniPizzaFactory = new PepperoniPizzaFactory();
PizzaStore store = new PizzaStore(cheesePizzaFactory);
store.OrderPizza();
store = new PizzaStore(pepperoniPizzaFactory);
store.OrderPizza();


//// Product interface
//interface IPizza
//{
//    void Prepare();
//    void Bake();
//    void Cut();
//    void Box();
//}

//// Concrete product: CheesePizza
//class CheesePizza : IPizza
//{
//    public void Prepare()
//    {
//        Console.WriteLine("Preparing Cheese Pizza");
//    }

//    public void Bake()
//    {
//        Console.WriteLine("Baking Cheese Pizza");
//    }

//    public void Cut()
//    {
//        Console.WriteLine("Cutting Cheese Pizza");
//    }

//    public void Box()
//    {
//        Console.WriteLine("Boxing Cheese Pizza");
//    }
//}

//// Concrete product: PepperoniPizza
//class PepperoniPizza : IPizza
//{
//    public void Prepare()
//    {
//        Console.WriteLine("Preparing Pepperoni Pizza");
//    }

//    public void Bake()
//    {
//        Console.WriteLine("Baking Pepperoni Pizza");
//    }

//    public void Cut()
//    {
//        Console.WriteLine("Cutting Pepperoni Pizza");
//    }

//    public void Box()
//    {
//        Console.WriteLine("Boxing Pepperoni Pizza");
//    }
//}

//// Pizza store
//class PizzaStore
//{
//    public void OrderPizza(string type)
//    {
//        IPizza pizza;
//        if (type == "cheese")
//        {
//            pizza = new CheesePizza();
//        }
//        else if (type == "pepperoni")
//        {
//            pizza = new PepperoniPizza();
//        }
//        else
//        {
//            throw new ArgumentException($"Invalid pizza type: {type}");
//        }

//        pizza.Prepare();
//        pizza.Bake();
//        pizza.Cut();
//        pizza.Box();
//    }
//}
