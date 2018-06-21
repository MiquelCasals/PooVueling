using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVueling
{
	public interface ICalculadora
	{
		int Suma(int num1, int num2);
		double Suma(double num1, double num2);
		int Resta(int num1, int num2);
		double Resta(double num1, double num2);
		int Multiplicacion(int num1, int num2);
		double Multiplicacion(double num1, double num2);
		int Division(int num1, int num2);
		double Division(double num1, double num2);
	}
}
