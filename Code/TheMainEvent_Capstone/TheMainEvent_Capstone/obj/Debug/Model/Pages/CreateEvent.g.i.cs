﻿#pragma checksum "C:\Users\Tim\TheMainEvent\Code\TheMainEvent_Capstone\TheMainEvent_Capstone\Model\Pages\CreateEvent.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FEE39DDF255A64CBDFB9F8B6D7E03554"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
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
    
    
    public partial class CreateEvent : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel ContentPanel;
        
        internal System.Windows.Controls.TextBox title;
        
        internal System.Windows.Controls.TextBox address;
        
        internal System.Windows.Controls.TextBox state;
        
        internal System.Windows.Controls.TextBox city;
        
        internal System.Windows.Controls.ScrollViewer scrollViewer;
        
        internal Microsoft.Phone.Controls.PhoneTextBox description;
        
        internal Microsoft.Phone.Controls.DatePicker date;
        
        internal Microsoft.Phone.Controls.TimePicker time;
        
        internal System.Windows.Controls.ScrollViewer scrollViewerOtherDetails;
        
        internal Microsoft.Phone.Controls.PhoneTextBox otherDetails;
        
        internal System.Windows.Controls.TextBox cost;
        
        internal Microsoft.Phone.Controls.ExpanderView inviteExpander;
        
        internal Microsoft.Phone.Controls.LongListMultiSelector contacts;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/TheMainEvent_Capstone;component/Model/Pages/CreateEvent.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.StackPanel)(this.FindName("ContentPanel")));
            this.title = ((System.Windows.Controls.TextBox)(this.FindName("title")));
            this.address = ((System.Windows.Controls.TextBox)(this.FindName("address")));
            this.state = ((System.Windows.Controls.TextBox)(this.FindName("state")));
            this.city = ((System.Windows.Controls.TextBox)(this.FindName("city")));
            this.scrollViewer = ((System.Windows.Controls.ScrollViewer)(this.FindName("scrollViewer")));
            this.description = ((Microsoft.Phone.Controls.PhoneTextBox)(this.FindName("description")));
            this.date = ((Microsoft.Phone.Controls.DatePicker)(this.FindName("date")));
            this.time = ((Microsoft.Phone.Controls.TimePicker)(this.FindName("time")));
            this.scrollViewerOtherDetails = ((System.Windows.Controls.ScrollViewer)(this.FindName("scrollViewerOtherDetails")));
            this.otherDetails = ((Microsoft.Phone.Controls.PhoneTextBox)(this.FindName("otherDetails")));
            this.cost = ((System.Windows.Controls.TextBox)(this.FindName("cost")));
            this.inviteExpander = ((Microsoft.Phone.Controls.ExpanderView)(this.FindName("inviteExpander")));
            this.contacts = ((Microsoft.Phone.Controls.LongListMultiSelector)(this.FindName("contacts")));
        }
    }
}

