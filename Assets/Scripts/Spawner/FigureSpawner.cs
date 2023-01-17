using UnityEngine;
using Zenject;

public class FigureSpawner : MonoBehaviour
{

    private Factory _factory;

    private float _xRandMin = -9f;
    private float _xRandMax = 9f;
    private readonly float _yPoint = 7.5f;

    [SerializeField] private float _delayNewFigureSpawnSecond = 2f;
    private float timerSpawnSecond;

    [Inject]
    private void Construct(Factory factory)
    {
        _factory = factory;
    }

    private void Start()
    {
        timerSpawnSecond = 0f;
    }

    private void Update()
    {
        if (timerSpawnSecond < 0)
        {
            timerSpawnSecond = _delayNewFigureSpawnSecond;
            Spawn();
        }
        else
        {
            timerSpawnSecond -= Time.deltaTime;
        }
    }

    /// <summary>
    /// Спавн фигуры
    /// </summary>
    private void Spawn()
    {
        GameObject figure = _factory.Create((SizeFigure)Random.Range(0, (int)SizeFigure.count),
                                            (ColorFigure)Random.Range(0, (int)ColorFigure.count));
        figure.transform.position = RandomSpawnPoint();
    }

    /// <summary>
    /// Возвращает рандомную позицию для спавна
    /// </summary>
    private Vector3 RandomSpawnPoint()
    {
        return new Vector3(Random.Range(_xRandMin, _xRandMax), _yPoint, 0f);
    }

}
