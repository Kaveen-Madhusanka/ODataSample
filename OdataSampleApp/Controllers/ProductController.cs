using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using OdataSampleApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdataSampleApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMSDbcontext _dbcontext;

        public ProductController(IMSDbcontext dbContext)
        {
            _dbcontext = dbContext;
        }

        [HttpGet]
        [Route("GetProducts")]
        [EnableQuery]
        public IActionResult GetAllProdut()
        {
            return Ok(_dbcontext.Product.AsQueryable());
        }
        // filter
        /*
         * $filter:
        The $filter filters data based on a boolean condition. The following are conditional operators that have to be used in URLs.

        eq - equals to.
        ne - not equals to
        gt - greater than
        ge - greater than or equal 
        lt - less than
        le - less than or equal
        eg: https://localhost:5001/gadget/Get?$filter=ProductName eq 'Think Pad'
        */

        //
        /*
         $select:
            https://localhost:5001/gadget/Get?$select=ProductName,Cost

        Order by
        https://localhost:5001/gadget/Get?$orderby=Id desc

        Top
        https://localhost:44381/api/Product/GetProducts?$top=2
         */
    }
}
