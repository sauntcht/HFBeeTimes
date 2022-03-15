namespace HFBeeTimes
{
	public class Queen : Bee
	{
		public Queen() : base("Queen") { }

		public override float CostPerShift { get => base.CostPerShift; set => base.CostPerShift = 2.15f; }

		

	}
}
