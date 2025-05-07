using Microsoft.AspNetCore.Http;
using System.IO;
using System;
using System.Web;


namespace BusTicketSoftito.Methods
{
    public class FileService
    {

        public static string CreateFile(HttpPostedFileBase file)
        {
            string returnPath;
            try
            {
                string imageExtension = Path.GetExtension(file.FileName);
                string imageName = Guid.NewGuid() + imageExtension;
                string path = Path.Combine(HttpContext.Current.Server.MapPath("~/Content"), imageName);

                // Klasör yoksa oluştur
                string directory = Path.GetDirectoryName(path);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                file.SaveAs(path);
                return returnPath = "/Content/" + imageName;
            }
            catch (Exception ex)
            {
                // Hata loglama yapabilirsiniz
                System.Diagnostics.Debug.WriteLine("Dosya yükleme hatası: " + ex.Message);
                return returnPath = null;
            }
        }
    }
}