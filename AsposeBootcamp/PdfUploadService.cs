﻿using Aspose.Storage.Cloud.Sdk.Api;
using Aspose.Storage.Cloud.Sdk.Model;
using Aspose.Storage.Cloud.Sdk.Model.Requests;
using System;
using System.Configuration;
using System.IO;

namespace AsposeBootcamp
{
    public class PdfUploadService
    {
        private readonly string _AppKey;
        private readonly string _AppSid;

        public PdfUploadService()
        {
            _AppKey = ConfigurationManager.AppSettings["APP_KEY"];
            _AppSid = ConfigurationManager.AppSettings["APP_SID"]; ;
        }

        public ResultsModel UploadPdf(string pdfPath, string filename)
           
        {
            var results = new ResultsModel();

            if (!File.Exists(pdfPath))
            {
                results.ErrorMessage = "File does not exist";
            }
            else {
                using (var stream = new FileStream(pdfPath, FileMode.Open))
                {
                    var storageApi = new StorageApi(_AppKey, _AppSid);
                    var request = new PutCreateRequest(filename, stream);
                    results.uploadResponse = storageApi.PutCreate(request);
                }

            }
               
            
          
            
            return results;
        }
    }
}