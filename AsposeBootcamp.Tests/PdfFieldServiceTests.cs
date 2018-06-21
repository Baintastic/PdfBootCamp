﻿using Aspose.Pdf.Cloud.Sdk.Model;
using iTextSharp.text.pdf;
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
        public void UpdateField_GivenAPdfFilenameNotStoredInTheCloud_AttemptToUpdateItShouldThrowAnException()
        {
            //Arrange
            var sut = CreateDocumentServices();
            const string filename = "Dummy.pdf";
            Field field = new Field();
            field.Name = "First Name";
            field.Values = new List<string> { "Thabani" };
            var expected = "File does not exist";

            //Act
            var actual = sut.UpdateField(filename, field);

            //Assert
            Assert.AreEqual(expected, actual.ErrorMessage);
        }
    
        [Test]
        public void UpdateField_GivenAPdfFilenameStoredInTheCloud_ItsFirstNameFieldShouldUpdateAndReturnStatusCodeOK()
        {
            //Arrange
            var sut = CreateDocumentServices();
            const string filename = "BootcampForm.pdf";
            Field field = new Field();
            field.Name = "First Name";
            field.Values = new List<string> { "Thabani" };

            //Act
            var actual = sut.UpdateField(filename, field);

            //Assert
            Assert.AreEqual(HttpStatusCode.OK, actual.fieldResponse.Code);
            Assert.AreEqual("Thabani", field.Values[0]);
        }

        [Test]
        public void UpdateFields_GivenAPdfFilenameStoredInTheCloud_AllFieldsShouldUpdateAndReturnStatusCodeOK()
        {
            //Arrange
            var sut = CreateDocumentServices();
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
            Assert.AreEqual(HttpStatusCode.OK, actual.Code);
        }

        [Test]
        public void DisableFields_GivenAPdfFilename_ItsFirstNameSurnameAndDOBFieldShouldBeReadOnly()
        {
            //Arrange
            var sut = CreateDocumentServices();
            const string filename = "AsposeFormTest.pdf";
            const string newFileName = "ReadOnlyBootcampForm.pdf";
            var baseDirectory = TestContext.CurrentContext.TestDirectory;
            var oldPdfPath = Path.Combine(baseDirectory, filename);
            var newPdfPath = Path.Combine(baseDirectory, newFileName);
            
            //Act
            sut.DisableFields(oldPdfPath, newPdfPath);
            var oldFile = File.ReadAllBytes(oldPdfPath);
            var newFile = File.ReadAllBytes(newPdfPath);

            //Assert
            Assert.AreNotEqual(oldFile, newFile);
        }

        private static PdfFieldService CreateDocumentServices()
        {
            return new PdfFieldService();
        }
    }
}