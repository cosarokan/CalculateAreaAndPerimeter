using Abstract_InterfaceWithWinForm.AbstractEntities;
using Abstract_InterfaceWithWinForm.Interfaces;

namespace Abstract_InterfaceWithWinForm.Entities
{
    public class Triangle : Shape, IAreaHave, IPerimeterHave, IDiagonal
    {
        public int FirstSide { get; set; }
        public int SecondSide { get; set; }
        public int ThirdSide { get; set; }
        public int Height { get; set; }

        public double CalculateArea()
        {
            try
            {
                return (FirstSide * Height) / 2;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public double CalculateDiagonal()
        {
            throw new System.NotImplementedException();
        }

        public double CalculatePerimeter()
        {
            try
            {
                return FirstSide + SecondSide + ThirdSide;
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
