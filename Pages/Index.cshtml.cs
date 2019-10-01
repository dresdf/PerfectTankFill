using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace PerfectTankFill.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public double? UnitPrice { get; set; }

        [BindProperty]
        public int? MaxTank { get; set; }

        public string Result { get; set; }
        public double? Price { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            UnitPrice = null;
            MaxTank = null;
        }
        public void OnPost()
        {

            for(int i = 1; i <= MaxTank; i++)
            {
                Price = UnitPrice * i;
                if((Price % 5) == 0)
                {
                    if(i % 5 == 0)
                    {
                        Result = "Price: " + Price + " /// Quantity: " + i;
                        return;
                    }
                }
            }

            for(int i = 1; i <= 1000000; i++)
            {
                Price = UnitPrice * i;
                if((Price % 5) == 0)
                {
                    if(i % 5 == 0)
                    {
                        Result = "First Price: " + Price + " /// Quantity: " + i;
                        return;
                    }
                }
            }


            Result = "Not possible";

        }
    }
}
