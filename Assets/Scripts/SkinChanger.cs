using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]

public class SkinChanger : MonoBehaviour
{
    private Image _image;

    private void Awake()
    {
        _image = GetComponent<Image>();
    }
    
    public void SwitchColor()
    {
        _image.color = _image.color == Color.white ? Color.red : Color.white;
    }
}
