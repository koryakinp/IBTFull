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
            return File(stream, "application/msword", $"{filename}.docx");
        }

        public FileResult Abu(int id)
        {
            if (!new int[] { 5, 10, 25 }.Any(q => q == id))
            {
                id = 25;
            }

            var abu = string.Format(SharedResource.Abu, id);
            var filename = SharedResource.abuSpecsFilename;
            var stream = Files.ResourceManager.GetMemoryStream($"abu_{id}_specs");
            return File(stream, "application/pdf", $"{abu} {filename}.pdf");
        }
    }
}