using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundObjectManager : BaseMovementObject
{
    protected override void initImage()
    {
        base.spr = GetComponent<SpriteRenderer>();
        base.spr.sprite = ObjectResourceManager.Instance.GetRandomObject();
    }
    protected override void newPosition()
    {
        transform.localPosition = new Vector3(Random.Range(base.rangeX.x,base.rangeX.y), base.beginY, -1);
    }
}
