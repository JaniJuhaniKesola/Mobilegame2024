using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MobileExample {
/// <summary>
/// This script changes the color of the sprite (the img not the drink)
/// </summary>

public class ColorChanger : MonoBehaviour
    {

    private SpriteRenderer _spriteRenderer;
    [SerializeField]
    private Color[] _colours; 
        // Start is called before the first frame update
        void Start()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
            _spriteRenderer.color = _colours[0];
        }

        // Update is called once per frame
        void Update()
        {
            int index = (int)(Time.time % _colours.Length);
            _spriteRenderer.color = _colours[index];
        }
    }
}