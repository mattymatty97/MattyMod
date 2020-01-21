//this will fix QueryServer and let it start
//ipv6 quersy server is shifted of 1 port to avoid conflicts
private void StartUp()
{
	ServerConsole.AddLog("Starting query server on port " + this._port + " TCP...");
	this.Users = new List<QueryUser>();
	this.Stopwatch.Start();
	this._checkThr.Start();
	try
	{
		this._listner = new TcpListener(IPAddress.Any, this._port);
		this._listner.Start();
		if (this._useV6)
		{
			this._listnerv6 = new TcpListener(IPAddress.IPv6Any, this._port + 1);
			this._listnerv6.Start();
		}
		while (!this._serverStop)
		{
			if (this._listner != null && this._listner.Pending())
			{
				this.AcceptSocket(this._listner);
			}
			else if (this._listnerv6 != null && this._listnerv6.Pending())
			{
				this.AcceptSocket(this._listnerv6);
			}
			else
			{
				Thread.Sleep(500);
			}
		}
    if(this._listner != null)
		this._listner.Stop();
		if (this._listnerv6 != null)
		{
			this._listnerv6.Stop();
		}
		foreach (QueryUser queryUser in this.Users)
		{
			queryUser.CloseConn(true);
		}
		this.Users.Clear();
		ServerConsole.AddLog("Query server stopped.");
	}
	catch (Exception ex)
	{
		ServerConsole.AddLog("Server ERROR: " + ex.StackTrace);
	}
}
