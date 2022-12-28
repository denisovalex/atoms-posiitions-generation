namespace AtomsPositionsGenerationLib.Lattice.BasicStructures
{
	public class Particle
	{
		public ElementInfo ElementInfo { get; private set; }
		public double XPosition { get; private set; }
		public double YPosition { get; private set; }
		public double ZPosition { get; private set; }

		public Particle(ElementInfo elementInfo, double x, double y, double z)
		{
			ElementInfo = elementInfo;
			XPosition = x;
			YPosition = y;
			ZPosition = z;
		}

	}
}
