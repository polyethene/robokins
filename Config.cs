﻿
namespace robokins
{
    partial class Bot
    {
        const string Server = "irc.freenode.net";
        const int Port = 6667;
        const string Delimiter = ";";
        internal const string Username = "robokins";
        const string TriggerPrefixes = "!";

        const string Website = "http://www.autohotkey.net/";

#if DEBUG && !PRODUCTION
        const string ChannelName = "testahk";
        const string Nick = Username + "|alt";
#else
        const string ChannelName = "ahk";
        const string Nick = Username;
#endif

        const string Channel = "#" + ChannelName;
        const string RealName = "IRC Bot";
        const string InitUsermode = "8";
        const string Usermode = "+iR";

        const string Operators = Delimiter + "pdpc/supporter/student/titan" + Delimiter;

        const int ReceiveDelay = 100;
        const int SendDelay = ReceiveDelay * 2;
        const int SendMicroDelay = SendDelay / 5;

        const int PasteFreq = 2500;
    }
}
