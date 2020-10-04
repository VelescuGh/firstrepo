using System;
using System.Collections.Generic;
using System.Text;
//Model the Product class knowing that:
//a product has a weight
//has a name
//a production date
//an expiration date
//it has a producer
//and it can be in one of categories : Dairy, Fruit, Beverages, Bread
//we also knoow that it expires differently based on the category it belongs to:
//fruits expire in 2 days
//beverages expire in 3 years
//dairy expire in 1 week
//bread expires in 4 days

namespace Product
{
    class Product
    {
       
        private int weightProduct;
        private string nameProduct;
        private Category categoryProduct;
        private string producerProduct;
        private DateTime productionDate;
        private DateTime expirationDate;
        
         
        public Product  (string name, int weight, Category category, DateTime productionDate,  string producer)
        {
            
            nameProduct = name;
            weightProduct = weight;
            categoryProduct = category;
            this.productionDate = productionDate;
            producerProduct = producer;

        }
        public int WeightProduct { get { return weightProduct; }  }
        public string NameProduct { get { return nameProduct; } }
        public DateTime PrductionDate { get { return productionDate; } }
        public string ProducerProduct { get { return producerProduct; } }
        public DateTime ExpirationDate
        {
            get
            {
                if (categoryProduct==Category.Dairy)
                {
                    expirationDate = productionDate.AddDays(7);
                }
                else
                {
                    if (categoryProduct==Category.Fruit)
                    {
                        expirationDate = productionDate.AddDays(2);
                    }
                    else
                    {
                        if (categoryProduct==Category.Beverages)
                        {
                            expirationDate = productionDate.AddYears(3);
                        }
                        else
                        {
                            expirationDate = productionDate.AddDays(4);
                        }
                    }
                }
                return expirationDate;
            }
        }
    }
    public enum Category
    {
        Dairy, 
        Fruit, 
        Beverages, 
        Bread,
    }
}
