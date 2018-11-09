using OnimtaWebInventory.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnimtaWebInventory.Core.IRepository
{
    public interface ITestRepository
    {
        Task<TestModel> GetTestServicesByIdAsync(int userId);

    }
}
