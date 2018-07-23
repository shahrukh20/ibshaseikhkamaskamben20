using System.Web;
using System.Web.Mvc;
using WorkFlowSystemConsoler.PController;

namespace WorkFlowSystemConsoler.Controllers
{
    public class ErrorController : IdentityController
    {
        private HttpException exception;

        public ErrorController(HttpException exception)
        {
            this.exception = exception;
        }

        public ActionResult InternalServerError()
        {
            ViewBag.Error = exception.InnerException + exception.StackTrace;
            return View();
        }

        public ActionResult NotFound()
        {
            return View();
        }
    }
}
