﻿#pragma checksum "C:\Users\Tim\TheMainEvent\Code\TheMainEvent_Capstone\TheMainEvent_Capstone\Pages\MainPages.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "92725372DEED9D9DE3F5C541BAB6D20F"
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
    
    
    public partial class MainPages : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Button FindEvent;
        
        internal System.Windows.Controls.Button CreateEvent;
        
        internal Microsoft.Phone.Controls.ListPicker optionFilter;
        
        internal Microsoft.Phone.Controls.ListPickerItem nameOption;
        
        internal Microsoft.Phone.Controls.ListPickerItem dateOption;
        
        internal Microsoft.Phone.Controls.ListPickerItem typeOption;
        
        internal Microsoft.Phone.Controls.LongListSelector EventsList;
        
        internal Microsoft.Phone.Controls.LongListSelector InviteList;
        
        internal Microsoft.Phone.Controls.PivotItem ProfilePage;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/TheMainEvent_Capstone;component/Pages/MainPages.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.FindEvent = ((System.Windows.Controls.Button)(this.FindName("FindEvent")));
            this.CreateEvent = ((System.Windows.Controls.Button)(this.FindName("CreateEvent")));
            this.optionFilter = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("optionFilter")));
            this.nameOption = ((Microsoft.Phone.Controls.ListPickerItem)(this.FindName("nameOption")));
            this.dateOption = ((Microsoft.Phone.Controls.ListPickerItem)(this.FindName("dateOption")));
            this.typeOption = ((Microsoft.Phone.Controls.ListPickerItem)(this.FindName("typeOption")));
            this.EventsList = ((Microsoft.Phone.Controls.LongListSelector)(this.FindName("EventsList")));
            this.InviteList = ((Microsoft.Phone.Controls.LongListSelector)(this.FindName("InviteList")));
            this.ProfilePage = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("ProfilePage")));
            this.nameBlock = ((System.Windows.Controls.TextBlock)(this.FindName("nameBlock")));
            this.bioblock = ((System.Windows.Controls.TextBlock)(this.FindName("bioblock")));
            this.emailBlock = ((System.Windows.Controls.TextBlock)(this.FindName("emailBlock")));
            this.phoneBlock = ((System.Windows.Controls.TextBlock)(this.FindName("phoneBlock")));
            this.accountSettings = ((System.Windows.Controls.Button)(this.FindName("accountSettings")));
        }
    }
}

