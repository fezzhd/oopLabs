﻿using System;

namespace PCRelated.CurrentClasses
{
    [Serializable]
    class Printers:RelatedCommon
    {
        public string CopyRelosution { get; set; }
        public uint CopySpeen { get; set; }
        public uint MaxSpeedCopy { get; set; }

        public Printers(string type) : base(type)
        {
        }
    }
}
