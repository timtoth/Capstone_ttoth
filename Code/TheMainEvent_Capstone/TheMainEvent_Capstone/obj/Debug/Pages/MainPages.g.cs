﻿#pragma checksum "C:\Users\Tim\TheMainEvent\Code\TheMainEvent_Capstone\TheMainEvent_Capstone\Pages\MainPages.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6C379FAC418A58A359DA0C572124BB3A"
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
using Microsoft.Phone.Shell;
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
        
        internal Microsoft.Phone.Shell.ApplicationBar defaultBar;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.ProgressBar loadingBar;
        
        internal Microsoft.Phone.Controls.Pivot MainPivot;
        
        internal System.Windows.Controls.StackPanel noEventContainer;
        
        internal Microsoft.Phone.Controls.LongListSelector EventsList;
        
        internal System.Windows.Controls.StackPanel noContactsContainer;
        
        internal Microsoft.Phone.Controls.LongListSelector ContactList;
        
        internal System.Windows.Controls.StackPanel noInvitesContainer;
        
        internal Microsoft.Phone.Controls.LongListSelector InviteList;
        
        internal Microsoft.Phone.Controls.PivotItem ProfilePage;
        
        internal System.Windows.Controls.Image proImage;
        
        internal System.Windows.Controls.TextBlock emailBlock;
        
        internal System.Windows.Controls.TextBlock phoneBlock;
        
        internal System.Windows.Controls.TextBlock bDayBlock;
        
        internal System.Windows.Controls.TextBlock bioblock;
        
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
            this.defaultBar = ((Microsoft.Phone.Shell.ApplicationBar)(this.FindName("defaultBar")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.loadingBar = ((System.Windows.Controls.ProgressBar)(this.FindName("loadingBar")));
            this.MainPivot = ((Microsoft.Phone.Controls.Pivot)(this.FindName("MainPivot")));
            this.noEventContainer = ((System.Windows.Controls.StackPanel)(this.FindName("noEventContainer")));
            this.EventsList = ((Microsoft.Phone.Controls.LongListSelector)(this.FindName("EventsList")));
            this.noContactsContainer = ((System.Windows.Controls.StackPanel)(this.FindName("noContactsContainer")));
            this.ContactList = ((Microsoft.Phone.Controls.LongListSelector)(this.FindName("ContactList")));
            this.noInvitesContainer = ((System.Windows.Controls.StackPanel)(this.FindName("noInvitesContainer")));
            this.InviteList = ((Microsoft.Phone.Controls.LongListSelector)(this.FindName("InviteList")));
            this.ProfilePage = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("ProfilePage")));
            this.proImage = ((System.Windows.Controls.Image)(this.FindName("proImage")));
            this.emailBlock = ((System.Windows.Controls.TextBlock)(this.FindName("emailBlock")));
            this.phoneBlock = ((System.Windows.Controls.TextBlock)(this.FindName("phoneBlock")));
            this.bDayBlock = ((System.Windows.Controls.TextBlock)(this.FindName("bDayBlock")));
            this.bioblock = ((System.Windows.Controls.TextBlock)(this.FindName("bioblock")));
        }
    }
}

