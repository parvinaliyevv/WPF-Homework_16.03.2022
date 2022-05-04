﻿#pragma checksum "..\..\..\..\Views\VideoPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0FCB56E21D50941981039E7AD6768C8D5FFDE43E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace EyeMedia.Views {
    
    
    /// <summary>
    /// VideoPage
    /// </summary>
    public partial class VideoPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\..\Views\VideoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement Media;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Views\VideoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PlayOrStopButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/EyeMedia;component/views/videopage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\VideoPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 19 "..\..\..\..\Views\VideoPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ReturnMenu_ButtonClicked);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 23 "..\..\..\..\Views\VideoPage.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.CheckBox_Checked);
            
            #line default
            #line hidden
            
            #line 23 "..\..\..\..\Views\VideoPage.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.CheckBox_Unchecked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Media = ((System.Windows.Controls.MediaElement)(target));
            
            #line 27 "..\..\..\..\Views\VideoPage.xaml"
            this.Media.Loaded += new System.Windows.RoutedEventHandler(this.Media_Loaded);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 35 "..\..\..\..\Views\VideoPage.xaml"
            ((System.Windows.Controls.Primitives.RepeatButton)(target)).Click += new System.Windows.RoutedEventHandler(this.RewingVideo_ButtonClicked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PlayOrStopButton = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\..\Views\VideoPage.xaml"
            this.PlayOrStopButton.Click += new System.Windows.RoutedEventHandler(this.ResumeVideo_ButtonClicked);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 43 "..\..\..\..\Views\VideoPage.xaml"
            ((System.Windows.Controls.Primitives.RepeatButton)(target)).Click += new System.Windows.RoutedEventHandler(this.ForwardVideo_ButtonClicked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

