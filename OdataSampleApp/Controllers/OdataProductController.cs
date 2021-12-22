using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using OdataSampleApp.Data;

namespace OdataSampleApp.Controllers
{
    public class OdataProductController : ControllerBase
    {
        private readonly IMSDbcontext _dbcontext;

        public OdataProductController(IMSDbcontext dbContext)
        {
            _dbcontext = dbContext;
        }

        [HttpGet]
        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_dbcontext.Product.AsQueryable());
        }
    }
}
