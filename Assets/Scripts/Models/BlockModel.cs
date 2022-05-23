using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockModel : BaseMovementObject
{
    protected override void newPosition()
    {
        transform.localPosition = new Vector3(Random.Range(base.rangeX.x, base.rangeX.y), base.beginY, -1);
    }
    protected override void initImage()
    {
        spr = GetComponent<SpriteRenderer>();
        spr.sprite = images[0];
    }
}
