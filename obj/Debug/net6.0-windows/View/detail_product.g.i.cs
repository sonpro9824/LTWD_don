﻿#pragma checksum "..\..\..\..\View\detail_product.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19F74A984D30F6EB436A15506D99A795D3DC6513"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.MahApps;
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
using WPF_Market.ViewModel;


namespace WPF_Market.View {
    
    
    /// <summary>
    /// detail_product
    /// </summary>
    public partial class detail_product : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\..\..\View\detail_product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image DefaultImage;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\View\detail_product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl ListImage;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\..\View\detail_product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbl_review;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\..\View\detail_product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Tong_quan;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\..\..\View\detail_product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txlb_addShop;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\..\..\View\detail_product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock BOUGTHTIME;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\..\..\View\detail_product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock LBL_NEWNESS;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\..\..\View\detail_product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txbl_origin_price;
        
        #line default
        #line hidden
        
        
        #line 162 "..\..\..\..\View\detail_product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txbl_cur_price;
        
        #line default
        #line hidden
        
        
        #line 169 "..\..\..\..\View\detail_product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txbl_discount;
        
        #line default
        #line hidden
        
        
        #line 221 "..\..\..\..\View\detail_product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_number;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPF_Market;component/view/detail_product.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\detail_product.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 18 "..\..\..\..\View\detail_product.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            
            #line 18 "..\..\..\..\View\detail_product.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.Window_MouseMove);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DefaultImage = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.ListImage = ((System.Windows.Controls.ItemsControl)(target));
            return;
            case 4:
            this.tbl_review = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.Tong_quan = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.txlb_addShop = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.BOUGTHTIME = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.LBL_NEWNESS = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.txbl_origin_price = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.txbl_cur_price = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.txbl_discount = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            this.txt_number = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

