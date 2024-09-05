using Microsoft.AspNetCore.Mvc;
using SMS.Models;

namespace Rotation.AspNetCore
{
    public class ViewAsPdf : IActionResult
    {
        private IList<Item> seachitems;

        public ViewAsPdf(IList<Item> seachitems)
        {
            this.seachitems = seachitems;
        }

        public Task ExecuteResultAsync(ActionContext context)
        {
            throw new NotImplementedException();
        }
    }
}