﻿#pragma checksum "..\..\SozdanieSotrudnika.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D6E578DAA2912B98611FE4E88F9FDA99B894D320"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using NotarialOffice;
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


namespace NotarialOffice {
    
    
    /// <summary>
    /// SozdanieSotrudnika
    /// </summary>
    public partial class SozdanieSotrudnika : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\SozdanieSotrudnika.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal NotarialOffice.SozdanieSotrudnika dobavitAgentaWindow;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\SozdanieSotrudnika.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox fioBox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\SozdanieSotrudnika.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox positionCombo;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\SozdanieSotrudnika.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox educationBox;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\SozdanieSotrudnika.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox numBox;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\SozdanieSotrudnika.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox serBox;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\SozdanieSotrudnika.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button saveBtn;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\SozdanieSotrudnika.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/NotarialOffice;component/sozdaniesotrudnika.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SozdanieSotrudnika.xaml"
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
            this.dobavitAgentaWindow = ((NotarialOffice.SozdanieSotrudnika)(target));
            return;
            case 2:
            this.fioBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.positionCombo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.educationBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.numBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 23 "..\..\SozdanieSotrudnika.xaml"
            this.numBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.numBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 6:
            this.serBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 25 "..\..\SozdanieSotrudnika.xaml"
            this.serBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.serBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 7:
            this.saveBtn = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\SozdanieSotrudnika.xaml"
            this.saveBtn.Click += new System.Windows.RoutedEventHandler(this.saveBtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.cancelBtn = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\SozdanieSotrudnika.xaml"
            this.cancelBtn.Click += new System.Windows.RoutedEventHandler(this.cancelBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

