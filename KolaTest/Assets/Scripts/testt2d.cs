using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;


public class testt2d : UnityEngine.MonoBehaviour
{
    public Image img;
    private void Start()
    {
        GenT2DtoSprite();
        
    }

    void GenT2DtoSprite()
    {
            Texture2D t = new Texture2D(100,50);
            for (int w = 0; w < 100; w++)
            {
                for (int h = 0; h < 50; h++)
                {
                    t.SetPixel(w,h,Color.clear);

                }
            }
            t.SetPixel(Random.Range(1,100),Random.Range(1,50),Color.black);
            t.SetPixel(Random.Range(1,100),Random.Range(1,50),Color.blue);
            t.SetPixel(Random.Range(1,100),Random.Range(1,50),Color.green);
            t.SetPixel(Random.Range(1,100),Random.Range(1,50),Color.magenta);
            t.SetPixel(Random.Range(1,100),Random.Range(1,50),Color.red);
            t.SetPixel(Random.Range(1,100),Random.Range(1,50),Color.yellow);
            t.SetPixel(Random.Range(1,100),Random.Range(1,50),Color.grey);
            t.SetPixel(Random.Range(1,100),Random.Range(1,50),Color.gray);
            t.SetPixel(Random.Range(1,100),Random.Range(1,50),Color.gray);
            t.SetPixel(Random.Range(1,100),Random.Range(1,50),Color.gray);
            t.SetPixel(Random.Range(1,100),Random.Range(1,50),Color.gray);
            t.SetPixel(Random.Range(1,100),Random.Range(1,50),Color.gray);
            t.SetPixel(Random.Range(1,100),Random.Range(1,50),Color.gray);
            t.SetPixel(Random.Range(1,100),Random.Range(1,50),Color.gray);
            t.SetPixel(Random.Range(1,100),Random.Range(1,50),Color.gray);
            
            int x = Random.Range(0, 49);
            for (int w = 0; w < 100; w++)
            {
                t.SetPixel(w,x,Color.gray);
            }

            int y = Random.Range(0, 99);
            for (int h = 0; h < 50; h++)
            {
                t.SetPixel(y,h,Color.gray);
            }

            int z = Random.Range(0, 49);

            for (int i = z; i < z+50; i++)
            {
                t.SetPixel(i,x+i,Color.gray);
            }
            
            t.Apply();

            Sprite pic = Sprite.Create(t, new Rect(0, 0, 100, 50), new Vector2(0.5f, 0.5f));
            img.sprite = pic;
    }
}
