using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYAScieCal.utils
{

    internal class PolynomialModel
    {

        private double[] coefficient;
        private int degree;

        public PolynomialModel(double[] coefficient,int degree)
        {

            this.coefficient = coefficient;
            this.degree=degree;

        }

        public double[] getCoefficent()
        {

            return this.coefficient;

        }

        public int getDegree()
        {

            return this.degree;

        }

    }
}
