﻿#pragma checksum "..\..\..\BarangMasuk.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D90849E4EFBA766CD4BE39896409BF674A6AFFA0"
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
    /// BarangMasuk
    /// </summary>
    public partial class BarangMasuk : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\BarangMasuk.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Nama_Barang;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\BarangMasuk.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Tanggal_Masuk;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\BarangMasuk.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button InputBarang;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\BarangMasuk.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Jumlah;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\BarangMasuk.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox KodeMasuk;
        
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
            System.Uri resourceLocater = new System.Uri("/inventory;V1.0.0.0;component/barangmasuk.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\BarangMasuk.xaml"
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
            this.Nama_Barang = ((System.Windows.Controls.TextBox)(target));
            
            #line 10 "..\..\..\BarangMasuk.xaml"
            this.Nama_Barang.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Nama_Barang_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Tanggal_Masuk = ((System.Windows.Controls.TextBox)(target));
            
            #line 11 "..\..\..\BarangMasuk.xaml"
            this.Tanggal_Masuk.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Tanggal_Masuk_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.InputBarang = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\BarangMasuk.xaml"
            this.InputBarang.Click += new System.Windows.RoutedEventHandler(this.OnClickInput);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Jumlah = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\..\BarangMasuk.xaml"
            this.Jumlah.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Jumlah_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.KodeMasuk = ((System.Windows.Controls.TextBox)(target));
            
            #line 14 "..\..\..\BarangMasuk.xaml"
            this.KodeMasuk.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.KodeMasuk_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

