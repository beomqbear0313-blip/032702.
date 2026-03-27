using System;

public class Manager
{
	public readonly DateTime Startup;

	public Manager()
	{
		Startup = DateTime.Now;
	}

	public DateTime GetStartup()
	{
		return Startup;
	}
	
}
