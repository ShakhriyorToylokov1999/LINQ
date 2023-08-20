using System;
using System.Collections.Generic;
using System.Linq;
using Task1.DoNotChange;

namespace Task1
{
    public static class LinqTask
    {
        public static IEnumerable<Customer> Linq1(IEnumerable<Customer> customers, decimal limit)
        {
            if (customers == null)
                throw new ArgumentNullException();
            return customers.Where(c => c.Orders.Sum(x => x.Total) > limit);
        }

        public static IEnumerable<(Customer customer, IEnumerable<Supplier> suppliers)> Linq2(
            IEnumerable<Customer> customers,
            IEnumerable<Supplier> suppliers
        )
        {

            if (customers == null || suppliers == null)
                throw new ArgumentNullException();
            return customers.Select(c => (customer: c, 
                                          suppliers: suppliers.Where(s =>s.Country == c.Country && s.City == c.City)));
        }

        public static IEnumerable<(Customer customer, IEnumerable<Supplier> suppliers)> Linq2UsingGroup(
            IEnumerable<Customer> customers,
            IEnumerable<Supplier> suppliers
        )
        {
            if (customers == null || suppliers == null)
                throw new ArgumentNullException();

            return customers.Select(c => (customer: c, suppliers: suppliers));
        }

        public static IEnumerable<Customer> Linq3(IEnumerable<Customer> customers, decimal limit)
        {
            if (customers == null)
                throw new ArgumentNullException();
            return customers.Where(c => c.Orders.Sum(x => x.Total) > limit).OrderByDescending(c=>c.Orders.Select(x=>x.OrderDate));
        }

        public static IEnumerable<(Customer customer, DateTime dateOfEntry)> Linq4(
            IEnumerable<Customer> customers
        )
        {
            if (customers == null)
                throw new ArgumentNullException();
            throw new NotImplementedException();
        }

        public static IEnumerable<(Customer customer, DateTime dateOfEntry)> Linq5(
            IEnumerable<Customer> customers
        )
        {
            if (customers == null)
                throw new ArgumentNullException();
            throw new NotImplementedException();
        }

        public static IEnumerable<Customer> Linq6(IEnumerable<Customer> customers)
        {
            if (customers == null)
                throw new ArgumentNullException();
            throw new NotImplementedException();
        }

        public static IEnumerable<Linq7CategoryGroup> Linq7(IEnumerable<Product> products)
        {
            /* example of Linq7result

             category - Beverages
	            UnitsInStock - 39
		            price - 18.0000
		            price - 19.0000
	            UnitsInStock - 17
		            price - 18.0000
		            price - 19.0000
             */
            if (products == null)
                throw new ArgumentNullException();
            throw new NotImplementedException();
        }

        public static IEnumerable<(decimal category, IEnumerable<Product> products)> Linq8(
            IEnumerable<Product> products,
            decimal cheap,
            decimal middle,
            decimal expensive
        )
        {
            if (products == null)
                throw new ArgumentNullException();
            throw new NotImplementedException();
        }

        public static IEnumerable<(string city, int averageIncome, int averageIntensity)> Linq9(
            IEnumerable<Customer> customers
        )
        {
            if (customers == null)
                throw new ArgumentNullException();
            throw new NotImplementedException();
        }

        public static string Linq10(IEnumerable<Supplier> suppliers)
        {
            if (suppliers == null)
                throw new ArgumentNullException();
            throw new NotImplementedException();
        }
    }
}