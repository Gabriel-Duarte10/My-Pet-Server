using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Firebase.Auth;
using Firebase.Storage;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using My_Pet.Data.Dto;
using My_Pet.Models;
using My_Pet.Models.FireBase;
using Newtonsoft.Json;

namespace My_Pet.Services
{
    public class ImageService
    {
        public ImageService()
        {
        }
        public async void DeleteImagesFireBase(List<AdoptionImage> images)
        {
            var secrets = JsonConvert.DeserializeObject<Secrets>(File.ReadAllText("appsettings.json"));
                
            FirebaseAuthProvider firebaseConfiguration = new(new FirebaseConfig(secrets.Authentication.ApiKey));

            FirebaseAuthLink authConfiguration = await firebaseConfiguration
                .SignInWithEmailAndPasswordAsync(secrets.Authentication.Email, secrets.Authentication.Password);

            CancellationTokenSource cancellationToken = new();

            foreach (var i in images)
            {
                await new FirebaseStorage(secrets.BucketName,
                new FirebaseStorageOptions
                {
                    AuthTokenAsyncFactory = () => Task.FromResult(authConfiguration.FirebaseToken),
                    ThrowOnCancel = true
                })
                .Child("images")
                .Child(i.nameImageFireBase)
                .DeleteAsync();
            }
        }
        public async Task<List<ImageDto>> UploadImageFireBase(List<IFormFile> files)
        {
            try
            {
                var secrets = JsonConvert.DeserializeObject<Secrets>(File.ReadAllText("appsettings.json"));
                
                FirebaseAuthProvider firebaseConfiguration = new(new FirebaseConfig(secrets.Authentication.ApiKey));

                FirebaseAuthLink authConfiguration = await firebaseConfiguration
                    .SignInWithEmailAndPasswordAsync(secrets.Authentication.Email, secrets.Authentication.Password);

                CancellationTokenSource cancellationToken = new();

                List<ImageDto> listUrlImages = new List<ImageDto>();
                string imageFromFirebaseStorage = "";

                foreach (var file in files)
                {
                    if (file.Length > 0)
                    {
                        using (var ms = new MemoryStream())
                        {
                            file.CopyTo(ms);
                            var fileBytes = ms.ToArray();

                            var fileName = Guid.NewGuid().ToString() + "." + file.ContentType.Split("/")[1];

                            using (var stream = new MemoryStream(fileBytes))
                            {
                                FirebaseStorageTask storageManager = new FirebaseStorage(secrets.BucketName,
                                    new FirebaseStorageOptions
                                    {
                                        AuthTokenAsyncFactory = () => Task.FromResult(authConfiguration.FirebaseToken),
                                        ThrowOnCancel = true
                                    })
                                    .Child("images")
                                    .Child(fileName)
                                    .PutAsync(stream, cancellationToken.Token);

                                try
                                {
                                    imageFromFirebaseStorage = await storageManager;
                                }
                                catch (Exception ex) 
                                {  
                                    throw;
                                } 

                                listUrlImages.Add(new ImageDto(){
                                    UrlImage = imageFromFirebaseStorage,
                                    NameImage = fileName
                                });
                            }
                            
                        }
                    }
                }
                return listUrlImages;
            }
            catch (Exception ex) 
            {  
                throw;
            }          
        }
    }
}