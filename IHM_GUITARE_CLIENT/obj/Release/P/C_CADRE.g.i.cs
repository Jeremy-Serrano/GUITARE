﻿#pragma checksum "..\..\..\P\C_CADRE.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0004C57E9F00D55A2497FCCC68F0244F4C431B3EE36397CFC8351930117B4D52"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using IHM_GUITARE_CLIENT;
using IHM_GUITARE_CLIENT.C;
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


namespace IHM_GUITARE_CLIENT {
    
    
    /// <summary>
    /// C_CADRE
    /// </summary>
    public partial class C_CADRE : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\P\C_CADRE.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal IHM_GUITARE_CLIENT.C_CADRE Le_Cadre;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\P\C_CADRE.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBox_Bois_Corps;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\P\C_CADRE.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBox_Bois_Manche;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\P\C_CADRE.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBox_Bois_Touche;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\P\C_CADRE.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Bouton_Valider;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\P\C_CADRE.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Label_ID_Guitare;
        
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
            System.Uri resourceLocater = new System.Uri("/IHM_GUITARE_CLIENT;component/p/c_cadre.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\P\C_CADRE.xaml"
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
            this.Le_Cadre = ((IHM_GUITARE_CLIENT.C_CADRE)(target));
            return;
            case 2:
            this.ComboBox_Bois_Corps = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.ComboBox_Bois_Manche = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.ComboBox_Bois_Touche = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.Bouton_Valider = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\P\C_CADRE.xaml"
            this.Bouton_Valider.Click += new System.Windows.RoutedEventHandler(this.Bouton_Valider_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Label_ID_Guitare = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

