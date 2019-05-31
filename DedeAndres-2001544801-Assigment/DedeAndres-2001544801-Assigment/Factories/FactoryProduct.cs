using DedeAndres_2001544801_Assigment.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DedeAndres_2001544801_Assigment.Factories
{
    public class FactoryProduct
    {
        public static Product createProduct(string watchName, int watchPrice, int stock, string watchPic) {
            return new Product()
            {
                WatchName=watchName,
                WatchPrice=watchPrice,
                WatchPic=watchPic,
                Stock=stock
            };
        }
    }
}