using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DomoMeteoXamarin.Services
{
    interface IDomoticzAPI
    {
        Task<List<T>> GetAsync<T>(string url);
    }
}
