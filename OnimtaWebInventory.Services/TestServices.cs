using OnimtaWebInventory.Core.IRepository;
using OnimtaWebInventory.Core.IServices;
using OnimtaWebInventory.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnimtaWebInventory.Services
{
   public class TestServices :ITestServices
    {

        //private readonly ILogger<TestServices> _logger;
        private readonly ITestRepository _testRepository;


        public TestServices( ITestRepository ITestRepository)
        {
           
            _testRepository = ITestRepository;
        }
        public async Task<TestModel> GetTestServicesByIdAsync(int userId)
        {
            TestModel testModel = new TestModel();
            testModel = await _testRepository.GetTestServicesByIdAsync(userId);
            return testModel;
        }
    }
}
