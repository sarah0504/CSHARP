﻿#pragma checksum "..\..\..\Views\DeliveryMenUserControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E4F088C97E01964EA316B8C9106BEE35DC40C8898A79C880C7FA8D28232B7AB7"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
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
using WpfApplication3;
using WpfApplication3.ViewModel2;
using WpfApplication3.Views;


namespace WpfApplication3.ViewModel2 {
    
    
    /// <summary>
    /// DeliveryMenUserControl
    /// </summary>
    public partial class DeliveryMenUserControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Views\DeliveryMenUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl page;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Views\DeliveryMenUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listView;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Views\DeliveryMenUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addDMButton;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Views\DeliveryMenUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button updateDMButton;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Views\DeliveryMenUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button removeDMButton;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Views\DeliveryMenUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button pdfDMButton;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApplication3;component/views/deliverymenusercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\DeliveryMenUserControl.xaml"
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
            this.page = ((System.Windows.Controls.ContentControl)(target));
            return;
            case 2:
            this.listView = ((System.Windows.Controls.ListView)(target));
            return;
            case 3:
            this.addDMButton = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.updateDMButton = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.removeDMButton = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.pdfDMButton = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
