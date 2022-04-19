using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeFish : MonoBehaviour
{

    [SerializeField]
    private Sprite[] _fishes;
    [SerializeField]
    private Sprite[] _planets;

    [SerializeField]
    private SpriteRenderer _fish;
    [SerializeField]
    private SpriteRenderer _planet;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GetFishes());

    }

    IEnumerator GetFishes()
    {
        for (int i = 0; i < _planets.Length; i++)
        {
            _planet.sprite = _planets[i];
            for (int j = 0; j < _fishes.Length; j++)
            {
                _fish.sprite = _fishes[j];
                yield return null;

            }
            
        }

    }
    // Update is called once per frame
    void  Update()
    {
        
    }
}
