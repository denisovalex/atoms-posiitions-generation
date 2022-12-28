using AtomsPositionsGenerationLib.Lattice.BasicStructures;

namespace AtomsPositionsGenerationLib.Lattice
{
	public class BCCLattice : ILattice
	{
		public BoxDimensions BoxDimensions { get; private set; }
		public ElementInfo ElementInfo { get; private set; }
		public List<Particle> Particles { get; private set; }

		public BCCLattice(BoxDimensions boxDimensions, ElementInfo elementInfo)
		{
			BoxDimensions = boxDimensions;
			ElementInfo = elementInfo;
		}

		public void Create()
		{
			Particles = new List<Particle>();

			Particles.AddRange(CreateParticlessOfCertainType(0, 0, 0));
			Particles.AddRange(CreateParticlessOfCertainType(0.5, 0.5, 0.5));
		}

		private List<Particle> CreateParticlessOfCertainType(double xDelta, double yDelta, double zDelta)
		{
			List<Particle> particles = new List<Particle>();

			for (int x = 0; x < BoxDimensions.X + 1; ++x)
			{
				for (int y = 0; y < BoxDimensions.Y + 1; ++y)
				{
					for (int z = 0; z < BoxDimensions.Z + 1; ++z)
					{
						particles.Add(new Particle(ElementInfo,
							(x + xDelta) * ElementInfo.LatticeParameter,
							(y + yDelta) * ElementInfo.LatticeParameter,
							(z + zDelta) * ElementInfo.LatticeParameter));
					}
				}
			}

			return particles;
		}
	}
}
