using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CircleApplication;


namespace CircleApplication

{
    public class CircleDetails
    {
        private int _radius;

        public CircleDetails()
        {
            _radius = 1;
        }

        public CircleDetails(int radius)
        {
            _radius = radius;
        }

        public int GetRadius()
        {
            return _radius;
        }

        public void SetRadius(int radius)
        {
            _radius = radius;
        }

        public double GetCircumference()
        {
            return 2 * Math.PI * _radius;
        }

        public double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
