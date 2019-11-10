using System.Collections.Generic;
using System.Linq;
using Library.DAL;
using Library.Models;

namespace Library.Services
{
    class OrderService
    {
        private readonly LibraryContext _libraryContext;
        public OrderService()
        {
            _libraryContext = new LibraryContext();
        }
        public void Add(Order order)//adding given order
        {
            _libraryContext.Orders.Add(order);
            _libraryContext.SaveChanges();
        }

        public void Delete(Order order)//deleting given order
        {
            _libraryContext.Orders.Remove(order);
            _libraryContext.SaveChanges();
        }

        public List<Order> Orders()//brings the all orders
        {
            return _libraryContext.Orders.Include("Book").Include("Client").ToList();
        }
        public Order Find(int id)//find the order according to given id
        {
            Order order = _libraryContext.Orders.Include("Book").FirstOrDefault(b=>b.Id==id);
            return order;
        }
        public void Update(Order order)//updating given order
        {
            _libraryContext.Entry(order).State = System.Data.Entity.EntityState.Modified;
            _libraryContext.SaveChanges();
        }
    }
}
