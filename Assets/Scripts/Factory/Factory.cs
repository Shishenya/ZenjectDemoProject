using UnityEngine;
using Zenject;

public class Factory : MonoBehaviour
{
    [Inject] private DiContainer _diContainer;
    public GameObject fugurePrefab;
    public GameObject Create(SizeFigure size, ColorFigure color)
    {
        GameObject createGO = _diContainer.InstantiatePrefab(fugurePrefab);
        createGO.GetComponent<InitFigure>().InitParameters(size, color);
        return createGO;
    }
}
