using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Linq;
//using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Reflection;
using System.Threading.Tasks;
using Domotica_mysql.Areas.Usuarios.Models;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Hosting;

namespace Domotica_mysql.Library
{
    public class UploadImage
    {
        public string carpeta;
        public async Task copiarImagenAsync(IFormFile AvatarImage, IHostingEnvironment environment, string carpeta,
            String imagen)
        {
            if (null == AvatarImage)
            {

                var filePath = Path.Combine(environment.ContentRootPath, "wwwroot\\images\\fotos\\default.png");

            }
            else
            {
                var filePath = Path.Combine(environment.ContentRootPath, "wwwroot\\images\\fotos\\" + carpeta, AvatarImage.FileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await AvatarImage.CopyToAsync(stream);
                }
            }

        } //fin método CopiarImagenAsync 
        public void deleteImagenAsync(IHostingEnvironment environment, String carpeta, String imagen)
        {
            var archivoOrigen = environment.ContentRootPath + "/wwwroot/images/fotos/" + carpeta + "/" + imagen + ".png";
            File.Delete(archivoOrigen);
        }
    }
}
