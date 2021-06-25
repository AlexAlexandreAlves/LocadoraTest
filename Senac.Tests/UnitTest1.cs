using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Model
{
    namespace Senac.Tests
    {
        [TestClass]
        public class UnitTest1
        {
            [DataTestMethod]
            [DataRow("")]
            [DataRow(null)]
            //[DataRow(" ")]
            public void Model_Cliente_Nome(string value)
            {
                Cliente c = new Cliente(
                    value,
                    new System.DateTime(),
                    "000.000.000-00",
                    15
                );
                bool resultado = c.VerificaNome();
                Assert.IsFalse(resultado);

            }
        }

        [TestClass]
        public class UnitTest2
        {
            [DataTestMethod]
            [DataRow("056.458.123.98")]
            //[DataRow(null)]
            [DataRow(" ")]

            public void Model_Cliente_Cpf(string value)
            {
                Cliente c = new Cliente(
                    "Teste",
                    new System.DateTime(),
                    value,
                    15
                );
                bool resultado = c.VerificaCpf();
                Assert.IsFalse(resultado);

            }
        }

       /* [TestClass]
        public class CriarCliente
        {
            [DataTestMethod]
            public void Model_Criar_Cliente()
            {
                Cliente c = new Cliente(
                    "Teste",
                    new System.DateTime(),
                    "000.000.000-00",
                    15
                );
                Cliente createdCliente = Cliente.GetCliente(c.Id);
                Assert.IsTrue(createdCliente.Nome == c.Nome);
            }
        }*/


    }

}