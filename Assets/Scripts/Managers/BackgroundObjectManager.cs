using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BackgroundObjectManager : MonoBehaviour
{
    [SerializeField] private Sprite[] images;
    private SpriteRenderer spr;
    [SerializeField] private Vector3 increaseValues;
    [SerializeField] private Vector2 rangeX;
    [SerializeField] private int beginY;
    [SerializeField] private int end;

    private void Awake()
    {
        spr = GetComponent<SpriteRenderer>();
        spr.sprite = images[Random.Range(0,images.Length)];    
    }

    private void newPosition()
    {
        transform.localPosition = new Vector3(Random.Range(rangeX.x,rangeX.y), beginY, -1);
    }

    void Update()
    {
       transform.localPosition += increaseValues * Time.deltaTime;
       if(transform.localPosition.y < end)
       {
            newPosition();
       }
    }
}
