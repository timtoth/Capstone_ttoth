﻿#pragma checksum "C:\Users\Tim\TheMainEvent\Code\TheMainEvent_Capstone\TheMainEvent_Capstone\Pages\RegistrationPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6B131ABA7B2F38277BAFD1E7985FF90B"
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
    
    
    public partial class RegistrationPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox usernameBox;
        
        internal System.Windows.Controls.TextBox emailBox;
        
        internal System.Windows.Controls.PasswordBox passwordBox;
        
        internal System.Windows.Controls.PasswordBox confirmPasswordBox;
        
        internal System.Windows.Controls.Button Continue;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/TheMainEvent_Capstone;component/Pages/RegistrationPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.usernameBox = ((System.Windows.Controls.TextBox)(this.FindName("usernameBox")));
            this.emailBox = ((System.Windows.Controls.TextBox)(this.FindName("emailBox")));
            this.passwordBox = ((System.Windows.Controls.PasswordBox)(this.FindName("passwordBox")));
            this.confirmPasswordBox = ((System.Windows.Controls.PasswordBox)(this.FindName("confirmPasswordBox")));
            this.Continue = ((System.Windows.Controls.Button)(this.FindName("Continue")));
        }
    }
}

