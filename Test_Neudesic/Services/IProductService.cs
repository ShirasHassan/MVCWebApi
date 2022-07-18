using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Neudesic.Services
{
    public interface IProductService
    {
        List<KeyValuePair<int,string>> GetItems();
        string GetItem(int id);
        void UpdateItem(int id,string desc);
        void DeleteItem(int id);
        void InsertItem(string desc);

    }
}
