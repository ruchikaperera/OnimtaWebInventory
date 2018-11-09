using OnimtaWebInventory.Core.IRepository;
using OnimtaWebInventory.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnimtaWebInventory.Repository
{
   public class TestRepository :ITestRepository
    {

        public async Task<TestModel> GetTestServicesByIdAsync(int applicationUserId)
        {
            TestModel testModel = new TestModel();
            testModel.UserName = "John";
            testModel.Id = 1;

            return testModel;
        }
    }
}
