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
        //Collider2D collider2D = GetComponent<Collider2D>();
        //Debug.Log("collider2d new position = " + collider2D);
        //collider2D.enabled = true;
        transform.localPosition = new Vector3(Random.Range(base.rangeX.x, base.rangeX.y), Random.Range(base.beginY, 11), -1);
        initImage();
    }
    public void RestartPosition(int delay)
    {
        //Collider2D collider2D = GetComponent<Collider2D>();
        //Debug.Log("collider2d restart = " + collider2D);
        //collider2D.enabled = false;
        maybeRun = false;
        newPosition();
        StartCoroutine(WaitCoroutine(delay));
    }
    protected override void initImage()
    {
        maybeRun = true;
        int rnd = Random.Range(0, 2);
        bonus = (TypeBonus)rnd;
        spr = GetComponent<SpriteRenderer>();
        spr.sprite = images[((int)bonus)];    
    }
    public int BonusDamage()
    {
        return bonus == TypeBonus.COIN ? 1 : -1;
    }


    IEnumerator WaitCoroutine(int delay)
    {
        Debug.Log("delay= " + delay);
        yield return new WaitForSeconds(delay);

        // maybeRun = true;
        newPosition();
    }
}
