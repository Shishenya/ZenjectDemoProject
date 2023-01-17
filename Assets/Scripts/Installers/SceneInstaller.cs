using UnityEngine;
using Zenject;

public class SceneInstaller : MonoInstaller
{

    public GameObject factoryPrefab;
    public GameObject spawnerPrefab;

    public override void InstallBindings()
    {
        BindFactory();
        BindSpawner();
    }

    /// <summary>
    /// Фабрика
    /// </summary>
    private void BindFactory()
    {
        Factory myFactory = Container.InstantiatePrefabForComponent<Factory>(factoryPrefab);

        Container
            .Bind<Factory>()
            .FromInstance(myFactory)
            .AsSingle();
    }

    /// <summary>
    /// Спавнер
    /// </summary>
    private void BindSpawner()
    {
        FigureSpawner mySpawner = Container.InstantiatePrefabForComponent<FigureSpawner>(spawnerPrefab);

        Container
            .Bind<FigureSpawner>()
            .FromInstance(mySpawner)
            .AsSingle();
    }    

}
