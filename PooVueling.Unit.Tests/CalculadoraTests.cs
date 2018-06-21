using Microsoft.VisualStudio.TestTools.UnitTesting;
using PooVueling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace PooVueling.Tests
{
	[TestClass()]
	public class CalculadoraTests
	{
		private ICalculadora mockObject;

		// S'executarà abans de la execució de cada mètode de test.
		// Una classe de test s'instancia diferent a una classe normal. Per cada mètode de test a executar
		// s'instancia la classe de test. Per tant sempre cal posar les variables globals en un mètode unic
		// amb el custom attribute TestInitialize
		[TestInitialize]
		public void Setup()
		{
			var mock = new Mock<ICalculadora>();
			mock.Setup(x => x.Suma(2,2)).Returns(4);
			mock.Setup(x => x.Resta(4,2)).Returns(2);
			mock.Setup(x => x.Division(4,2)).Returns(2);
			mock.Setup(x => x.Multiplicacion(4,2)).Returns(8);
			mockObject = mock.Object;
		}

		[TestMethod()]
		public void DivisionTest()
		{
			var result = mockObject.Division(4,2);
			Assert.AreEqual(2,result);
		}

		[TestMethod()]
		public void MultiplicacionTest()
		{
			var result = mockObject.Multiplicacion(4,2);
			Assert.AreEqual(8,result);
		}

		[TestMethod()]
		public void RestaTest()
		{
			var result = mockObject.Resta(4,2);
			Assert.AreEqual(2,result);
		}

		[TestMethod()]
		public void SumaTest()
		{
			var result = mockObject.Suma(2,2);
			Assert.AreEqual(4,result);
		}
	}
}