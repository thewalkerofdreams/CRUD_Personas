﻿#pragma checksum "C:\Users\Joker\Desktop\18-CRUD_Personas_UWP\18-CRUD_Personas_UWP_UI\Views\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E9715AD035782E6E8831A95BCBD9060A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _18_CRUD_Personas_UWP_UI
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class MainPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::_18_CRUD_Personas_UWP_UI.MainPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Image obj5;

            // Fields for each event bindings event handler.
            private global::Windows.UI.Xaml.Input.TappedEventHandler obj5Tapped;

            public MainPage_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 5: // Views\MainPage.xaml line 59
                        this.obj5 = (global::Windows.UI.Xaml.Controls.Image)target;
                        this.obj5Tapped = (global::System.Object p0, global::Windows.UI.Xaml.Input.TappedRoutedEventArgs p1) =>
                        {
                            this.dataRoot.viewModel.PersonPicture01_Tapped(p0, p1);
                        };
                        ((global::Windows.UI.Xaml.Controls.Image)target).Tapped += obj5Tapped;
                        break;
                    default:
                        break;
                }
            }

            // IMainPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::_18_CRUD_Personas_UWP_UI.MainPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::_18_CRUD_Personas_UWP_UI.MainPage obj, int phase)
            {
                if (obj != null)
                {
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\MainPage.xaml line 23
                {
                    this.StackPanel01 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 3: // Views\MainPage.xaml line 33
                {
                    this.StackPanel02 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 4: // Views\MainPage.xaml line 41
                {
                    this.ListView01 = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.ListView01).RightTapped += this.ListView01_RightTapped;
                }
                break;
            case 5: // Views\MainPage.xaml line 59
                {
                    this.PersonPicture01 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 6: // Views\MainPage.xaml line 62
                {
                    this.grid01 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 7: // Views\MainPage.xaml line 77
                {
                    this.txtBlockNombre = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8: // Views\MainPage.xaml line 78
                {
                    this.txtErrorNombre = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9: // Views\MainPage.xaml line 79
                {
                    this.txtBlockApellidos = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10: // Views\MainPage.xaml line 80
                {
                    this.txtErrorApellidos = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11: // Views\MainPage.xaml line 81
                {
                    this.txtBlockFechaNacimiento = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12: // Views\MainPage.xaml line 82
                {
                    this.txtErrorFechaNacimiento = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13: // Views\MainPage.xaml line 83
                {
                    this.txtBlockTelefono = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14: // Views\MainPage.xaml line 84
                {
                    this.txtErrorTelefono = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15: // Views\MainPage.xaml line 85
                {
                    this.txtBlockDepartamento = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16: // Views\MainPage.xaml line 87
                {
                    this.txtCreacionPersona = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 17: // Views\MainPage.xaml line 89
                {
                    this.txtBoxNombre = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 18: // Views\MainPage.xaml line 90
                {
                    this.txtBoxApellidos = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 19: // Views\MainPage.xaml line 91
                {
                    this.txtBoxFechaNacimiento = (global::Windows.UI.Xaml.Controls.DatePicker)(target);
                }
                break;
            case 20: // Views\MainPage.xaml line 92
                {
                    this.txtBoxTelefono = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 23: // Views\MainPage.xaml line 52
                {
                    this.Actions_Persona_Flyout = (global::Windows.UI.Xaml.Controls.MenuFlyout)(target);
                }
                break;
            case 24: // Views\MainPage.xaml line 34
                {
                    this.btnAddPerson = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 25: // Views\MainPage.xaml line 35
                {
                    this.btnSavePerson = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 26: // Views\MainPage.xaml line 36
                {
                    this.btnDeletePerson = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 27: // Views\MainPage.xaml line 37
                {
                    this.btnRefreshList = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 28: // Views\MainPage.xaml line 38
                {
                    this.txtSearch = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 29: // Views\MainPage.xaml line 39
                {
                    this.btnSearch = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 30: // Views\MainPage.xaml line 24
                {
                    if (MainPage.IsApiContractPresent_Windows_Foundation_UniversalApiContract_7)
                    {
                        this.Archivo01 = (global::Windows.UI.Xaml.Controls.MenuBar)(target);
                    }
                }
                break;
            case 31: // Views\MainPage.xaml line 26
                {
                    this.btnAddPersona = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Views\MainPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    MainPage_obj1_Bindings bindings = new MainPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }

        // Api Information for conditional namespace declarations
        internal static bool IsApiContractPresent_Windows_Foundation_UniversalApiContract_7 = global::Windows.Foundation.Metadata.ApiInformation.IsApiContractPresent("Windows.Foundation.UniversalApiContract", 7);
    }
}

