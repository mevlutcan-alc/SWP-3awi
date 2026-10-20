using ObjektOrientierungTeil1;

namespace MyFirstTestProjekt
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void KUHConstructor_IsCalled_SetsValuesCorrect()
        {
            KUH myKUH = new KUH("Paula", "Schwarz");
            Assert.That(myKUH.Name, Is.EqualTo("Paula"));
        }
    }
}
