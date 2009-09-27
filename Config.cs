﻿
namespace robokins
{
    partial class Bot
    {
        const string Server = "chat.us.freenode.net";
        const int Port = 6667;
        const string Delimiter = ";";
        public const string Username = "robokins";

#if DEBUG
        const string ChannelName = "testahk";
        const string Nick = Username + "|alt";
#endif
#if !DEBUG
        const string ChannelName = "ahk";
        const string Nick = Username;
#endif

        const string Channel = "#" + ChannelName;
        const string NickGroup = Delimiter + Nick + Delimiter + "\\ahk\\bot" + Delimiter;
        const string RealName = "IRC Bot";
        const string InitUsermode = "8";
        const string Usermode = "+CeEiIQ-w";

        const string Operators = Delimiter + "pdpc/supporter/student/titan" +
                                 Delimiter + "unaffiliated/ahklerner" +
                                 Delimiter + "unaffiliated/chalamius" +
                                 Delimiter + "unaffiliated/k3ph" +
                                 Delimiter;

        const int ReceiveDelay = 100;
        const int SendDelay = ReceiveDelay * 2;
        const int SendMicroDelay = SendDelay / 5;

#if PASTE
        const string PasteSync = "/home/titan/public_html/paste/sync";
        const int PasteFreq = 2500;
        const string PasteURI = "http://paste.autohotkey.net/";
#endif

#if RR
        const int RRTicks = 60 * 1000;
        const int RRBan = 1 * RRTicks;
        const int RRWon = 360 * RRTicks;
        const string RRBanFlag = "b";
#endif

#if LKINS
        const string Lolikins = "Lolikins";
#endif
#if MIOKINS
        const string Miokins = "miokins";
#endif
    }
}
