using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ColorGenerator : MonoBehaviour
{
    [SerializeField]
    private int _colorCount = 9;

    private Color[] _colors ;
    
    [SerializeField]
    private SpriteRenderer _text;
    [SerializeField]
    private SpriteRenderer _backgound;

    void Start()
    {
        _colors = new Color[_colorCount];
        for (int i = 0; i < _colorCount; i++)
        {
            var r = new Color( 
                Random.Range(0, 1f),
                Random.Range(0, 1f),
                Random.Range(0, 1f),1f);
            _colors[i] = Color.Lerp(Color.white, r, 0.999f);
            //_colors[i] = new Color(1,0,0,1);
        }
        StartCoroutine(GetColors());

    }

    IEnumerator GetColors()
    {
                yield return null;
        for (int i = 0; i < _colorCount; i++)
        {
            _backgound.color = GetColorFromIndex(i);
            for (int j = 0; j < _colorCount; j++)
            {
                _text.color = GetColorFromIndex(j);
                yield return null;

            }
            
        }

    }

    private Color GetColorFromIndex(int p0)
    {
        return _colors[p0];

        float step = 1f / (_colorCount*.3f);
        for (int i = 0; i <_colorCount ; i++)
        {
            
        }

    }
}
