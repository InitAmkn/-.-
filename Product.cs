
namespace НОНТОН.РФ
{
    // структура Product, id - уникальный номер продукта, name - наименование
    class Product
    {
        public string? id { set; get; }
        public string? name { set; get; }

        public Product(string id, string name) { 
            this.id = id;
            this.name = name;
        }

        public override string ToString()
        {
           return $"{id} - {name}";
        }
    }
}
