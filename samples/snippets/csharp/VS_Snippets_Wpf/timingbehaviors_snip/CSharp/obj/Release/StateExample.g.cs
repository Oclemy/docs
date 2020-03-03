﻿#pragma checksum "..\..\StateExample.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DC615991EF2703576FA18302A5992E076663C97F2DB43B177480E4EB6E276F3B"
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


namespace Microsoft.Samples.Animation.TimingBehaviors {
    
    
    /// <summary>
    /// StateExample
    /// </summary>
    public partial class StateExample : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\StateExample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ParentTimelineStateTextBlock;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\StateExample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Animation1StateTextBlock;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\StateExample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle Rectangle01;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\StateExample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Animation2StateTextBlock;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\StateExample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle Rectangle02;
        
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
            System.Uri resourceLocater = new System.Uri("/TimingBehaviors_markup;component/stateexample.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\StateExample.xaml"
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
            this.ParentTimelineStateTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.Animation1StateTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.Rectangle01 = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 4:
            this.Animation2StateTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.Rectangle02 = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 6:
            
            #line 25 "..\..\StateExample.xaml"
            ((System.Windows.Media.Animation.Storyboard)(target)).CurrentStateInvalidated += new System.EventHandler(this.parentTimelineStateInvalidated);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 31 "..\..\StateExample.xaml"
            ((System.Windows.Media.Animation.DoubleAnimation)(target)).CurrentStateInvalidated += new System.EventHandler(this.animation1StateInvalidated);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 37 "..\..\StateExample.xaml"
            ((System.Windows.Media.Animation.DoubleAnimation)(target)).CurrentStateInvalidated += new System.EventHandler(this.animation2StateInvalidated);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
