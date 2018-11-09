using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnimtaWebInventory.Core.IServices;
using OnimtaWebInventory.Models;

namespace OnimtaWebApi.Controllers
{
    public class TestController : Controller
    {
        #region Private Decalrations
        private readonly ITestServices _TestService;
        //public BaseVM baseVM = new BaseVM();

        //private readonly ILogger<ApplicationUserController> _logger;
        //private readonly IMapper _mapper;
        #endregion  Private Declarations 

        public TestController(ITestServices TestServices)
        {
            _TestService = TestServices;
            //_logger = logger;
            //_mapper = mapper;
        }


        [HttpGet("{id},{test}")]
        public async Task<TestModel> Get(int id, int test)
        {
            TestModel testModel = new TestModel();
            try
            {
                testModel = await _TestService.GetTestServicesByIdAsync(id);

            }
            catch (Exception exc)
            {

            }
            return testModel;
        }
    }
}