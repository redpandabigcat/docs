﻿#pragma checksum "..\..\Window1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C3DC21098C9D982CD01C98340DFE0ABAE88C0F775B821DE200757E881C5F2BB4"
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


namespace TreeViewSnips {
    
    
    /// <summary>
    /// Window1
    /// </summary>
    public partial class Window1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView myTreeView;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView myTreeViewEvent;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeViewItem Employee1Data;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeViewItem EmployeeWorkDays;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeViewItem Employee2Data;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeViewItem emp2WorkDays;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView EmployeeDataTree;
        
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
            System.Uri resourceLocater = new System.Uri("/TreeViewSnips;component/window1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Window1.xaml"
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
            
            #line 5 "..\..\Window1.xaml"
            ((TreeViewSnips.Window1)(target)).Loaded += new System.Windows.RoutedEventHandler(this.InitializeTreeView);
            
            #line default
            #line hidden
            return;
            case 2:
            this.myTreeView = ((System.Windows.Controls.TreeView)(target));
            return;
            case 3:
            
            #line 46 "..\..\Window1.xaml"
            ((System.Windows.Controls.TreeView)(target)).SelectedItemChanged += new System.Windows.RoutedPropertyChangedEventHandler<object>(this.SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.myTreeViewEvent = ((System.Windows.Controls.TreeView)(target));
            return;
            case 5:
            this.Employee1Data = ((System.Windows.Controls.TreeViewItem)(target));
            
            #line 91 "..\..\Window1.xaml"
            this.Employee1Data.Collapsed += new System.Windows.RoutedEventHandler(this.OnCollapsed);
            
            #line default
            #line hidden
            
            #line 92 "..\..\Window1.xaml"
            this.Employee1Data.Expanded += new System.Windows.RoutedEventHandler(this.OnExpanded);
            
            #line default
            #line hidden
            return;
            case 6:
            this.EmployeeWorkDays = ((System.Windows.Controls.TreeViewItem)(target));
            return;
            case 7:
            this.Employee2Data = ((System.Windows.Controls.TreeViewItem)(target));
            return;
            case 8:
            this.emp2WorkDays = ((System.Windows.Controls.TreeViewItem)(target));
            
            #line 107 "..\..\Window1.xaml"
            this.emp2WorkDays.Selected += new System.Windows.RoutedEventHandler(this.GetSchedule);
            
            #line default
            #line hidden
            
            #line 108 "..\..\Window1.xaml"
            this.emp2WorkDays.Unselected += new System.Windows.RoutedEventHandler(this.SetSchedule);
            
            #line default
            #line hidden
            return;
            case 9:
            this.EmployeeDataTree = ((System.Windows.Controls.TreeView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

