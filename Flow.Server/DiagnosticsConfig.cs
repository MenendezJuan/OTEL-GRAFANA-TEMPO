using System.Diagnostics;

namespace Flow.Server;

public static class DiagnosticsConfig
{
    public const string ServiceName = "MiServicio";
    public static ActivitySource ActivitySource = new ActivitySource(ServiceName);
}