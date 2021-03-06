﻿using System;
using robokins.IRC;

namespace robokins
{
    partial class Bot
    {
        bool Invoke(Message message)
        {
            message.Text = message.Text.Trim();

            if (message.User.Host == "services." || message.User.Ident == "freenode" || message.User.Nick.Length == 0 || message.Text.Length == 0)
                return false;

            bool query = message.Target[0] != '#';
            char first = message.Text[0];
            string word = message.Text.Split(new[] { ' ' }, 2, StringSplitOptions.RemoveEmptyEntries)[0].ToLowerInvariant();
            string nickLow = Nick.ToLowerInvariant();

            if (TriggerPrefixes.IndexOf(first) != -1)
            {
                int remove = 1;
                word = word.Substring(1);
                if (word.Equals(ChannelName, StringComparison.OrdinalIgnoreCase) || word == nickLow)
                    remove += word.Length;
                message.Text = message.Text.Substring(remove).Trim();
                return message.Text.Length != 0;
            }
            else if (word.IndexOf(nickLow) == 0)
            {
                bool range = Nick.Length < word.Length;
                bool bound = range ? !char.IsLetterOrDigit(word, Nick.Length) : false;
                if (!range || (range && bound))
                {
                    message.Text = message.Text.Substring(Nick.Length + (bound ? 1 : 0)).Trim();
                    return message.Text.Length != 0;
                }
                else
                    return query;
            }
            else
                return query;
        }
    }
}
