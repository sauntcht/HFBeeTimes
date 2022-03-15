namespace HFBeeTimes
{
	public static class HoneyVault
	{
		private const float NECTAR_CONVERSION_RATIO = .19f;
		private const float LOW_LEVEL_WARNING = 10f;


		public static string StatusReport => statusReport;

		private static string statusReport = $"Honey Level : {honey} \nNectar Level:{nectar}";

		private static string lowLevelWarning ="Low Honey - add a Honey Manufacturer";

								

		private static float honey = 25f;
		private static float nectar = 100f;

		public static void CollectNectar(float amount)
		{ 
		if (amount > 0 ) nectar += amount;
		}
		public static void ConvertNectarToHoney(float amount)
		{
			if (amount < nectar)
			{
				honey += (nectar * NECTAR_CONVERSION_RATIO);
				nectar = 0;
			}
			else
			{
				honey += (amount * NECTAR_CONVERSION_RATIO);
				nectar -= amount;
			}
			
		}
		public static bool ConsumeHoney(float amount)
		{
			if (amount >= honey)
			{
				honey -= amount;
				return true;
			}
			else 
				return false;
		}



	}
}
