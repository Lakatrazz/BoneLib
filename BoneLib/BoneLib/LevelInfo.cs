﻿using SLZ.Marrow.Warehouse;

namespace BoneLib
{
    /// <summary>
    /// A <see cref="LevelCrate"/> wrapper for use with <see cref="Hooking"/> Level loading events.
    /// </summary>
    public struct LevelInfo
    {
        public string title;
        public string barcode;
        public LevelCrateReference levelReference;

        public LevelInfo(LevelCrateReference levelReference)
        {
            this.title = levelReference.Crate.Title;
            this.barcode = levelReference.Barcode;
            this.levelReference = levelReference;
        }

        public LevelInfo(LevelCrate level) : this(new LevelCrateReference(level.Barcode)) { }
    }
}
