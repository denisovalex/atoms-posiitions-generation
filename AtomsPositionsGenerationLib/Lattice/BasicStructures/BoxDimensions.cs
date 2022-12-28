namespace AtomsPositionsGenerationLib.Lattice.BasicStructures
{
	public class BoxDimensions
	{
		public double X { get; private set; }
		public double Y { get; private set; }
		public double Z { get; private set; }

		public BoxDimensions(double x, double y, double z)
		{
			X = x;
			Y = y;
			Z = z;
		}
	}
}
