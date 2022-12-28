using AtomsPositionsGenerationLib.Lattice.BasicStructures;
using AtomsPositionsGenerationLib.Lattice;
using AtomsPositionsGenerationLib.LatticeOutput;

namespace App
{
	class Program
	{
		static void Main()
		{
			var box = new BoxDimensions(20, 20, 40);

			var po = new ElementInfo(84, 208.982, 3.345);
			var poLattice = new PCLattice(box, po);
			poLattice.Create();

			var na = new ElementInfo(11, 22.9897, 4.2906);
			var naLattice = new BCCLattice(box, na);
			naLattice.Create();

			var al = new ElementInfo(13, 2.375, 4.0479);
			var alLattice = new FCCLattice(box, al);
			alLattice.Create();

			LatticeOutput.LAMMPSAtomicDataFile(poLattice, "../../../Output Files/dataPO.txt");
			LatticeOutput.LAMMPSAtomicDataFile(naLattice, "../../../Output Files/dataNA.txt");
			LatticeOutput.LAMMPSAtomicDataFile(alLattice, "../../../Output Files/dataAL.txt");
		}
	}
}
