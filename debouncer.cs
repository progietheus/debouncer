using System;
using System.Threading;

public class Debouncer
{
	public event EventHandler Idled = delegate { };
	public int WaitingMilliSeconds { get; set; }
	System.Threading.Timer waitingTimer;

	public Debouncer(int waitingMilliSeconds = 600)
	{
		WaitingMilliSeconds = waitingMilliSeconds;
		waitingTimer = new Timer(p =>
		{
			Idled(this, EventArgs.Empty);
		});
	}
	public void TextChanged()
	{
		waitingTimer.Change(WaitingMilliSeconds, System.Threading.Timeout.Infinite);
	}
}