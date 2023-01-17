using Zenject;

public class BootstrapInstaller : MonoInstaller
{

    public PCController pcControllerPrefab; // Контроллер

    public override void InstallBindings()
    {
        BindController();
    }

    private void BindController()
    {
        Container
            .Bind<IInputService>()
            .To<PCController>()
            .FromComponentInNewPrefab(pcControllerPrefab)
            .AsSingle()
            .NonLazy();
    }
}
