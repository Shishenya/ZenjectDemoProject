using UnityEngine;
using Zenject;

public class ClickFigure : MonoBehaviour
{

    [Inject] private IInputService _inputService;
    private InitFigure _initFigure;

    private void Awake()
    {
        _initFigure = GetComponent<InitFigure>();
    }

    private void OnEnable()
    {
        _inputService.OnClickByScreen += CallClickByScreen;
    }

    private void OnDisable()
    {
        _inputService.OnClickByScreen -= CallClickByScreen;
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }

    /// <summary>
    /// реакция на событие
    /// </summary>
    private void CallClickByScreen()
    {
        ChangeColor();
    }

    /// <summary>
    /// Смена цвета
    /// </summary>
    private void ChangeColor()
    {
        _initFigure.ChangeColor();
    }
}
