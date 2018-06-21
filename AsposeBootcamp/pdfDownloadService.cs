using Aspose.Pdf.Cloud.Sdk.Api;
using System;
using System.Configuration;

namespace AsposeBootcamp
{
    public class pdfDownloadService
    {
        private readonly string _AppKey;
        private readonly string _AppSid;

        public pdfDownloadService()
        {
            _AppKey = ConfigurationManager.AppSettings["APP_KEY"];
            _AppSid = ConfigurationManager.AppSettings["APP_SID"]; ;
        }

        public ResultsModel DownloadPdf(string filename)
        {
            var results = new ResultsModel();
            if (string.IsNullOrWhiteSpace(filename))
            {
                results.ErrorMessage = "Invalid filename";
            }
            else
            {
                Download(filename, results);
            }
            return results;
        }

        private void Download(string filename, ResultsModel results)
        {
            try
            {
                var target = new PdfApi(_AppKey, _AppSid);
                var file = target.GetDownload(filename);
                results.output = file.Length.ToString();
            }
            catch (Exception)
            {
                results.ErrorMessage = "File does not exist";
            }
        }
    }
}
