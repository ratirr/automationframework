using System;
using OOP_Project;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Tests
{
    [TestClass]
    public class PatientUnitTests
    {
        [TestMethod]
        public void DisplayFullname()

        {
            //Arrange
            Patient pat = new Patient();
            pat.PlanName = "Medicare";
            pat.InsuranceCompany = "United Healthcare";

            string expected = "The name of the Insurance Company is: United Healthcare The Plan Type is: Medicare";

            //Act
            string actual = pat.DisplayInsuranceInfo;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void knowingStatic()
        {
            //Arrange
            Patient p1 = new Patient();
            p1.PlanName = "Medicaid";
            p1.InsuranceCompany = "United HealthCare";
            Patient.Count += 1;

            Patient p2 = new Patient();
            p2.PlanName = "SelectHealth Plus";
            p2.InsuranceCompany = "Select Health";
            Patient.Count += 1;

            Patient p3 = new Patient();
            p3.PlanName = "Individual";
            p3.InsuranceCompany = "Select Health";
            Patient.Count += 1;


            //Act
            var actual = Patient.Count;


            //Assert
            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        public void IncorrectFullName()
        {
            //Arrange
            Patient p = new Patient();
            p.PlanName = "Small Employer";
            p.InsuranceCompany = "United Healthcare";

            var expected = "The name of the Insurance Company is: UnitedHealthcare The Plan Type is:  ";


            //Act 
            var actual = p.DisplayInsuranceInfo;

            //Assert
            Assert.AreNotEqual(expected, actual);



        }

        [TestMethod]
        public void DisplayTest()
        {
            //Arrange
            var Patient = new Patient
            {
                InsuranceCompany = "VCM"
            };

            var expected = false;

            //Act
            var actual = Patient.IfNullBlank();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }

}
