using Microsoft.VisualStudio.TestTools.UnitTesting;
using PooVueling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVueling.Tests
{
	[TestClass()]
	public class CalculadoraTests
	{
    readonly ICalculadora iCalculadora = new Calculadora();

		[DataRow(4, 2, 2)]
		[DataRow(9, 3, 3)]
		[DataTestMethod]
		public void DivisionTest(int num1, int num2, int resultado)
		{
			Assert.IsTrue(iCalculadora.Division(num1,num2) == resultado);
		}

		[DataRow(4, 2, 8)]
		[DataRow(9, 3, 27)]
		[DataTestMethod]
		public void MultiplicacionTest(int num1, int num2, int resultado)
		{
			Assert.IsTrue(iCalculadora.Multiplicacion(num1,num2) == resultado);
		}

		[DataRow(4, 2, 2)]
		[DataRow(9, 3, 6)]
		[DataTestMethod]
		public void RestaTest(int num1, int num2, int resultado)
		{
			Assert.IsTrue(iCalculadora.Resta(num1,num2) == resultado);
		}

		[DataRow(4, 2, 6)]
		[DataRow(9, 3, 12)]
		[DataTestMethod]
		public void SumaTest(int num1, int num2, int resultado)
		{
			Assert.IsTrue(iCalculadora.Suma(num1,num2) == resultado);
		}

		[DataRow(44D, 11D, 4D)]
		[DataRow(99D, 3D, 33D)]
		[DataTestMethod]
		public void DivisionDoubleTest(double num1, double num2, double resultado)
		{
			Assert.IsTrue(iCalculadora.Division(num1,num2) == resultado);
		}

		[DataRow(4D, 2D, 8D)]
		[DataRow(9D, 3D, 27D)]
		[DataTestMethod]
		public void MultiplicacionDoubleTest(double num1, double num2, double resultado)
		{
			Assert.IsTrue(iCalculadora.Multiplicacion(num1,num2) == resultado);
		}

		[DataRow(4D, 2D, 2D)]
		[DataRow(9D, 3D, 6D)]
		[DataTestMethod]
		public void RestaDoubleTest(double num1, double num2, double resultado)
		{
			Assert.IsTrue(iCalculadora.Resta(num1,num2) == resultado);
		}

		[DataRow(4D, 2D, 6D)]
		[DataRow(9D, 3D, 12D)]
		[DataTestMethod]
		public void SumaDoubleTest(double num1, double num2, double resultado)
		{
			Assert.IsTrue(iCalculadora.Suma(num1,num2) == resultado);
		}

	}
}