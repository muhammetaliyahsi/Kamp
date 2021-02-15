using System;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, LastName = "Demiroğ", Age = 32 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            Console.ReadLine();
        }
    }
    // Attribute verebiliyoruz
    [ToTable("Customers")]
    [ToTable("TblCustomers")]
    class Customer
    {
        public int Id { get; set; }
        // Girmek zorunda olduğumuz alan için böyle bir Attribute oluşturabiliyoruz.
        [RequiredProperty]
        public string FirstName { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }
    }

    class CustomerDal
    {
        // Fonksiyonun yeni versiyonu varsa eskisine bu attribute verilir
        [Obsolete("Don't use Add, instead use AddNew.")]
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!",
                customer.Id,customer.FirstName,customer.LastName,customer.Age);
        }

        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!",
                customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }
    // Attribute'u nerede nerede kullanabileceğimizi belirtiyoruz. Property,Class,All vs olabilir.
    // Birden fazla alan da verebiliyoruz.
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    class RequiredPropertyAttribute : Attribute
    {

    }
    // Aynı hedef üzerinde birden fazla kez aynı Attribute'u kullanma izni.
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class ToTableAttribute : Attribute
    {
        private string _tableName;

        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }

    }


}
