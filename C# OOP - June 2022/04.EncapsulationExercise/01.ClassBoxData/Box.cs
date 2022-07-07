using System;
using System.Collections.Generic;
using System.Text;

namespace _01.ClassBoxData
{
    public class Box
    {
        private const int BoxPropertyMinValue = 0;
        private const string ZeroOrNegativeArgumentException =
            "{0} cannot be zero or negative.";

        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
        public double Length
        { get 
            { 
                return this.length;
            }
            private set
            {
                if (value <= BoxPropertyMinValue)
                {
                    throw new ArgumentException(String.Format(ZeroOrNegativeArgumentException,nameof(this.Length)));
                }
                this.length = value;
            }
            
 
        }
      
        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= BoxPropertyMinValue)
                {
                    throw new ArgumentException(
                        String.Format(ZeroOrNegativeArgumentException, nameof(this.Width)));
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value <= BoxPropertyMinValue)
                {
                    throw new ArgumentException(String.Format(ZeroOrNegativeArgumentException, nameof(this.Height)));
                }
                this.height = value;
            }


        }

        public double SurfaceArea()
        {
            return (2 * this.Length * this.Width) + (2 * this.Length * this.Height) +
            (2 * this.Width * this.Height);
        }

        public double LateralSurfaceArea()
        {
            return (2 * this.Length * this.Height) + (2 * this.Width * this.Height);
        }
         public double Volume()
        {
            return this.Length * this.Width * this.Height;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder
                .AppendLine($"Surface Area - {this.SurfaceArea():F2}")
                .AppendLine($"Lateral Surface Area - {this.LateralSurfaceArea():F2}")
                .AppendLine($"Volume - {this.Volume():F2}");

            return stringBuilder.ToString().TrimEnd();
        }

    }
}
