﻿#pragma checksum "..\..\..\Reserachs.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0B067A26D67F4F2BA1C43C99DAA9FC3C09EB7966"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using RENTnew;
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


namespace RENTnew {
    
    
    /// <summary>
    /// Reserachs
    /// </summary>
    public partial class Reserachs : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 69 "..\..\..\Reserachs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button createResBTN;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Reserachs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Backdown;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\Reserachs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Delete;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\Reserachs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid reserchDT;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\Reserachs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PatientName;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/RENTnew;component/reserachs.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Reserachs.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.createResBTN = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\..\Reserachs.xaml"
            this.createResBTN.Click += new System.Windows.RoutedEventHandler(this.createResBTN_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Backdown = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\..\Reserachs.xaml"
            this.Backdown.Click += new System.Windows.RoutedEventHandler(this.BackBTN_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Delete = ((System.Windows.Controls.Button)(target));
            
            #line 87 "..\..\..\Reserachs.xaml"
            this.Delete.Click += new System.Windows.RoutedEventHandler(this.Delete_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.reserchDT = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.PatientName = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

