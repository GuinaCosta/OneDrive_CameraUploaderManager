using System.Web.Mvc;

namespace OneDrive_CameraUploaderManager.Controllers
{
    [Authorize]
    public class ClaimsController : Controller
    {
        /// <summary>
        /// Add user's claims to viewbag
        /// </summary>
        /// <returns>View with Claims Information</returns>
        public ActionResult Index()
        {
            var claimsPrincipalCurrent = System.Security.Claims.ClaimsPrincipal.Current;

            //obtém o nome do usuários
            ViewBag.Name = claimsPrincipalCurrent.FindFirst("name").Value;

            //obtém o "username"
            ViewBag.UserName = claimsPrincipalCurrent.FindFirst("preferred_username").Value;

            // The subject claim can be used to uniquely identify the user across the web
            ViewBag.Subject = claimsPrincipalCurrent.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier).Value;

            // TenantId is the unique Tenant Id - which represents an organization in Azure AD
            ViewBag.TenantId = claimsPrincipalCurrent.FindFirst("http://schemas.microsoft.com/identity/claims/tenantid").Value;

            return View();
        }
    }
}