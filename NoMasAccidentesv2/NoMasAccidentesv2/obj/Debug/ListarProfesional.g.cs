﻿#pragma checksum "..\..\ListarProfesional.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5F2ABE5AACF388614802F00E043077ACE3DB975103F50A8DB6922AB55ADA11C8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using NoMasAccidentesv2;
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


namespace NoMasAccidentesv2 {
    
    
    /// <summary>
    /// ListarProfesional
    /// </summary>
    public partial class ListarProfesional : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\ListarProfesional.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnVentanaPorfesional;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\ListarProfesional.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnVentanaCliente;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\ListarProfesional.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnVentanaContratos;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\ListarProfesional.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnVentanaReportes;
        
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
            System.Uri resourceLocater = new System.Uri("/NoMasAccidentesv2;component/listarprofesional.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ListarProfesional.xaml"
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
            this.btnVentanaPorfesional = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\ListarProfesional.xaml"
            this.btnVentanaPorfesional.Click += new System.Windows.RoutedEventHandler(this.btnVentanaPorfesional_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnVentanaCliente = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\ListarProfesional.xaml"
            this.btnVentanaCliente.Click += new System.Windows.RoutedEventHandler(this.btnVentanaCliente_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnVentanaContratos = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.btnVentanaReportes = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\ListarProfesional.xaml"
            this.btnVentanaReportes.Click += new System.Windows.RoutedEventHandler(this.btnVentanaReportes_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

