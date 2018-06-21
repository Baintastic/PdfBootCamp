using Aspose.Pdf.Cloud.Sdk.Model;
using Aspose.Storage.Cloud.Sdk.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsposeBootcamp
{
   public class ResultsModel
    {
        public string ErrorMessage { get; set; }
        public UploadResponse uploadResponse { get; set; }
        public FieldResponse  fieldResponse{ get; set; }
        public string output { get; set; }
    }
}
