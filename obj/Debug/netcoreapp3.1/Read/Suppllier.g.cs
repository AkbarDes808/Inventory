﻿#pragma checksum "..\..\..\..\Read\Suppllier.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7F2CED2CA5BF13406E05A5AAA9FF7448E61A6207"
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
using inventory.Read;


namespace inventory.Read {
    
    
    /// <summary>
    /// Suppllier
    /// </summary>
    public partial class Suppllier : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\Read\Suppllier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Kode;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\Read\Suppllier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Nama;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Read\Suppllier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Telepon;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\Read\Suppllier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Alamat;
        
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
            System.Uri resourceLocater = new System.Uri("/inventory;component/read/suppllier.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Read\Suppllier.xaml"
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
            this.Kode = ((System.Windows.Controls.TextBox)(target));
            
            #line 14 "..\..\..\..\Read\Suppllier.xaml"
            this.Kode.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Kode_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Nama = ((System.Windows.Controls.TextBox)(target));
            
            #line 15 "..\..\..\..\Read\Suppllier.xaml"
            this.Nama.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Nama_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Telepon = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\..\..\Read\Suppllier.xaml"
            this.Telepon.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Telepon_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Alamat = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\..\..\Read\Suppllier.xaml"
            this.Alamat.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Alamat_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
