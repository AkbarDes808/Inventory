﻿#pragma checksum "..\..\..\..\Crate\Supplier.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E777D8C7EF254237473CE66EDDA89D8FAF328B7E"
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
using inventory;


namespace inventory {
    
    
    /// <summary>
    /// Supplier
    /// </summary>
    public partial class Supplier : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\Crate\Supplier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox KodeSupplier;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\Crate\Supplier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NamaSupplier;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Crate\Supplier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NoTelepon;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Crate\Supplier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Alamat;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Crate\Supplier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Input;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/inventory;component/crate/supplier.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Crate\Supplier.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.KodeSupplier = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\..\..\Crate\Supplier.xaml"
            this.KodeSupplier.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.KodeSupplier_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.NamaSupplier = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\..\..\Crate\Supplier.xaml"
            this.NamaSupplier.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.NamaSupplier_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.NoTelepon = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\..\..\Crate\Supplier.xaml"
            this.NoTelepon.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.NoTelepon_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Alamat = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\..\..\Crate\Supplier.xaml"
            this.Alamat.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Alamat_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Input = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\..\Crate\Supplier.xaml"
            this.Input.Click += new System.Windows.RoutedEventHandler(this.OnClickInput);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
