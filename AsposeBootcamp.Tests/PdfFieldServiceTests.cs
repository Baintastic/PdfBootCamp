using Aspose.Pdf.Cloud.Sdk.Model;
using NUnit.Framework;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace AsposeBootcamp.Tests
{
    [TestFixture]
    public class PdfFieldServiceTests
    {
        [Test]
        public void UpdateField_GivenAPdfFilenameNotStoredInTheCloud_AttemptToUpdateItShouldReturnFileDoesNotExist()
        {
            //Arrange
            var sut = CreatePdfFieldService();
            const string filename = "Dummy.pdf";
            var asposeFields = new Fields
            {
                List = new List<Field>
                {
                    new Field
                    {
                        Name = filename,
                        Values = new List<string>
                        {
                            "Tom"
                        }
                    }
                }
            };
            var expected = "File does not exist";

            //Act
            var actual = sut.UpdateFields(filename, asposeFields);

            //Assert
            Assert.AreEqual(expected, actual.ErrorMessage);
        }

        [TestCase(" ")]
        [TestCase("")]
        [TestCase(null)]
        public void UpdateField_GivenAnInvalidPdfFilename_AttemptToUpdateItShouldReturnInvalidFilename(string filename)
        {
            //Arrange
            var sut = CreatePdfFieldService();
            var asposeFields = new Fields
            {
                List = new List<Field>
                {
                    new Field
                    {
                        Name = filename,
                        Values = new List<string>
                        {
                            "Tom"
                        }
                    }
                }
            };
            var expected = "Invalid filename";

            //Act
            var actual = sut.UpdateFields(filename, asposeFields);

            //Assert
            Assert.AreEqual(expected, actual.ErrorMessage);
        }

        [Test]
        public void UpdateFields_GivenAValidPdfFilenameStoredInTheCloud_AllFieldsShouldUpdateAndReturnStatusCodeOK()
        {
            //Arrange
            var sut = CreatePdfFieldService();
            const string filename = "BootcampForm.pdf";
            var asposeFields = new Fields
            {
                List = new List<Field>
                {
                    new Field
                    {
                        Name = "First Name",
                        Values = new List<string>
                        {
                            "Tom"
                        }
                    },
                    new Field
                    {
                        Name = "Surname",
                        Values = new List<string>
                        {
                            "Smith"
                        }
                    },
                    new Field
                    {
                        Name = "Date of Birth",
                        Values = new List<string>
                        {
                            "1997-06-27"
                        }
                    },
                    new Field
                    {
                        Name = "GrossSalary",
                        Values = new List<string>
                        {
                            "35000"
                        }
                    },
                    new Field
                    {
                        Name = "Tax",
                        Values = new List<string>
                        {
                            "5250"
                        }
                    },
                    new Field
                    {
                        Name = "AccommodationCost",
                        Values = new List<string>
                        {
                            "8000"
                        }
                    },
                    new Field
                    {
                        Name = "CellphoneCost",
                        Values = new List<string>
                        {
                            "500"
                        }
                    },
                    new Field
                    {
                        Name = "CreditCardCost",
                        Values = new List<string>
                        {
                            "2000"
                        }
                    },
                    new Field
                    {
                        Name = "OtherDebtCost",
                        Values = new List<string>
                        {
                            "8000"
                        }
                    },
                }
            };

            //Act
            var actual = sut.UpdateFields(filename, asposeFields);

            //Assert
            Assert.AreEqual(HttpStatusCode.OK, actual.fieldsResponse.Code);
        }

        [Test]
        public void DisableFields_GivenAValidPdfFilenameStoredIntheCloud_ItsFirstNameSurnameAndDOBFieldShouldBeReadOnly()
        {
            //Arrange
            var sut = CreatePdfFieldService();
            const string filename = "AsposeFormTest.pdf";
            const string newFileName = "ReadOnlyBootcampForm.pdf";
            var fieldsToDisable = new[]{ "First Name", "Surname" , "Date of Birth" };
            var baseDirectory = TestContext.CurrentContext.TestDirectory;
            var oldPdfPath = Path.Combine(baseDirectory, filename);
            var newPdfPath = Path.Combine(baseDirectory, newFileName);

            //Act
            sut.DisableFields(oldPdfPath, newPdfPath, fieldsToDisable);
            var oldFile = File.ReadAllBytes(oldPdfPath);
            var newFile = File.ReadAllBytes(newPdfPath);

            //Assert
            Assert.AreNotEqual(oldFile, newFile);
        }

        private static PdfFieldService CreatePdfFieldService()
        {
            return new PdfFieldService();
        }
    }
}
