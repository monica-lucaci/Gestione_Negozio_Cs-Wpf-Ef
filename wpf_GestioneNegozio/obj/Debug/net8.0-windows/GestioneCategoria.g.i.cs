﻿#pragma checksum "..\..\..\GestioneCategoria.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14DAEAEA41DA7B1468C7809F5C5F691531052EBE"
//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
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
using wpf_GestioneNegozio;


namespace wpf_GestioneNegozio {
    
    
    /// <summary>
    /// GestioneCategoria
    /// </summary>
    public partial class GestioneCategoria : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\GestioneCategoria.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbNome;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\GestioneCategoria.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSalva;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\GestioneCategoria.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbId;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\GestioneCategoria.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbNomeCat;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\GestioneCategoria.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAggiorna;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\GestioneCategoria.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbId2;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\GestioneCategoria.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancella;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\GestioneCategoria.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnHome;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\GestioneCategoria.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgCategoria;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/wpf_GestioneNegozio;component/gestionecategoria.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\GestioneCategoria.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.tbNome = ((System.Windows.Controls.TextBox)(target));
            
            #line 15 "..\..\..\GestioneCategoria.xaml"
            this.tbNome.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbNome_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnSalva = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\GestioneCategoria.xaml"
            this.btnSalva.Click += new System.Windows.RoutedEventHandler(this.btnSalva_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tbId = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\..\GestioneCategoria.xaml"
            this.tbId.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbNome_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tbNomeCat = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\..\GestioneCategoria.xaml"
            this.tbNomeCat.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbNome_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnAggiorna = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\GestioneCategoria.xaml"
            this.btnAggiorna.Click += new System.Windows.RoutedEventHandler(this.btnAggiorna_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.tbId2 = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\..\GestioneCategoria.xaml"
            this.tbId2.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbNome_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnCancella = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\GestioneCategoria.xaml"
            this.btnCancella.Click += new System.Windows.RoutedEventHandler(this.btnCancella_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnHome = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\GestioneCategoria.xaml"
            this.btnHome.Click += new System.Windows.RoutedEventHandler(this.btnHome_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.dgCategoria = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
