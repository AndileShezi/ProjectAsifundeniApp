using NguniLearning2.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bashana.Services.Interface
{
    interface IDatabase
    {

        Task<int> UpdateProduct(UserDetails userDetails);

        Task<List<UserDetails>> GetSortedData();


    }
}
