using System.Text;

namespace НОНТОН.РФ
{
    // задание необходимо выполнить на любом C-подобном языке
    // в задаче нельзя использовать базы данных или любые другие библиотеки
    // В целом вы не ограничены в реализации, только использовать стандартные структуры данных sdk

    // необходимо реализовать все 4 функции в классе ProductsImpl
    // реализацию писать в теле самих функций
    // вы в праве добавлять необходимые вам структуры данных в класс

    //класс для реализации 4 функций
    class ProductsImpl
    {
        private List<Product> products = new List<Product>();
        //добавляет новый продукт
        // возвращает true - если продукта с таким id еще не было
        // возвращает false - если был такой id, вставка отменяется
        public bool addProduct(Product product)
        {
            if (product == null) return false;
            //реализация
            foreach (Product item in products)
            {
                if (item.id == product.id)
                {
                    return false;
                }
            }
            products.Add(product);
            return true;
        }

        //Удаляет продукт
        // возвращает true - если продукт с таким id был
        // возвращает false - если id не было, (удаления не происходит)
        public bool deleteProduct(Product product)
        {
            if (product == null) return false;
            // реализация
            foreach (Product item in products)
            {
                if (item.id == product.id)
                {
                    products.Remove(item);
                    return true;
                }
            }
            return false;
        }


        //Получает имя (name) продукта
        // возвращает name продукта у которого идентификатор равен (=) id
        // если продукта нет, вернуть пустую строку ""
        public string getName(String id)
        {
            // реализация

            foreach (Product item in products)
            {
                if (item.id == id && item.name!= null)
                {
                    return item.name;
                }
            }
            return "";
        }


        //возвращает массив (список) идентификаторов (id)
        // У которых наименование равно (=) name
        // Если таких нет, возвращается пустой массив (список)
        public List<String> findByName(String name)
        {

            List<String>listId = new List<String>();
            foreach (Product item in products)
            {
                if (item.name == name && item.id != null)
                {
                    listId.Add(item.id);
                }
            }
            return listId;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Product item in products)
            {
                sb.Append(item);
                sb.Append("\n");
            }
            return sb.ToString();
        }
    }

    // данный пример показан на языке dart
    // Если вы будете реализовывать на других языка - вы в праве поменять типы на аналогичные в вашей sdk
    // Но только на аналогичные
}
