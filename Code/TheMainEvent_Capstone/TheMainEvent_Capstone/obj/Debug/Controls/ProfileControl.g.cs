﻿#pragma checksum "C:\Users\Tim\TheMainEvent\Code\TheMainEvent_Capstone\TheMainEvent_Capstone\Controls\ProfileControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DAE8DCD7BACEE9C0DC563ACE356240DC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace TheMainEvent_Capstone.Controls {
    
    
    public partial class ProfileControl : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock nameBlock;
        
        internal System.Windows.Controls.TextBlock bioblock;
        
        internal System.Windows.Controls.TextBlock emailBlock;
        
        internal System.Windows.Controls.TextBlock phoneBlock;
        
        internal System.Windows.Controls.Button accountSettings;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/TheMainEvent_Capstone;component/Controls/ProfileControl.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.nameBlock = ((System.Windows.Controls.TextBlock)(this.FindName("nameBlock")));
            this.bioblock = ((System.Windows.Controls.TextBlock)(this.FindName("bioblock")));
            this.emailBlock = ((System.Windows.Controls.TextBlock)(this.FindName("emailBlock")));
            this.phoneBlock = ((System.Windows.Controls.TextBlock)(this.FindName("phoneBlock")));
            this.accountSettings = ((System.Windows.Controls.Button)(this.FindName("accountSettings")));
        }
    }
}

