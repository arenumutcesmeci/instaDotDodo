﻿#pragma checksum "..\..\..\UserQueryWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A29E0B852666DED95A47EE2FEE5492579F90EBE1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FontAwesome.WPF;
using FontAwesome.WPF.Converters;
using InstaDot;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace InstaDot {
    
    
    /// <summary>
    /// UserQueryWindow
    /// </summary>
    public partial class UserQueryWindow : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\UserQueryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal InstaDot.UserQueryWindow UserQuery;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\UserQueryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RefreshBtn;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\UserQueryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UsernameTxt;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\UserQueryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SearchBtn;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\UserQueryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel UserInfo;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\UserQueryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ProfilePicture;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\UserQueryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Username;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\UserQueryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label FullName;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\UserQueryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Followers;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\UserQueryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Following;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\UserQueryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FollowFollowers;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\UserQueryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FollowFollowings;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/InstaDot;component/userquerywindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserQueryWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.UserQuery = ((InstaDot.UserQueryWindow)(target));
            return;
            case 2:
            this.RefreshBtn = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\UserQueryWindow.xaml"
            this.RefreshBtn.Click += new System.Windows.RoutedEventHandler(this.RefreshBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.UsernameTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.SearchBtn = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\UserQueryWindow.xaml"
            this.SearchBtn.Click += new System.Windows.RoutedEventHandler(this.SearchBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.UserInfo = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.ProfilePicture = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.Username = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.FullName = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.Followers = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.Following = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.FollowFollowers = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\UserQueryWindow.xaml"
            this.FollowFollowers.Click += new System.Windows.RoutedEventHandler(this.FollowFollowers_OnClick);
            
            #line default
            #line hidden
            return;
            case 12:
            this.FollowFollowings = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\UserQueryWindow.xaml"
            this.FollowFollowings.Click += new System.Windows.RoutedEventHandler(this.FollowFollowings_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

