using JurosRestDDDDomain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;


namespace ProjetoJurosDDD.UnitTests
{
    
    public class TaxaTests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void CanBeUsed_IsEnabled_ReturnTrue()
        {
            //Arrange
            var taxa = new Taxa() { 
                Ativo = true
            };

            //Act
            var result = taxa.CanBeUsed(taxa);

            //Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(result);
        }
    }
}