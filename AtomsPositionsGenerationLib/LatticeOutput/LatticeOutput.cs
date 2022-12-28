using AtomsPositionsGenerationLib.Lattice;
using System.Globalization;

namespace AtomsPositionsGenerationLib.LatticeOutput
{
	public static class LatticeOutput
	{
		public static void LAMMPSAtomicDataFile(ILattice lattice, string path)
		{
			var ic = CultureInfo.InvariantCulture;

			var sw = new StreamWriter(path, false);

			sw.Write("Some description\n\n");

			sw.Write("{0} atoms\n", lattice.Particles.Count);
			sw.Write("1 atom types\n");
			sw.Write("0.0 {0} xlo xhi\n", lattice.BoxDimensions.X.ToString(ic));
			sw.Write("0.0 {0} ylo yhi\n", lattice.BoxDimensions.Y.ToString(ic));
			sw.Write("0.0 {0} zlo zhi\n\n", lattice.BoxDimensions.Z.ToString(ic));

			sw.Write("Atoms\n\n");

			int id = 1;
			foreach (var particle in lattice.Particles)
			{
				sw.WriteLine("{0} 1 {1} {2} {3}", id, particle.XPosition.ToString(ic), particle.YPosition.ToString(ic), particle.ZPosition.ToString(ic));
				++id;
			}

			sw.Close();
		}
	}
}
