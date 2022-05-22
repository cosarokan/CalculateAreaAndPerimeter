using Abstract_InterfaceWithWinForm.AbstractEntities;
using Abstract_InterfaceWithWinForm.Interfaces;
using System;

namespace Abstract_InterfaceWithWinForm.Entities
{
    public class Circle : Shape, IAreaHave, IPerimeterHave
    {
        public double PiNumber { get; set; } = 3.14;
        public double Radius { get; set; }
        public double CalculateArea()
        {
            try
            {
                return (PiNumber * Math.Pow(Radius, 2));
            }
            catch (Exception)
            {
                throw;
            }
        }
        public double CalculatePerimeter()
        {
            try
            {
                return (2 * PiNumber * Radius);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
