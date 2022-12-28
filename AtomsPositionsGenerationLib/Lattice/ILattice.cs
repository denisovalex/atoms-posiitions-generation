using AtomsPositionsGenerationLib.Lattice.BasicStructures;

namespace AtomsPositionsGenerationLib.Lattice
{
	public interface ILattice
	{
		public BoxDimensions BoxDimensions { get; }
		public ElementInfo ElementInfo { get; }
		public List<Particle> Particles { get; }
		public void Create();
	}
}
