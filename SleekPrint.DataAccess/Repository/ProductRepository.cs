﻿using SleekPrint.DataAccess.Data;
using SleekPrint.DataAccess.Repository.IRepository;
using SleekPrint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleekPrint.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Product obj)
        {
            _db.Products.Update(obj);
            /*above we are updating the whole object, but we can manualy update product by our own logic,
            that is why update is in ProductRepo so we implement logic with respect to product*/
            var objFromDb = _db.Products.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Title = obj.Title;
                //objFromDb.ISBN = obj.ISBN;
                objFromDb.Price = obj.Price;
                objFromDb.Price50 = obj.Price50;
                objFromDb.Price100 = obj.Price100;
                objFromDb.ListPrice = obj.ListPrice;
                objFromDb.Description = obj.Description;
                objFromDb.CategoryId = obj.CategoryId;
                //objFromDb.Author = obj.Author;
                objFromDb.ProductImages = obj.ProductImages;
                objFromDb.ArticalNumber = obj.ArticalNumber;
                //if (obj.ImageUrl != null) 
                //{
                //    objFromDb.ImageUrl = obj.ImageUrl;
                //}
            }
        }
    }
}
