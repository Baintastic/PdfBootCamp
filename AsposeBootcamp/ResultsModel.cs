using Aspose.Pdf.Cloud.Sdk.Model;
using Aspose.Storage.Cloud.Sdk.Model;

namespace AsposeBootcamp
{
    public class ResultsModel
    {
        public string ErrorMessage { get; set; }
        public string output { get; set; }
        public UploadResponse uploadResponse { get; set; }
        public FieldResponse fieldResponse { get; set; }
       
    }
}
