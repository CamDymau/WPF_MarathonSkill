﻿#pragma checksum "..\..\..\Info\InfoMenu.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DE28E345F1BE8ADC8854EFEAAC03255772534ABCD6DE55EB8A97019B794B6A70"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MarathonSkills.Info;
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


namespace MarathonSkills.Info {
    
    
    /// <summary>
    /// InfoMenu
    /// </summary>
    public partial class InfoMenu : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\Info\InfoMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_lastresult;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Info\InfoMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_marathon;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Info\InfoMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_statsmarathon;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Info\InfoMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_listfund;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Info\InfoMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_bmicalc;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Info\InfoMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_bmrcalc;
        
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
            System.Uri resourceLocater = new System.Uri("/MarathonSkills;component/info/infomenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Info\InfoMenu.xaml"
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
            this.btn_lastresult = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Info\InfoMenu.xaml"
            this.btn_lastresult.Click += new System.Windows.RoutedEventHandler(this.btn_lastresult_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_marathon = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\Info\InfoMenu.xaml"
            this.btn_marathon.Click += new System.Windows.RoutedEventHandler(this.btn_marathon_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_statsmarathon = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\Info\InfoMenu.xaml"
            this.btn_statsmarathon.Click += new System.Windows.RoutedEventHandler(this.btn_statsmarathon_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_listfund = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\Info\InfoMenu.xaml"
            this.btn_listfund.Click += new System.Windows.RoutedEventHandler(this.btn_listfund_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_bmicalc = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\Info\InfoMenu.xaml"
            this.btn_bmicalc.Click += new System.Windows.RoutedEventHandler(this.btn_bmicalc_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_bmrcalc = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\Info\InfoMenu.xaml"
            this.btn_bmrcalc.Click += new System.Windows.RoutedEventHandler(this.btn_bmrcalc_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
