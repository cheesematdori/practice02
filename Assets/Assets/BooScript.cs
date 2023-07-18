using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BooScript : MonoBehaviour
{
    public bool BooIsActive = true;
    public Rigidbody2D mRigidBody;
    public LogicManage logic;
    public Transform transform;
    [SerializeField] public float flapStrength;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "Bird";
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManage>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            mRigidBody.velocity = Vector2.up * 6;
        }

        if (transform.position.y < -10) 
        {
            logic.gameOver();
        }

        

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        BooIsActive = false;
    }
    //파이프 터치하면 게임오버인 함수
 

}
