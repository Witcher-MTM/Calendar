﻿using System;

namespace DLL
{
    public class Note
    {
        public string NoteName { get; set; }
        public string Text { get; set; }
        public DateTime CreationData { get; private set; }

        public Note()
        {
            NoteName = string.Empty;
            Text = string.Empty;
            CreationData = new DateTime();
        }

        public Note(string noteName, string text, DateTime creationData)
        {
            Text = text;
            NoteName = noteName;
            CreationData = creationData;
        }
    }
}
