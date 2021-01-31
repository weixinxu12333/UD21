using NUnit.Framework;

namespace Geometria.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void ConstructorSinParam()
        {
            Geometria g = new Geometria(1);
            Assert.Pass();
        }
        [Test]
        public void ConstructorConParam()
        {
            Geometria g = new Geometria();
            Assert.Pass();
        }
        [Test]
        public void areacuadrado()
        {
            Geometria g = new Geometria();
            Assert.Equals(4, g.areacuadrado(2));
        }
        [Test]
        public void areaCirculo()
        {
            Geometria g = new Geometria();
            Assert.Equals(18.85, g.areaCirculo(3));
        }
        [Test]
        public void areatriangulo()
        {
            Geometria g = new Geometria();
            Assert.Equals(10, g.areatriangulo(4,5));
        }
        [Test]
        public void arearectangulo()
        {
            Geometria g = new Geometria();
            Assert.Equals(21, g.arearectangulo(3,7));
        }
        [Test]
        public void areapentagono()
        {
            Geometria g = new Geometria();
            Assert.Equals(2, g.areapentagono(1,4));
        }
        [Test]
        public void arearombo()
        {
            Geometria g = new Geometria();
            Assert.Equals(24.5, g.arearombo(7,7));
        }
        [Test]
        public void arearomboide()
        {
            Geometria g = new Geometria();
            Assert.Equals(30, g.arearomboide(5,6));
        }
        [Test]
        public void areatrapecio()
        {
            Geometria g = new Geometria();
            Assert.Equals(38.5, g.areatrapecio(5,6,7));
        }
        [Test]
        public void figCuadrado()
        {
            Geometria g = new Geometria();
            Assert.Equals("cuadrado", g.figura(1));
        }
        [Test]
        public void figCirculo()
        {
            Geometria g = new Geometria();
            Assert.Equals("Circulo", g.figura(2));
        }
        [Test]
        public void figTriangulo()
        {
            Geometria g = new Geometria();
            Assert.Equals("Triangulo", g.figura(3));
        }
        [Test]
        public void figRectangulo()
        {
            Geometria g = new Geometria();
            Assert.Equals("Rectangulo", g.figura(4));
        }
        [Test]
        public void figPentagono()
        {
            Geometria g = new Geometria();
            Assert.Equals("Pentagono", g.figura(5));
        }
        [Test]
        public void figRombo()
        {
            Geometria g = new Geometria();
            Assert.Equals("Rombo", g.figura(6));
        }
        [Test]
        public void figRomboide()
        {
            Geometria g = new Geometria();
            Assert.Equals("Romboide", g.figura(7));
        }
        [Test]
        public void figTrapecio()
        {
            Geometria g = new Geometria();
            Assert.Equals("Trapecio", g.figura(8));
        }
        [Test]
        public void figDefault()
        {
            Geometria g = new Geometria();
            Assert.Equals("Default", g.figura(0));
        }
        [Test]
        public void getId()
        {
            Geometria g = new Geometria(1);
            Assert.Equals(1, g.getId());
        }
        [Test]
        public void setId()
        {
            Geometria g = new Geometria();
            g.setId(2);
            Assert.Equals(2, g.getId());
        }
        public void getIdSinParam()
        {
            Geometria g = new Geometria();
            Assert.Equals(1, g.getId());
        }
        [Test]
        public void getNom()
        {
            Geometria g = new Geometria();
            Assert.Equals("Default", g.getNom());
        }
        [Test]
        public void setNom()
        {
            Geometria g = new Geometria();
            g.setNom("Prova");
            Assert.Equals("Prova", g.getNom());
        }
        [Test]
        public void getArea()
        {
            Geometria g = new Geometria();
            Assert.Equals(null, g.getNom());
        }
        [Test]
        public void setArea()
        {
            Geometria g = new Geometria();
            g.setArea(10);
            Assert.Equals(10, g.getArea());
        }
    }
}