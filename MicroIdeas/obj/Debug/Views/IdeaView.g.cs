﻿

#pragma checksum "c:\users\minh\documents\visual studio 2012\Projects\MicroIdeas\MicroIdeas\Views\IdeaView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F7DA4DE4BDCF85B223438E7C8CE3DE93"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MicroIdeas
{
    partial class IdeaView : global::MicroIdeas.Common.LayoutAwarePage, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 49 "..\..\Views\IdeaView.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.BtnVoteUp_OnClick;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 50 "..\..\Views\IdeaView.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.BtnVoteDown_OnClick;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 87 "..\..\Views\IdeaView.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Refresh_OnClick;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 88 "..\..\Views\IdeaView.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Help_OnClick;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 82 "..\..\Views\IdeaView.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Prev_OnClick;
                 #line default
                 #line hidden
                break;
            case 6:
                #line 84 "..\..\Views\IdeaView.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Next_OnClick;
                 #line default
                 #line hidden
                break;
            case 7:
                #line 77 "..\..\Views\IdeaView.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Home_OnClick;
                 #line default
                 #line hidden
                break;
            case 8:
                #line 78 "..\..\Views\IdeaView.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Sort_OnClick;
                 #line default
                 #line hidden
                break;
            case 9:
                #line 79 "..\..\Views\IdeaView.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Add_OnClick;
                 #line default
                 #line hidden
                break;
            case 10:
                #line 144 "..\..\Views\IdeaView.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.GoBack;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


