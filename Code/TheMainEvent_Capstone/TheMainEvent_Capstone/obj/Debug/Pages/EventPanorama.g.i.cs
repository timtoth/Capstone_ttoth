﻿#pragma checksum "C:\Users\Tim\TheMainEvent\Code\TheMainEvent_Capstone\TheMainEvent_Capstone\Pages\EventPanorama.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C420357382EBA8CF79A2D8801FAA9FE5"
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
    
    
    public partial class EventPanorama : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Media.Animation.Storyboard tweetGotFocusStoryboard;
        
        internal System.Windows.Media.Animation.Storyboard tweetLostFocusStoryboard;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.Panorama rootPanorama;
        
        internal System.Windows.Controls.TextBlock dateBlock;
        
        internal System.Windows.Controls.TextBlock timeBlock;
        
        internal System.Windows.Controls.TextBlock costBlock;
        
        internal System.Windows.Controls.TextBlock addressBlock;
        
        internal System.Windows.Controls.TextBlock descriptionBlock;
        
        internal System.Windows.Controls.TextBlock detailsBlock;
        
        internal System.Windows.Controls.TextBlock statusBlock;
        
        internal System.Windows.Controls.Button attendButton;
        
        internal Microsoft.Phone.Controls.PhoneTextBox tweetBox;
        
        internal Microsoft.Phone.Controls.LongListSelector EventsList;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/TheMainEvent_Capstone;component/Pages/EventPanorama.xaml", System.UriKind.Relative));
            this.tweetGotFocusStoryboard = ((System.Windows.Media.Animation.Storyboard)(this.FindName("tweetGotFocusStoryboard")));
            this.tweetLostFocusStoryboard = ((System.Windows.Media.Animation.Storyboard)(this.FindName("tweetLostFocusStoryboard")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.rootPanorama = ((Microsoft.Phone.Controls.Panorama)(this.FindName("rootPanorama")));
            this.dateBlock = ((System.Windows.Controls.TextBlock)(this.FindName("dateBlock")));
            this.timeBlock = ((System.Windows.Controls.TextBlock)(this.FindName("timeBlock")));
            this.costBlock = ((System.Windows.Controls.TextBlock)(this.FindName("costBlock")));
            this.addressBlock = ((System.Windows.Controls.TextBlock)(this.FindName("addressBlock")));
            this.descriptionBlock = ((System.Windows.Controls.TextBlock)(this.FindName("descriptionBlock")));
            this.detailsBlock = ((System.Windows.Controls.TextBlock)(this.FindName("detailsBlock")));
            this.statusBlock = ((System.Windows.Controls.TextBlock)(this.FindName("statusBlock")));
            this.attendButton = ((System.Windows.Controls.Button)(this.FindName("attendButton")));
            this.tweetBox = ((Microsoft.Phone.Controls.PhoneTextBox)(this.FindName("tweetBox")));
            this.EventsList = ((Microsoft.Phone.Controls.LongListSelector)(this.FindName("EventsList")));
        }
    }
}

