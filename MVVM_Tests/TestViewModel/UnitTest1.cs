using ViewModel;

namespace TestViewModel
{
    public class Tests
    {
        ViewModelPersonne _viewmodelPersonne;
        [SetUp]
        public void Setup()
        {
            _viewmodelPersonne = new ViewModelPersonne();
        }

        [Test]
        public void TestAfficherNom()
        {
            
            _viewmodelPersonne.NomSaisi = "Antoine";
            _viewmodelPersonne.AfficherNom();

            Assert.IsTrue(_viewmodelPersonne.NomSaisi.Equals(_viewmodelPersonne.NomAffiche));
        }
    }
}