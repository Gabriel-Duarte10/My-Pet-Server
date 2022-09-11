using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using My_Pet.Data.Dto;
using My_Pet.Models;

namespace My_Pet.Services
{
    public class ImageService
    {
        protected IConfiguration Configuration;
        protected readonly string AzureKey;
        protected readonly string AzureConteinerString;
        public ImageService(IConfiguration configuration)
        {
            Configuration = configuration;
            AzureKey = Configuration.GetValue<string>("AzureKey");
            AzureConteinerString = Configuration.GetValue<string>("AzureConteinerString");
        }

        public List<ImageDto> UploadImageAzure(List<IFormFile> files)
        {
            List<ImageDto> listUrlImages = new List<ImageDto>();

            foreach (var file in files)
            {
                if (file.Length > 0)
                {
                    using (var ms = new MemoryStream())
                    {
                        file.CopyTo(ms);
                        var fileBytes = ms.ToArray();

                        var fileName = Guid.NewGuid().ToString() + "." + file.ContentType.Split("/")[1];

                        var blobClient = new BlobClient(AzureKey, AzureConteinerString, fileName);

                        using (var stream = new MemoryStream(fileBytes))
                        {
                            blobClient.Upload(stream);
                        }

                        listUrlImages.Add(new ImageDto(){
                            UrlImage = blobClient.Uri.AbsoluteUri,
                            NameImage = fileName
                        });
                    }
                }
            }
            return listUrlImages;
        }
        public void DeleteImagesAzure(List<AdoptionImage> images)
        {
            foreach (var i in images)
            {
                var blob = new BlobClient(AzureKey, AzureConteinerString, i.nameImageAzure);
                blob.Delete();
            }
        }
    }
}