using Aspose.Storage.Cloud.Sdk.Api;
using Aspose.Storage.Cloud.Sdk.Model.Requests;
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
                return results;
            }
            Upload(pdfPath, filename, results);
            return results;
        }

        private void Upload(string pdfPath, string filename, ResultsModel results)
        {
            using (var stream = new FileStream(pdfPath, FileMode.Open))
            {
                var storageApi = new StorageApi(_AppKey, _AppSid);
                var request = new PutCreateRequest(filename, stream);
                results.uploadResponse = storageApi.PutCreate(request);
            }
        }
    }
}
