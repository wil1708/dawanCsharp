﻿#pragma checksum "..\..\FenQcm.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AFCC3D22D2E597409BD3430351AB792846340458B86ED688AEC19B97B4CFEC8B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
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
using WPFTraining;


namespace WPFTraining {
    
    
    /// <summary>
    /// FenQcm
    /// </summary>
    public partial class FenQcm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\FenQcm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBIntituleQcm;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\FenQcm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBQuestionEnonce;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\FenQcm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel PanelReponse;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\FenQcm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSuivant;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\FenQcm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TBCompteur;
        
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
            System.Uri resourceLocater = new System.Uri("/WPFTraining;component/fenqcm.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FenQcm.xaml"
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
            
            #line 8 "..\..\FenQcm.xaml"
            ((WPFTraining.FenQcm)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TBIntituleQcm = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TBQuestionEnonce = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.PanelReponse = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            this.BtnSuivant = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\FenQcm.xaml"
            this.BtnSuivant.Click += new System.Windows.RoutedEventHandler(this.BtnSuivant_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TBCompteur = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

