﻿#pragma checksum "..\..\AddEditStaffingPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7C55AA71B738F389D1B671D3ED4FD7BAAC5D9A0E42972C01A19379FFE446B52E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using HumanResourcesDepartmentApp;
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


namespace HumanResourcesDepartmentApp {
    
    
    /// <summary>
    /// AddEditStaffingPage
    /// </summary>
    public partial class AddEditStaffingPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\AddEditStaffingPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBPosition;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\AddEditStaffingPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBNumber_Of_Staff_Units;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\AddEditStaffingPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBSalary;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\AddEditStaffingPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBNight_Shift_Allowance;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\AddEditStaffingPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBPremium;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\AddEditStaffingPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBDistrict_Coefficient;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\AddEditStaffingPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBIn_All;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\AddEditStaffingPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSave;
        
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
            System.Uri resourceLocater = new System.Uri("/HumanResourcesDepartmentApp;component/addeditstaffingpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddEditStaffingPage.xaml"
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
            this.CBPosition = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.TBNumber_Of_Staff_Units = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TBSalary = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TBNight_Shift_Allowance = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TBPremium = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.TBDistrict_Coefficient = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.TBIn_All = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.BtnSave = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\AddEditStaffingPage.xaml"
            this.BtnSave.Click += new System.Windows.RoutedEventHandler(this.BtnSave_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

