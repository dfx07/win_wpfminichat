﻿#pragma checksum "..\..\..\Controls\CReaction.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BE0238604A605F110C3134E82389CDA24D4934D1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
using wpf_foxchat.Controls;


namespace wpf_foxchat.Controls {
    
    
    /// <summary>
    /// CReaction
    /// </summary>
    public partial class CReaction : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 97 "..\..\..\Controls\CReaction.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border xBoder_Reaction;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\Controls\CReaction.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.TranslateTransform ActionTranslate;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\Controls\CReaction.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ScaleTransform ActionScale;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\..\Controls\CReaction.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button React_Like;
        
        #line default
        #line hidden
        
        
        #line 148 "..\..\..\Controls\CReaction.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button React_Haha;
        
        #line default
        #line hidden
        
        
        #line 154 "..\..\..\Controls\CReaction.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button React_Love;
        
        #line default
        #line hidden
        
        
        #line 160 "..\..\..\Controls\CReaction.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button React_Wow;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\..\Controls\CReaction.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button React_Sad;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/wpf_foxchat;component/controls/creaction.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Controls\CReaction.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.xBoder_Reaction = ((System.Windows.Controls.Border)(target));
            return;
            case 2:
            this.ActionTranslate = ((System.Windows.Media.TranslateTransform)(target));
            return;
            case 3:
            this.ActionScale = ((System.Windows.Media.ScaleTransform)(target));
            return;
            case 4:
            this.React_Like = ((System.Windows.Controls.Button)(target));
            
            #line 143 "..\..\..\Controls\CReaction.xaml"
            this.React_Like.Click += new System.Windows.RoutedEventHandler(this.Btn_React_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.React_Haha = ((System.Windows.Controls.Button)(target));
            
            #line 149 "..\..\..\Controls\CReaction.xaml"
            this.React_Haha.Click += new System.Windows.RoutedEventHandler(this.Btn_React_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.React_Love = ((System.Windows.Controls.Button)(target));
            
            #line 155 "..\..\..\Controls\CReaction.xaml"
            this.React_Love.Click += new System.Windows.RoutedEventHandler(this.Btn_React_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.React_Wow = ((System.Windows.Controls.Button)(target));
            
            #line 161 "..\..\..\Controls\CReaction.xaml"
            this.React_Wow.Click += new System.Windows.RoutedEventHandler(this.Btn_React_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.React_Sad = ((System.Windows.Controls.Button)(target));
            
            #line 167 "..\..\..\Controls\CReaction.xaml"
            this.React_Sad.Click += new System.Windows.RoutedEventHandler(this.Btn_React_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

