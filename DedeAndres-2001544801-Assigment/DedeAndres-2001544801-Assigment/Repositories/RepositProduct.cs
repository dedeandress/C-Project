using DedeAndres_2001544801_Assigment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DedeAndres_2001544801_Assigment.Repositories
{
    public class RepositProduct
    {
        static DatabaseEntities1 de = new DataBaseEntities1();

        public static List<Product> getAll()
        {
            return de.Products.ToList();
        }

        public static Product getProduct(int id) {
            Product searchProduct = (from x in de.Products where x.Id == id select x).FirstOrDefault();
            return searchProduct;
        }

        public static int insertProduct(Product newProduct)
        {
            de.Products.Add(newProduct);
            return de.SaveChanges();
        }

        public static int updateProduct(int Id, Product newProduct)
        {
            Product oldProduct = de.Products.Find(Id);
            oldProduct.WatchName = newProduct.WatchName;
            oldProduct.WatchPic = newProduct.WatchPic;
            oldProduct.WatchPrice = newProduct.WatchPrice;
            oldProduct.Stock = newProduct.Stock;
            return de.SaveChanges();
        }

        public static int deleteProduct(int id)
        {
            Product oldProduct = de.Products.Find(id);
            de.Products.Remove(oldProduct);

            return de.SaveChanges();
        }

       
    }
}