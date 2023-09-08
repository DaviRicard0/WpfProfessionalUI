using WpfProfessionalUI.Core;

namespace WpfProfessionalUI.MVVM.ViewModel;

class MainViewModel : ObservableObject
{
    public RelayCommand HomeViewCommand { get; set; }
    public RelayCommand DiscoveryViewCommand { get; set; }

    public HomeViewModel HomeViewModel { get; set; }
    public DiscoveryViewModel DiscoveryViewModel { get; set; }

    private object _currentView;

	public object CurrentView
	{
		get { return _currentView; }
		set { 
			_currentView = value;
			OnProperyChanged();
		}
	}


	public MainViewModel()
    {
        HomeViewModel = new HomeViewModel();
        DiscoveryViewModel = new DiscoveryViewModel();
		CurrentView = HomeViewModel;

		HomeViewCommand = new RelayCommand(o => 
		{
			CurrentView = HomeViewModel;
		});
		
		DiscoveryViewCommand = new RelayCommand(o => 
		{
			CurrentView = DiscoveryViewModel;
		});
    }
}
