using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	class Circle : Shapes
	{
		public override void calculateArea()
		{

		}
	}

	--------------------------------------------------


	class Circle : IShapes
	{
		public void calculateArea()
		{

		}

		public void calculatePerimeter()
		{

		}
	}
}
