using System.Collections.Generic;
using System.Linq;

namespace gonzo.SOLID
{
    #region single responsibility
    //На каждый объект должна быть возложена одна единственная обязанность
    //конкретный класс должен решать конкретную задачу

    //BAD

    //class Order
    //{
    //    public class Item
    //    {
    //        public decimal Sum;
    //    }

    //    public List<Item> Items;
    //    public decimal TotalSum
    //    {
    //        get { return Items.Sum(item => item.Sum); }
    //    }

    //    public void Print() {/*...*/}
    //    public void Show() {/*...*/}

    //    public void Load() {/*...*/}
    //    public void Save() {/*...*/}
    //    public void Update() {/*...*/}
    //    public void Delete() {/*...*/}
    //}

    //GOOD

    class Order
    {
        public class Item
        {
            public decimal Sum;
        }

        public List<Item> Items;
        public decimal TotalSum
        {
            get { return Items.Sum(item => item.Sum); }
        }
    }

    //class OrderRepository
    //{
    //    public void Load() {/*...*/}
    //    public void Save() {/*...*/}
    //    public void Update() {/*...*/}
    //    public void Delete() {/*...*/}
    //}

    class OrderViewer
    {
        public void Print() {/*...*/}
        public void Show() {/*...*/}
    }

    #endregion

    #region open-closed
    //программные сущности должны быть открыты для расширения, но закрыты для модификации
    //все классы должны проектироваться так, чтобы для изменения их поведения, нам не нужно было изменять их исходный код

    //BAD

    //OrderRepository: Load, Save, Update, Delete хардкодинг реализации, а есть возможность грузить заказы из различных источников

    //GOOD

    interface IOrderSource
    {
        void Load();
        void Save();
        void Update();
        void Delete();
    }

    class OrderRepository
    {
        private IOrderSource _source;
        public IOrderSource Source { set { _source = value; } }

        public void Load()
        {
            _source.Load();
        }
        public void Save() {/*...*/}
        public void Update() {/*...*/}
        public void Delete() {/*...*/}
    }

    #endregion

    #region Liskov substitution
    //Объекты в программе могут быть заменены их наследниками без изменения свойств программы
    //при использовании наследника класса результат выполнения кода должен быть предсказуем и неизменен

    //Предусловия не могут быть усилены в подклассе.
    //(что должно быть выполнено вызывающей стороной перед вызовом метода)

    //Постусловия не могут быть ослаблены в подклассе.
    //(что гарантируется вызываемым методом)

    //BAD

    //GOOD

    #endregion

    #region interface segregation
    //Много специализированных интерфейсов лучше, чем один универсальный

    enum ItemConditions
    {
        Good,
        Bad
    }

    enum Colors
    {
        Red,
        Green,
        Blue
    }

    //BAD

    //interface IItem
    //{
    //    void ApplyDiscount();
    //    void ApplyPromocode();

    //    Colors Color { get; set; }
    //    int Size { get; set; }

    //    ItemConditions Condition { get; set; }
    //    decimal Price { get; set; }
    //}

    //GOOD

    interface IItem
    {
        ItemConditions Condition { get; set; }
        decimal Price { get; set; }
    }

    interface IClothes
    {
        Colors Color { get; set; }
        int Size { get; set; }
    }

    interface IDiscountable
    {
        void ApplyDiscount();
        void ApplyPromocode();
    }

    #endregion

    #region dependency inversion
    //Зависимости внутри системы строятся на основе абстракций.
    //Модули верхнего уровня не зависят от модулей нижнего уровня.
    //Абстракции не должны зависеть от деталей. Детали должны зависеть от абстракций

    //BAD

    class Customer
    {
        public Order CurrentOrder { get; set; }

        public void BuyItems()
        {
            if (CurrentOrder != null)
            {
                var processor = new OrderProcessor();
                processor.CheckOut(CurrentOrder);
            }
        }

        public void AddItem(Order.Item item)
        {
            if (CurrentOrder == null)
            {
                CurrentOrder = new Order();
            }
            CurrentOrder.Items.Add(item);
        }

        public void DeleteItem(Order.Item item)
        {
            if (CurrentOrder != null)
            {
                CurrentOrder.Items.Remove(item);
            }
        }
    }

    class OrderProcessor
    {
        public void CheckOut(Order order) {/*...*/}
    }

    //GOOD

    //заменить OrderProcessor интерфейсом IOrderProcessor, чтобы Customer зависел от интерфейса, а не от реализации

    #endregion
}
