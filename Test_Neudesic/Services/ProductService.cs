using System.Collections.Generic;
using System.Linq;
using Test_Neudesic.Models;

namespace Test_Neudesic.Services
{
    public class ProductService : IProductService
    {
      private readonly ProductContext _productContext;
        
        public ProductService(ProductContext productContext)
        {
            _productContext = productContext;
        }
        public void DeleteItem(int id)
        {
            var item = _productContext.Items.FirstOrDefault(x => x.ItemId == id);
            if (item!= null)
            {
                _productContext.Items.Remove(item);
                _productContext.SaveChanges();
            }
               
        }

        public string GetItem(int id)
        {
            var item = _productContext.Items.Include("Category").FirstOrDefault(x => x.ItemId == id);
            return item?.Description;
        }

        public List<KeyValuePair<int, string>> GetItems()
        {
            var prds = _productContext.Items.ToList();
            if(prds.Any())
                return prds.Select(x => new KeyValuePair<int,string>(x.ItemId, x.Description)).ToList();
            return null;
        }

        public void InsertItem(string desc)
        {
            var category = _productContext.Categories.FirstOrDefault(x => x.Id == 2);
            if(category==null)
             category = new Category() { Id = 2, Name = "Human" };
            var item = new Item() { Description = desc, Category = category };
            _productContext.Items.Add(item);
            _productContext.SaveChanges();
         
               
        }

        public void UpdateItem(int id, string desc)
        {
            var item = _productContext.Items.FirstOrDefault(x => x.ItemId == id);
            if (item != null)
            {
                item.Description = desc;
                _productContext.SaveChanges();
            }
        }
    }

      
    }