using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Model;
using iTextSharp.text.pdf;
using System;
using System.Configuration;
using System.IO;

namespace AsposeBootcamp
{
    public class PdfFieldService
    {
        private readonly string _AppKey;
        private readonly string _AppSid;

        public PdfFieldService()
        {
            _AppKey = ConfigurationManager.AppSettings["APP_KEY"];
            _AppSid = ConfigurationManager.AppSettings["APP_SID"]; ;
        }

        
        public ResultsModel UpdateFields(string filename, Fields fields)
        {
            var results = new ResultsModel();
            if (string.IsNullOrWhiteSpace(filename))
            {
                results.ErrorMessage = "Invalid filename";
                return results;
            }
            try
            {
                var target = new PdfApi(_AppKey, _AppSid);
                results.fieldsResponse = target.PutUpdateFields(filename, fields);              
            }
            catch (Exception)
            {
                results.ErrorMessage = "File does not exist";
            }
            return results;
           
        }

        public void DisableFields(string oldPdfPath, string newPdfPath, string[] fieldsToDisable)
        {
            PdfReader reader = new PdfReader(oldPdfPath);
            using (PdfStamper stamper = new PdfStamper(reader, new FileStream(newPdfPath, FileMode.Create)))
            {
                AcroFields form = stamper.AcroFields;
                for (int i = 0; i < fieldsToDisable.Length; i++) {
                    form.SetFieldProperty(fieldsToDisable[i], "setfflags", PdfFormField.FF_READ_ONLY, null);
                }
            }
        }
    }
}
