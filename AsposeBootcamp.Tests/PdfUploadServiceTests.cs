﻿using NUnit.Framework;
using System.IO;

namespace AsposeBootcamp.Tests
{
    [TestFixture]
    class PdfUploadServiceTests
    {
        [Test]
        public void UploadPdf_GivenAPdfFilenameNotStoredInLocalStorage_AttemptToUploadItToTheCloudShouldReturnFileDoesNotExist()
        {
            //Arrange
            var sut = CreatePdfUploadService();
            const string filename = "Fake.pdf";
            var baseDirectory = TestContext.CurrentContext.TestDirectory;
            var pdfPath = Path.Combine(baseDirectory, filename);
            var cloudFilename = "Empty.pdf";
            var expected = "File does not exist";

            //Act
            var actual = sut.UploadPdf(pdfPath, cloudFilename);

            //Assert
            Assert.AreEqual(expected, actual.ErrorMessage);
        }

        [Test]
        public void UploadPdf_GivenAPdfFilenameStoredInLocalStorage_ShouldUploadItToTheCloudAndReturnStatusCode200()
        {
            //Arrange
            var sut = CreatePdfUploadService();
            const string filename = "BootcampForm.pdf";
            var baseDirectory = TestContext.CurrentContext.TestDirectory;
            var pdfPath = Path.Combine(baseDirectory, filename);
            var cloudFilename = "Empty.pdf";

            //Act
            var actual = sut.UploadPdf(pdfPath, cloudFilename);

            //Assert
            Assert.AreEqual(200, actual.uploadResponse.Code);
        }

        private static PdfUploadService CreatePdfUploadService()
        {
            return new PdfUploadService();
        }

    }
}
