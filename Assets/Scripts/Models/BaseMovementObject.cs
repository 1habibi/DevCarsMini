using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseMovementObject : MonoBehaviour
{
    [SerializeField] protected Sprite[] images;
    protected SpriteRenderer spr;
    [SerializeField] private Vector3 increaseValues;
    [SerializeField] protected Vector2 rangeX;
    [SerializeField] protected int beginY;
    [SerializeField] private int end;
    [SerializeField] public bool maybeRun = true;
    void Awake()
    {
        initImage();
    }
    protected abstract void initImage();
    protected abstract void newPosition();
    public void DefaultPosition()
    {
        newPosition();
    }
    void Update()
    {
        if(maybeRun)
        {
            transform.localPosition += increaseValues * Time.deltaTime;
        }
    }
    private void FixedUpdate()
    {
        if (transform.localPosition.y < end)
        {
            newPosition();
        }
    }

}
