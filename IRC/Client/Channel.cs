﻿using System.Collections.Generic;

namespace robokins.IRC
{
    partial class Client
    {
        public void Join(IEnumerable<string> channel, IEnumerable<string> key)
        {
            Join(Concat(channel), Concat(key));
        }

        public void Join(string channel, string key)
        {
            RawMessage(JOIN, channel, key, false);
        }

        public void Part(IEnumerable<string> channel, string message)
        {
            Part(Concat(channel), message);
        }

        public void Part(string channel, string message)
        {
            RawMessage(PART, channel, message, true);
        }

        public void Mode(string target, string flags)
        {
            RawMessage(MODE, target, flags, false);
        }

        public void Topic(string channel, string topic)
        {
            RawMessage(TOPIC, channel, topic, true);
        }

        public void Names(IEnumerable<string> channel, string target)
        {
            Names(Concat(channel), target);
        }

        public void Names(string channel, string target)
        {
            RawMessage(NAMES, channel, target, false);
        }

        public void List(IEnumerable<string> channel, string target)
        {
            List(Concat(channel), target);
        }

        public void List(string channel, string target)
        {
            RawMessage(LIST, channel, target, false);
        }

        public void Invite(string nickname, string channel)
        {
            send.Write(INVITE);
            send.Write(' ');
            send.Write(nickname);
            send.Write(' ');
            send.WriteLine(channel);
            send.Flush();
        }

        public void Kick(IEnumerable<string> channel, IEnumerable<string> user, string comment)
        {
            Kick(Concat(channel), Concat(user), comment);
        }

        public void Kick(string channel, string user, string comment)
        {
            send.Write(KICK);
            send.Write(' ');
            send.Write(channel);
            send.Write(' ');
            send.Write(user);
            send.Write(" :");
            send.WriteLine(comment);
            send.Flush();
        }


        void RawMessage(string command, string channel, string text, bool delimit)
        {
            send.Write(command);
            send.Write(' ');
            send.Write(channel);
            send.Write(' ');
            if (delimit)
                send.Write(':');
            send.WriteLine(text);
            send.Flush();
        }
    }
}
