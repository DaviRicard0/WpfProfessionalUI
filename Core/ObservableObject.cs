﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfProfessionalUI.Core;

class ObservableObject : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;
    
    protected void OnProperyChanged([CallerMemberName] string? name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
