using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] float speed = 2.0f;
    [SerializeField] int playerType=0;
    public int PlayerType
    {
        get
        {
            return playerType;
        }
    }

    float horizontal = 0f;
    float vertical = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (playerType == 1)
        {
             horizontal = Input.GetAxis("Horizontal");
             vertical = Input.GetAxis("Vertical");
       }

        if (playerType == 2)
        {
             horizontal = Input.GetAxis("Horizontal2");
            vertical = Input.GetAxis("Vertical2");
        }

        transform.position += new Vector3(horizontal, 0, vertical) * Time.deltaTime * speed;
    }

    public void SetPlayerType(int type)
    {
        playerType = type;
    }
}