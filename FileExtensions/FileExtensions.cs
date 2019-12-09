using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Web;

using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting.Internal;

namespace MagicHome.FileExtensions
{
    public static class FileExtensions
    {
        public static bool IsImage(this IFormFile file)
        {
            return file.ContentType == "image/jpg" ||
                   file.ContentType == "image/png" ||
                    file.ContentType == "image/jpeg";

        }

        public static void RemoveImage(string root, string image)
        {
            string path = Path.Combine(root, "images", image);

            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }



        //public static string SaveImage( IFormFile Photo, string files)
        //{
        //    string filename = files + "/" + Guid.NewGuid().ToString() + Path.GetFileName(Photo.FileName);
        //    string path = new FileStream(HostingEnvironment.MapPath("~/images"), filename);
        //}






        //public static string DeletImage(string del, string delname)
        //{
        //    string delpath = Path.Combine(HttpContext.Current.Server.MapPath(del), delname);
        //    if (File.Exists(delpath))
        //    {
        //        File.Delete(delpath);
        //    }

        //    return delpath;//bir daha baxmaliyam bu hisseye!

        //}
    }
}
