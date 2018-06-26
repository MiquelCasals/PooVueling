using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVueling
{
	public class Calculadora : ICalculadora
	{
		/// <summary>
		/// Divisions the specified num1.
		/// </summary>
		/// <param name="num1">The num1.</param>
		/// <param name="num2">The num2.</param>
		/// <returns></returns>
		public int Division( int num1, int num2 )
		{
			return(num1 / num2);
		}

		/// <summary>
		/// Multiplicacions the specified num1.
		/// </summary>
		/// <param name="num1">The num1.</param>
		/// <param name="num2">The num2.</param>
		/// <returns></returns>
		public int Multiplicacion( int num1, int num2 )
		{
			return(num1 * num2);
		}

		/// <summary>
		/// Restas the specified num1.
		/// </summary>
		/// <param name="num1">The num1.</param>
		/// <param name="num2">The num2.</param>
		/// <returns></returns>
		public int Resta( int num1, int num2 )
		{
			return(num1 - num2);
		}

		/// <summary>
		/// Sumas the specified num1.
		/// </summary>
		/// <param name="num1">The num1.</param>
		/// <param name="num2">The num2.</param>
		/// <returns></returns>
		public int Suma( int num1, int num2 )
		{
			return(num1 + num2);
		}
		/// <summary>
		/// Divisions the specified num1.
		/// </summary>
		/// <param name="num1">The num1.</param>
		/// <param name="num2">The num2.</param>
		/// <returns></returns>
		/// Mètodes amb doubles
		public double Division( double num1, double num2 )
		{
			return(num1 / num2);
		}

		/// <summary>
		/// Multiplicacions the specified num1.
		/// </summary>
		/// <param name="num1">The num1.</param>
		/// <param name="num2">The num2.</param>
		/// <returns></returns>
		public double Multiplicacion( double num1, double num2 )
		{
			return(num1 * num2);
		}

		/// <summary>
		/// Restas the specified num1.
		/// </summary>
		/// <param name="num1">The num1.</param>
		/// <param name="num2">The num2.</param>
		/// <returns></returns>
		public double Resta( double num1, double num2 )
		{
			return(num1 - num2);
		}

		/// <summary>
		/// Sumas the specified num1.
		/// </summary>
		/// <param name="num1">The num1.</param>
		/// <param name="num2">The num2.</param>
		/// <returns></returns>
		public double Suma( double num1, double num2 )
		{
			return(num1 + num2);
		}

	}
}
