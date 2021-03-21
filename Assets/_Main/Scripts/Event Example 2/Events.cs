using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Events : MonoBehaviour
{
    public delegate void ActionClick();

    public static event ActionClick OnClick;
    
    public void Button_Click()
    {
        OnClick?.Invoke();
    }
}
