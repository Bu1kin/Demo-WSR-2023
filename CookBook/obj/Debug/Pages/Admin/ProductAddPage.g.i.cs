﻿#pragma checksum "..\..\..\..\Pages\Admin\ProductAddPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A90B30DDFA4583C2D5473674807E3A237AA33E949D5F6DFF3D9ACCA936473AB6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using CookBook.Pages.Admin;
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


namespace CookBook.Pages.Admin {
    
    
    /// <summary>
    /// ProductAddPage
    /// </summary>
    public partial class ProductAddPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\Pages\Admin\ProductAddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImageBook;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\Pages\Admin\ProductAddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSaveImage;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\Pages\Admin\ProductAddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbName;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\Pages\Admin\ProductAddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbPrice;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Pages\Admin\ProductAddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbSalePrice;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\Pages\Admin\ProductAddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbDesc;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\Pages\Admin\ProductAddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbMaker;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Pages\Admin\ProductAddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbAmount;
        
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
            System.Uri resourceLocater = new System.Uri("/CookBook;component/pages/admin/productaddpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Admin\ProductAddPage.xaml"
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
            this.ImageBook = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.BtnSaveImage = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\..\Pages\Admin\ProductAddPage.xaml"
            this.BtnSaveImage.Click += new System.Windows.RoutedEventHandler(this.BtnSaveImage_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TbName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TbPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TbSalePrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.TbDesc = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.TbMaker = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 19 "..\..\..\..\Pages\Admin\ProductAddPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.TbAmount = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
