﻿using System;

namespace SignalR
{
    [Serializable]
    public class Message
    {
        // Core properties
        public string Source { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }

        public string CommandId { get; set; }
        public bool WaitForAck { get; set; }
        public bool IsAck { get; set; }

        public bool IsCommand
        {
            get
            {
                return CommandId != null;
            }
        }

        public Message()
        {
        }
        
        public Message(string source, string key, string value)
        {
            Source = source;
            Key = key;
            Value = value;
        }
    }
}