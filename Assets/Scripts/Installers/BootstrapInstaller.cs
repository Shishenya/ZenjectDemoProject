using Zenject;

public class BootstrapInstaller : MonoInstaller
{

    public PCController pcControllerPrefab; // ����������

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
