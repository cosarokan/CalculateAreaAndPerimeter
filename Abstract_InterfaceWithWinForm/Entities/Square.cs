using Abstract_InterfaceWithWinForm.AbstractEntities;
using Abstract_InterfaceWithWinForm.Interfaces;

namespace Abstract_InterfaceWithWinForm.Entities
{
    public class Square : Shape, IDiagonal, IAreaHave, IPerimeterHave
    {
        public int Side { get; set; }

        public double CalculateDiagonal()
        {
            throw new System.NotImplementedException();
        }

        public double CalculateArea()
        {
            try
            {
                return Side * Side;
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
                return 4 * Side;
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
