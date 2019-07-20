using IBTFull.Resources;
using IBTFull.Resources.Files;
using System.Linq;
using System.Web.Mvc;

namespace IBTFull.Controllers
{
    public class FileController : BaseController
    {
        public FileResult Index(string file)
        {
            var filename = SharedResource.ResourceManager.GetString(file);
            var stream = Files.ResourceManager.GetMemoryStream(file);
            var resource = string.Format("{0}.docx", filename);
            return File(stream, "application/msword", resource);
        }

        public FileResult Abu(int id)
        {
            if (!new int[] { 5, 10, 25 }.Any(q => q == id))
            {
                id = 25;
            }

            var abu = string.Format(SharedResource.Abu, id);
            var filename = SharedResource.abuSpecsFilename;
            var resource = string.Format("abu_{0}_specs", id);
            var stream = Files.ResourceManager.GetMemoryStream(resource);
            return File(stream, "application/pdf", $"{abu} {filename}.pdf");
        }
    }
}