using UnityEngine;

public class InitFigure : MonoBehaviour
{

    private SpriteRenderer _spriteRenderer;
    private Transform _transform;

    private void Awake()
    {
        _transform = GetComponent<Transform>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    /// <summary>
    /// ������������� ������
    /// </summary>
    public void InitParameters(SizeFigure size, ColorFigure color)
    {

        // ������ ������
        SetSize(size);

        // ������ ����
        SetColor(color);

    }

    /// <summary>
    /// ��������� �����
    /// </summary>
    private void SetSize(SizeFigure size)
    {
        switch (size)
        {
            case SizeFigure.small:
                _transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                break;
            case SizeFigure.medium:
                _transform.localScale = new Vector3(1f, 1f, 1f);
                break;
            case SizeFigure.large:
                _transform.localScale = new Vector3(2f, 2f, 2f);
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// ��������� �����
    /// </summary>
    private void SetColor(ColorFigure color)
    {
        switch (color)
        {
            case ColorFigure.red:
                _spriteRenderer.color = Color.red;
                break;
            case ColorFigure.green:
                _spriteRenderer.color = Color.green;
                break;
            case ColorFigure.blue:
                _spriteRenderer.color = Color.blue;
                break;
            case ColorFigure.yellow:
                _spriteRenderer.color = Color.yellow;
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// ����� �����
    /// </summary>
    public void ChangeColor()
    {
        int randomIndex = Random.Range(0, (int)ColorFigure.count);
        SetColor((ColorFigure)randomIndex);        
    }

}
