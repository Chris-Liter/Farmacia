﻿#pragma checksum "..\..\..\..\Views\VentasView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B477D5A98AF4480E0B5BD72CA9798B45578A85A3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Farmacia.ViewModel;
using Farmacia.Views;
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


namespace Farmacia.Views {
    
    
    /// <summary>
    /// VentasView
    /// </summary>
    public partial class VentasView : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 175 "..\..\..\..\Views\VentasView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Cedula;
        
        #line default
        #line hidden
        
        
        #line 187 "..\..\..\..\Views\VentasView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Nombre;
        
        #line default
        #line hidden
        
        
        #line 199 "..\..\..\..\Views\VentasView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Apellido;
        
        #line default
        #line hidden
        
        
        #line 214 "..\..\..\..\Views\VentasView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Telefono;
        
        #line default
        #line hidden
        
        
        #line 227 "..\..\..\..\Views\VentasView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Direccion;
        
        #line default
        #line hidden
        
        
        #line 238 "..\..\..\..\Views\VentasView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Correo;
        
        #line default
        #line hidden
        
        
        #line 260 "..\..\..\..\Views\VentasView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox lbl_busqueda;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Farmacia;component/views/ventasview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\VentasView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Cedula = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Nombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Apellido = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Telefono = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Direccion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Correo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            
            #line 250 "..\..\..\..\Views\VentasView.xaml"
            ((System.Windows.Controls.DatePicker)(target)).SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.DatePicker_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lbl_busqueda = ((System.Windows.Controls.TextBox)(target));
            
            #line 262 "..\..\..\..\Views\VentasView.xaml"
            this.lbl_busqueda.KeyDown += new System.Windows.Input.KeyEventHandler(this.TextBox_KeyDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

