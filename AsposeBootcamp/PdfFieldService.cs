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

        public ResultsModel UpdateField(string filename, Field field)
        {
            var results = new ResultsModel();
            if (string.IsNullOrWhiteSpace(filename))
            {
                results.ErrorMessage = "Invalid filename";
            }
            else
            {
                try
                {
                    PdfApi target = new PdfApi(_AppKey, _AppSid);
                    results.fieldResponse = target.PutUpdateField(filename, field.Name, field);
                }
                catch (Exception)
                {
                    results.ErrorMessage = "File does not exist";
                }

            }

            return results;

        }

        public FieldsResponse UpdateFields(string filename, Fields fields)
        {
            PdfApi target = new PdfApi(_AppKey, _AppSid);
            return target.PutUpdateFields(filename, fields);
        }

        public void DisableFields(string oldPdfPath, string newPdfPath)
        {
            PdfReader reader = new PdfReader(oldPdfPath);
            using (PdfStamper stamper = new PdfStamper(reader, new FileStream(newPdfPath, FileMode.Create)))
            {
                AcroFields form = stamper.AcroFields;
                form.SetFieldProperty("First Name", "setfflags", PdfFormField.FF_READ_ONLY, null);
                form.SetFieldProperty("Surname", "setfflags", PdfFormField.FF_READ_ONLY, null);
                form.SetFieldProperty("Date of Birth", "setfflags", PdfFormField.FF_READ_ONLY, null);
            }
        }
    }
}
