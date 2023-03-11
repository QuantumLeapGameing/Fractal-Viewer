using System;
using System.Collections.Generic;
using System.Text;

namespace Mandelbrot_Set
{
    public class ComplexNumbers
    {
        public Double r  = 0; //r
        public Double i = 0; //i

        public ComplexNumbers(double r  , double i)
        {
            this.r = r ;
            this.i = i;
        }
        public void square()
        {
            Double temp = (r * r) - (i * i);
            i = 2.0 * r  * i;
            r  = temp;
        }

        public void ne_square()
        {
            Double temp = (r * r) - (i * i);
            i = -2.0 * r * i;
            r = temp;
        }

        public void in_square()
        {
            Double temp = (r * r) - (i * i);
            i = 2.0 * Math.Abs(r * i);
            r = temp;
        }

        public void ne_in_square()
        {
            Double temp = (r * r) - (i * i);
            i = 2.0 * r * Math.Abs(i);
            r = temp;
        }

        public void in_ne_square()
        {
            Double temp = (r * r) - (i * i);
            i = -2.0 * i * Math.Abs(r);
            r = temp;
        }
        public void i_square()
        {
            Double temp = (r * r) - (i * Math.Abs(i));
            i = 2.0 * Math.Abs(i) * r;
            r = temp;
        }

        public void in_pos_square()
        {
            Double temp = (r * Math.Abs(r)) + (i * i);
            i = -2.0 * Math.Abs(i * r);
            r = temp;
        }

        public void in_r_square()
        {
            Double temp = (r * Math.Abs(r)) - (i * i);
            i = -2.0 * Math.Abs(r) * i;
            r = temp;
        }
        public void pos_1r_square()
        {
            Double temp = (r * Math.Abs(r)) + (i * i);
            i = 2.0 * r * i;
            r = temp;
        }

        public void in_1r_square()
        {
            Double temp = (r * Math.Abs(r)) - (i * i);
            i = -2.0 * r * i;
            r = temp;
        }

        public double Magnatuide()
        {
            return Math.Sqrt((r * r) + (i * i));
        }

        public void s_r_i_square()
        {
            Double temp = (-1 * Math.Abs(r) * r) - (Math.Abs(i) * i);
            i = 2.0 * r * Math.Abs(i);
            r = temp;
        }

        public bool MagnatuideGreaterThan(int v)
        {
            return ((r * r) + (i * i)) > v*v;
        }

        public void add(ComplexNumbers c)
        {
            r  += c.r;
            i += c.i;
        }

        public void abs()
        {
            i = Math.Abs(i);
            r = Math.Abs(r);
        }
    }

    //public class BigComplexNumbers
    //{
    //    public decimal  r = 0; //r
    //    public decimal i = 0; //i

    //    public BigComplexNumbers(decimal r, decimal i)
    //    {
    //        this.r = r;
    //        this.i = i;
    //    }
    //    public void square()
    //    {
    //        decimal two = 2;
    //        decimal temp = (r * r) - (i * i);
    //        i = two * r * i;
    //        r = temp;
    //    }

    //    public void nesquare()
    //    {
    //        decimal ntwo = -2;
    //        decimal temp = (r * r) - (i * i);
    //        i = ntwo * r * i;
    //        r = temp;
    //    }

    //    public void insquare()
    //    {
    //        decimal two = 2;
    //        decimal temp = (r * r) - (i * i);
    //        i = two * Math.Abs(r * i);
    //        r = temp;
    //    }

    //    public void neinsquare()
    //    {
    //        decimal two = 2;
    //        decimal temp = (r * r) - (i * i);
    //        i = two * r * Math.Abs(i);
    //        r = temp;
    //    }

    //    //public double Magnatuide()
    //    //{
    //    //    return Math.Sqrt((r * r) + (i * i));
    //    //}

    //    public bool MagnatuideGreaterThan(int v)
    //    {
    //        return ((r * r) + (i * i)) > v * v;
    //    }

    //    public void add(BigComplexNumbers c)
    //    {
    //        r += c.r;
    //        i += c.i;
    //    }

    //    public void abs()
    //    {
    //        i = Math.Abs(i);
    //        r = Math.Abs(r);
    //    }
    //}
}
