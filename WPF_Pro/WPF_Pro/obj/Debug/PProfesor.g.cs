﻿#pragma checksum "..\..\PProfesor.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3D581668C40EBEAA94D0A434A6DB6C708E7DC947B0A817ABC2AB6607A9A57E78"
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
using WPF_Pro;


namespace WPF_Pro {
    
    
    /// <summary>
    /// PProfesor
    /// </summary>
    public partial class PProfesor : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 45 "..\..\PProfesor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Prenume;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\PProfesor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Nume;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\PProfesor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Welcome;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\PProfesor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Date_personale;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\PProfesor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem CautaStudent;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\PProfesor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Student;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\PProfesor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Exit;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\PProfesor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Functie;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\PProfesor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Materii;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\PProfesor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Grupele;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\PProfesor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame Profu;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF_Pro;component/pprofesor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PProfesor.xaml"
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
            this.Prenume = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.Nume = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.Welcome = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 4:
            this.Date_personale = ((System.Windows.Controls.MenuItem)(target));
            
            #line 67 "..\..\PProfesor.xaml"
            this.Date_personale.Click += new System.Windows.RoutedEventHandler(this.Date_personale_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CautaStudent = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 6:
            this.Student = ((System.Windows.Controls.MenuItem)(target));
            
            #line 79 "..\..\PProfesor.xaml"
            this.Student.Click += new System.Windows.RoutedEventHandler(this.Student_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Exit = ((System.Windows.Controls.MenuItem)(target));
            
            #line 81 "..\..\PProfesor.xaml"
            this.Exit.Click += new System.Windows.RoutedEventHandler(this.Exit_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Functie = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.Materii = ((System.Windows.Controls.DataGrid)(target));
            
            #line 86 "..\..\PProfesor.xaml"
            this.Materii.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Materii_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Grupele = ((System.Windows.Controls.DataGrid)(target));
            
            #line 101 "..\..\PProfesor.xaml"
            this.Grupele.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Grupele_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Profu = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
