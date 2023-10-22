namespace OpenClose
{
    public class Program
    {
        static void Main(string[] args)
        {
            ListProduct listProduct = new ListProduct();
            listProduct.AddProduct(new Product("HP", 10));
            listProduct.AddProduct(new Product("Dell", 8));
            listProduct.AddProduct(new Product("Lenovo", 15));
            listProduct.AddProduct(new Product("Thinkpad", 6));
            listProduct.AddProduct(new Product("Samsung", 20));
            listProduct.AddProduct(new Product("Iphone", 18));

            PrintProductList(listProduct);
            Console.WriteLine();

            listProduct.Sort(new ProductComparatorByPrice());
            PrintProductList(listProduct);

            Console.WriteLine();
            listProduct.Sort(new ProductComparatorByName());
            PrintProductList(listProduct);

        }

        public static void PrintProductList(ListProduct listProduct)
        {
            for(int i =0; i< listProduct.GetCount(); i++)
            {
                Product product = listProduct.get(i);
                Console.WriteLine(product.GetName()+"    "+product.GetPrice());
            }
        }
    }
}