namespace AtomsPositionsGenerationLib.Lattice.BasicStructures
{
	public class ElementInfo
	{
		public byte PeriodicTableNumber { get; private set; }
		public double AEM { get; private set; }
		public double LatticeParameter { get; private set; }

		public ElementInfo(byte periodicTableNumber, double aem, double latticeParameter)
		{
			PeriodicTableNumber = periodicTableNumber;
			AEM = aem;
			LatticeParameter = latticeParameter;
		}
	}
}