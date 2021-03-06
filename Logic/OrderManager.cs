using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DataModel;
using Microsoft.EntityFrameworkCore;

namespace Logic
{
    public class OrderManager
    {

        private MyContext _context;

        public OrderManager(MyContext context)
        {
            _context = context;
        }
        //get all orders
        public List<Invoice> GetAllOrders()
        {
            List<Invoice> orders = _context.Orders.ToList();

            return orders;
        }
        //get all orders from one account
        public List<Invoice> GetAllOrdersFromAccount(int id)
        {
            List<Invoice> orders = _context.Orders.Where(x=>x.Customer.User.Id == id).ToList();

            return orders;
        }
         //get one order
         public Invoice GetOrder(int id)
        {
            Invoice order = new Invoice();
            order = (Invoice)_context.Orders.Where(x=>x.Id == id);
            order.InvoiceLines = _context.OrderLines.Where(x => x.Order.Id == id).ToList();

            return order;
        }
        //update order
        public void UpdateOrder(int invoiceId,DataModel.Enum.Status status)
        {
            Invoice invoice = _context.Orders
                .Where(x=>x.Id == invoiceId).FirstOrDefault();

            invoice.Status = status;
            _context.Orders.Update(invoice);
            _context.SaveChanges();
        }

        public void CreateOrder(Customer customer, List<Product> products)
        {
            Invoice invoice = new Invoice();
            InvoiceLine invoiceLine = new InvoiceLine();
            foreach (Product item in products)
            {
               invoiceLine.Name = item.Name;
               invoiceLine.Product = item;
               invoiceLine.Quantity = item.Quantity;
               invoiceLine.Sellprice = item.SellPrice;
                invoice.InvoiceLines = (ICollection<InvoiceLine>)invoiceLine;
            }
            _context.Orders.Add(invoice);
        }
    }
}
