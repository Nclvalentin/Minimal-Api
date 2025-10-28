using MinimalApi.Dominio.Entidades;

namespace Test.Domain.Entidades;

[TestClass]
public sealed class AdministradorTest
{
    [TestMethod]
    public void TestarGetSetPropriedades()
    {

        //Arrange
        var adm = new Administrador();


        //Act
        adm.Id = 1;
        adm.Email = "Teste@teste.com";
        adm.Senha = "Teste";
        adm.Perfil = "Adm";

        //Assert
        Assert.AreEqual(1, adm.Id);
        Assert.AreEqual("Teste@teste.com", adm.Email);
        Assert.AreEqual("Teste", adm.Senha);
        Assert.AreEqual("Adm", adm.Perfil);
    }
}
