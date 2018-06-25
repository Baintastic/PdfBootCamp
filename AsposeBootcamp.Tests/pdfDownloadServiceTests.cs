using NUnit.Framework;
using System;
using System.IO;

namespace AsposeBootcamp.Tests
{
    [TestFixture]
    class pdfDownloadServiceTests
    {
        [Test]
        public void DownloadPdf_GivenAPdfFilenameNotStoredInTheCloud_AttemptToDownloadItShouldReturnFileDoesNotExist()
        {
            var sut = CreatePdfDownloadService();
            const string filename = "Dummy.pdf";
            var expected = "File does not exist";

            //Act
            var actual = sut.DownloadPdf(filename);

            //Assert
            Assert.AreEqual(expected, actual.ErrorMessage);
        }



        [TestCase(" ")]
        [TestCase("")]
        [TestCase(null)]
        public void DownloadPdf_GivenAnInvalidPdfFilename_AttemptToDownloadItShouldReturnInvalidFilename(string filename)
        {
            //Arrange
            var sut = CreatePdfDownloadService();
            var expected = "Invalid filename";

            //Act
            var actual = sut.DownloadPdf(filename);

            //Assert
            Assert.AreEqual(expected, actual.ErrorMessage);
        }

        [Test]
        public void DownloadPdf_GivenAValidPdfFilenameStoredInTheCloud_ShouldDownloadAndReturnSameNumberOfBytesAsItsLocalFile()
        {
            //Arrange
            var sut = CreatePdfDownloadService();
            const string cloudFilename = "BootcampForm.pdf";
            const string localFilename = "DownloadedBootcampForm.pdf";
            var baseDirectory = TestContext.CurrentContext.TestDirectory;
            var localPdfPath = Path.Combine(baseDirectory, localFilename);
            var localFile = File.ReadAllBytes(localPdfPath).Length;

            //Act
            var actual = Int32.Parse(sut.DownloadPdf(cloudFilename).output);

            //Assert
            Assert.AreEqual(localFile, actual);
        }

        private static pdfDownloadService CreatePdfDownloadService()
        {
            return new pdfDownloadService();
        }
    }
}
