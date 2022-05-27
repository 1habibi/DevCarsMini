using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestCarMovment : MonoBehaviour
{
    private Rigidbody2D rb2D;

    [SerializeField] private float moveSpeed;
    [SerializeField] private float moveHorizontal;
    [SerializeField] private GameObject timerLeft;
    private float moveVertical;

    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector3 m_Input = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        rb2D.MovePosition(transform.position + m_Input * Time.deltaTime * moveSpeed);
    }

    private void FixedUpdate()
    {
        //if(moveHorizontal > 0.1f || moveHorizontal < 0.1f)
        //{
        //    rb2D.AddForce(new Vector2(moveHorizontal * moveSpeed, 0f), ForceMode2D.Impulse);
        //}
        //if (moveVertical > 0.1f || moveHorizontal < 0.1f)
        //{
        //    rb2D.AddForce(new Vector2(0f, moveVertical * moveSpeed), ForceMode2D.Impulse);
        //}
        //if (moveVertical == 0 && moveHorizontal == 0)
        //{
        //    rb2D.AddForce(Vector2.zero, ForceMode2D.Impulse);
        //}


        //Store user input as a movement vector
        //Vector3 m_Input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        //Apply the movement vector to the current position, which is
        //multiplied by deltaTime and speed for a smooth MovePosition
        //m_Rigidbody.MovePosition(transform.position + m_Input * Time.deltaTime * m_Speed);
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject obj = collision.gameObject;
        if (obj.GetComponent<BonusModel>() != null)
        {
            BonusModel bonusModel = obj.GetComponent<BonusModel>(); 
            if(!bonusModel.GivenBonus)
            {
                Debug.Log("Bonus =" + bonusModel.BonusDamage());
                if (bonusModel.BonusDamage() == -1)
                {
                    timerLeft.GetComponent<TimerLeft>().DamageTick();
                }
                bonusModel.RestartPosition(Random.Range(3,5));
                bonusModel.GivenBonus = true;
            }
            else
                bonusModel.GivenBonus = false;
        }
        else if(obj.GetComponent<FinishModel>() != null)
        {
            Debug.Log("FINISH");
            SceneManager.LoadScene(0);
        }

        
        //else if(collision.gameObject.tag != "road 1_0" || obj.GetComponent<BlockModel>() != null)
        //{
        //    if (moveHorizontal > 0.1f || moveHorizontal < 0.1f)
        //    {
        //        rb2D.AddForce(new Vector2(-moveHorizontal * moveSpeed, 0f), ForceMode2D.Impulse);
        //    }
        //    if (moveVertical > 0.1f || moveHorizontal < 0.1f)
        //    {
        //        rb2D.AddForce(new Vector2(0f, -moveVertical * moveSpeed), ForceMode2D.Impulse);
        //    }
        //}
    }
}
