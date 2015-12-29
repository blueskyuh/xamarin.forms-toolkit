﻿using System;

namespace FormsToolkit.iOS
{
    /// <summary>
    /// Toolkit.
    /// </summary>
    public static class Toolkit
    {
        /// <summary>
        /// Init this instance.
        /// </summary>
        public static void Init()
        {
            StandardImageCellRenderer.Init();
            StandardTextCellRenderer.Init();
            StandardViewCellRenderer.Init();
            EntryLineRenderer.Init();
            ListViewGroupedRenderer.Init();
            EmailValidatorBehavior.Init();
            EmptyValidatorBehavior.Init();
            NavigationPageNoLineRenderer.Init();
            BooleanToObjectConverter<string>.Init();
            HexToColorConverter.Init();
            InvertedBoolenConverter.Init();
        }
    }
}

