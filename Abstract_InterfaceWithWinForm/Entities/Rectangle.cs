using Abstract_InterfaceWithWinForm.AbstractEntities;
using Abstract_InterfaceWithWinForm.Interfaces;

namespace Abstract_InterfaceWithWinForm.Entities
{
    public class Rectangle : Shape, IAreaHave, IPerimeterHave
    {
        // bir class birden fazla class'tan kalıtım alamaz!
        // bir class birden fazla interface'ten kalıtım alabilir!

        public int ShortSide { get; set; }
        public int LongSide { get; set; }

        public double CalculateArea()
        {
            try
            {
                return ShortSide * LongSide;
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        public double CalculatePerimeter()
        {
            try
            {
                return 2 * (ShortSide + LongSide);
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
