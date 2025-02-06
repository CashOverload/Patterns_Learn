// Патерн "Декоратор" дозволяє динамічно додавати нову поведінку до об'єктів, обгортаючи їх в об'єкти-контейнери.

Pizza pizza1 = new ItalianPizza();
pizza1 = new TomatoPizza(pizza1);
Console.WriteLine("Name: {0}", pizza1.Name);
Console.WriteLine("Price: {0}", pizza1.GetCost());

Pizza pizza2 = new ItalianPizza();
pizza2 = new CheesePizza(pizza2);
Console.WriteLine("Name: {0}", pizza2.Name);
Console.WriteLine("Price: {0}", pizza2.GetCost());

Pizza pizza3 = new BulgerianPizza();
pizza3 = new TomatoPizza(pizza3);
pizza3 = new CheesePizza(pizza3);
Console.WriteLine("Name: {0}", pizza3.Name);
Console.WriteLine("Price: {0}", pizza3.GetCost());



abstract class Pizza
{
    public Pizza(string n)
    {
        this.Name = n;
    }
    public string Name { get; protected set; }
    public abstract int GetCost();
}

class ItalianPizza : Pizza
{
    public ItalianPizza() : base("Italian pizza")
    { }
    public override int GetCost()
    {
        return 10;
    }
}
class BulgerianPizza : Pizza
{
    public BulgerianPizza()
        : base("Bulgerian pizza")
    { }
    public override int GetCost()
    {
        return 8;
    }
}

abstract class PizzaDecorator : Pizza
{
    protected Pizza pizza;
    public PizzaDecorator(string n, Pizza pizza) : base(n)
    {
        this.pizza = pizza;
    }
}

class TomatoPizza : PizzaDecorator
{
    public TomatoPizza(Pizza p)
        : base(p.Name + ", with tomatoes", p)
    { }

    public override int GetCost()
    {
        return pizza.GetCost() + 3;
    }
}

class CheesePizza : PizzaDecorator
{
    public CheesePizza(Pizza p)
        : base(p.Name + ", with cheese", p)
    { }

    public override int GetCost()
    {
        return pizza.GetCost() + 5;
    }
}

/* У якості компонента тут виступає абстрактний клас Pizza, який визначає базову функціональність у вигляді властивості Name та методу GetCost(). 
Ця функціональність реалізується двома підкласами ItalianPizza та BulgerianPizza, у яких жорстко закодовані назва піци та її ціна.

Декоратором є абстрактний клас PizzaDecorator, який успадкований від класу Pizza і містить посилання на декорований об'єкт Pizza. 
На відміну від формальної схеми, тут встановлення декорованого об'єкта відбувається не в методі SetComponent, а в конструкторі.

Окремі функціональності—додавання томатів та сиру до піц—реалізовані через класи TomatoPizza та CheesePizza, які обгортають об'єкт Pizza і додають до його назви назву додатку, а до ціни—вартість додатку, тобто перевизначаючи метод GetCost та змінюючи значення властивості Name.

Завдяки цьому при створенні піци з додатками відбудеться її обгортання декоратором. 
Спочатку об'єкт BulgerianPizza обгортається декоратором TomatoPizza, а потім CheesePizza. 
І таких обгортань ми можемо зробити багато. Просто достатньо успадкувати від декоратора клас, який буде визначати додатковий функціонал.

А якби ми використовували наслідування, то в цьому випадку лише для двох видів піц з двома додатками нам довелося б створити вісім різних класів, які б описували всі можливі комбінації. 
Тому декоратори є більш переважним методом у цьому випадку.
*/