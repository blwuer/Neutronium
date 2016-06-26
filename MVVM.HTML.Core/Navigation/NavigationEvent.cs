﻿using System;

namespace MVVM.HTML.Core.Navigation
{
    public class NavigationEvent : EventArgs
    {
        public object NewViewModel { get; }

        public object OldViewModel { get; }

        public NavigationEvent(object newViewModel, object oldViewModel)
        {
            NewViewModel = newViewModel;
            OldViewModel = oldViewModel;
        }
    }
}
