using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYAScieCal.utils
{

    internal class PolynomialModel
    {

        private double[,] term;
        private int degree;

        public PolynomialModel(double[,] term,int degree)
        {

            this.term = term;
            this.degree=degree;

        }

        public double[,] getTerm()
        {

            return this.term;

        }

        public int getDegree()
        {

            return this.degree;

        }

    }
}
