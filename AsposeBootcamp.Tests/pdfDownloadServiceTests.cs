using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Storage.Cloud.Sdk.Api;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsposeBootcamp.Tests
{
    [TestFixture]
    class pdfDownloadServiceTests
    {
        [Test]
        public void DownloadPdf_GivenAPdfFilenameNotExistingInTheCloud_AttemptToDownloadItShouldReturnFileDoesNotExist()
        {
            //Arrange
            var sut = new pdfDownloadService();
            const string filename = "Dummy.pdf";
            var expected = "File does not exist";

            //Act
            var actual = sut.DownloadPdf(filename);
        
            //Assert
            Assert.AreEqual(expected, actual.ErrorMessage);
        }

        [TestCase(" ")]
        [TestCase("")]
        public void DownloadPdf_GivenAnInvalidPdfFilename_AttemptToDownloadItShouldReturnInvalidFilename(string filename)
        {
            //Arrange
            var sut = new pdfDownloadService();
            var expected = "Invalid filename";

            //Act
            var actual = sut.DownloadPdf(filename);

            //Assert
            Assert.AreEqual(expected, actual.ErrorMessage);
        }

        [Test]
        public void DownloadPdf_GivenAValidPdfFilenameStoredInTheCloud_ShouldDownloadAndReturnSameNumberOfBytesAsItsLocalFile()
        {
            //Assert
            var sut = new pdfDownloadService();
            const string cloudFilename = "BootcampForm.pdf";
            const string localFilename = "AsposeFormTest.pdf";
            //Act
            var actual = Int32.Parse(sut.DownloadPdf(cloudFilename).output); 
            
            var baseDirectory = TestContext.CurrentContext.TestDirectory;
            var localPdfPath = Path.Combine(baseDirectory, localFilename);
            var localFile = File.ReadAllBytes(localPdfPath).Length;

            //Assert
            Assert.AreEqual(localFile, actual);
        }
    }
}
