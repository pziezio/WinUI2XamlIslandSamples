#include "pch.h"
#include "MyUserControl.h"
#if __has_include("MyUserControl.g.cpp")
#include "MyUserControl.g.cpp"
#endif

using namespace winrt;
using namespace Windows::UI::Xaml;

namespace winrt::MyUWPApp::implementation
{
    MyUserControl::MyUserControl()
    {
        InitializeComponent();
    }

    void MyUserControl::ClickHandler(IInspectable const&, RoutedEventArgs const&)
    {
        Button().Content(box_value(L"Clicked"));
    }
}
