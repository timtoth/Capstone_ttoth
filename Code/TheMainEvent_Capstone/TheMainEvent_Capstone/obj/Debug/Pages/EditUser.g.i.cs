﻿#pragma checksum "C:\Users\Tim\TheMainEvent\Code\TheMainEvent_Capstone\TheMainEvent_Capstone\Pages\EditUser.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "04564D3DAB2EA438C409B10FBF5B514A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
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


namespace TheMainEvent_Capstone.Pages {
    
    
    public partial class EditUser : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Media.Animation.Storyboard bioGotFocusStoryboard;
        
        internal System.Windows.Media.Animation.Storyboard bioLostFocusStoryboard;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.ScrollViewer ContentScroll;
        
        internal Microsoft.Phone.Controls.PhoneTextBox firstNameBox;
        
        internal Microsoft.Phone.Controls.PhoneTextBox lastNameBox;
        
        internal Microsoft.Phone.Controls.PhoneTextBox phoneBox;
        
        internal Microsoft.Phone.Controls.PhoneTextBox bioBox;
        
        internal Microsoft.Phone.Controls.DatePicker datePicker;
        
        internal System.Windows.Controls.Button doneButton;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/TheMainEvent_Capstone;component/Pages/EditUser.xaml", System.UriKind.Relative));
            this.bioGotFocusStoryboard = ((System.Windows.Media.Animation.Storyboard)(this.FindName("bioGotFocusStoryboard")));
            this.bioLostFocusStoryboard = ((System.Windows.Media.Animation.Storyboard)(this.FindName("bioLostFocusStoryboard")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentScroll = ((System.Windows.Controls.ScrollViewer)(this.FindName("ContentScroll")));
            this.firstNameBox = ((Microsoft.Phone.Controls.PhoneTextBox)(this.FindName("firstNameBox")));
            this.lastNameBox = ((Microsoft.Phone.Controls.PhoneTextBox)(this.FindName("lastNameBox")));
            this.phoneBox = ((Microsoft.Phone.Controls.PhoneTextBox)(this.FindName("phoneBox")));
            this.bioBox = ((Microsoft.Phone.Controls.PhoneTextBox)(this.FindName("bioBox")));
            this.datePicker = ((Microsoft.Phone.Controls.DatePicker)(this.FindName("datePicker")));
            this.doneButton = ((System.Windows.Controls.Button)(this.FindName("doneButton")));
        }
    }
}

