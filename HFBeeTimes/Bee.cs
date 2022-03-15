namespace HFBeeTimes
{
	public class Bee
	{
		public Bee(string job)
		{ 
			Job = job;
		}
		public string Job { get; }

		public virtual float CostPerShift { get; set; }

		public virtual void WorkTheNextShift (float honeyConsumed)
		{

			if (HoneyVault.ConsumeHoney(honeyConsumed) == true)
			{
				DoJob();
			}

		}
		protected virtual void DoJob()
		{ 
		
		
		}
	}
}
