using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashDots : MonoBehaviour
{
    public float flashSpeed;
    private bool isFlash;

    private Image image;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isFlash)
        {
            image.color += new Color(0, 0, 0, Time.deltaTime * flashSpeed);
            if (image.color.a >= 1)
            {
                image.color = new Color(image.color.r, image.color.g, image.color.b, 1);
                isFlash = false;
            }
        }
        else
        {
            image.color -= new Color(0, 0, 0, Time.deltaTime * flashSpeed);
            if(image.color.a <= 0)
            {
                image.color = new Color(image.color.r, image.color.g, image.color.b, 0);
                isFlash = true;
            }
        }
    }
}
