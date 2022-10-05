using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] float speed = 2.0f;
    [SerializeField] int playerType=0;

    private PlayerAxis playerAxis;

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
        horizontal = Input.GetAxis(playerAxis.horizontalAxis);
        vertical = Input.GetAxis(playerAxis.verticalAxis);

        transform.position += new Vector3(horizontal, 0, vertical) * Time.deltaTime * speed;
    }

    public void SetPlayerType(int type, PlayerAxis playerAxis)
    {
        playerType = type;
        this.playerAxis = playerAxis;
    }
}