using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TypeBonus
{
    COIN = 0,
    DAMAGE = 1
}
public class BonusModel : BaseMovementObject
{
    [SerializeField] private TypeBonus bonus;
    protected override void newPosition()
    {
        transform.localPosition = new Vector3(Random.Range(base.rangeX.x, base.rangeX.y), base.beginY, -1);
        initImage();
    }
    protected override void initImage()
    {
        int rnd = Random.Range(0, 2);
        bonus = (TypeBonus)rnd;
        spr = GetComponent<SpriteRenderer>();
        spr.sprite = images[((int)bonus)];
    }
    public int BonusDamage()
    {
        return bonus == TypeBonus.COIN ? 1 : -1;
    }
}
