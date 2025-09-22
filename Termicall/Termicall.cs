using System;
using System.Management.Automation;

namespace Termicall
{
    #region Ping
    [Cmdlet(VerbsCommon.Get, "Ping")]
    public class GetPingCommand : Cmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string IP { get; set; }

        protected override void ProcessRecord()
        {
            // ping
        }
    }
    #endregion

    #region Networks
    [Cmdlet(VerbsCommon.Get, "Connections")]
    public class GetNetworksCommand : Cmdlet
    {
        protected override void ProcessRecord()
        {
            // connections
        }
    }
    #endregion

    #region TrackRoute
    [Cmdlet(VerbsDiagnostic.Test, "TrackRoute")]
    public class TrackRouteCommand : Cmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string Target { get; set; }

        protected override void ProcessRecord()
        {
            // trackroute
        }
    }
    #endregion

    #region NameServer
    [Cmdlet(VerbsCommon.Get, "NameServer")]
    public class NameServerCommand : Cmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string Domain { get; set; }

        protected override void ProcessRecord()
        {
            // nameserver
        }
    }
    #endregion

    #region Status
    [Cmdlet(VerbsCommon.Get, "Status")]
    public class StatusCommand : Cmdlet
    {
        protected override void ProcessRecord()
        {
            // networks
        }
    }
    #endregion

    #region SecureShell
    [Cmdlet(VerbsCommunications.Connect, "SecureShell")]
    public class SecureShellCommand : Cmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string Connection { get; set; }

        protected override void ProcessRecord()
        {
            // ssh
        }
    }
    #endregion
}