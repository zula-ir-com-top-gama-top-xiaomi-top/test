using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class ProductsApplication
    {
        public List<DAL.ProductModel> Get()
        {
            //Create Instance from Model
            List<DAL.ProductModel> ProductsList = new List<DAL.ProductModel>();

            //Create Data
            DAL.ProductModel Product1 = new DAL.ProductModel();
            Product1.Title = "iPhone 13";

            DAL.ProductModel Product2 = new DAL.ProductModel();
            Product2.Title = "iPhone 14";


            ProductsList.Add(Product2);
            ProductsList.Add(Product1);

            return ProductsList;
        }
    }
}
