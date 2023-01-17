using System;
using UnityEngine;

public class PCController : MonoBehaviour, IInputService
{
    public event Action OnClickByScreen;
   
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            OnClickByScreen?.Invoke();
        }
    }
}
