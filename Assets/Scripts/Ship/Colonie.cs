using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colonie : MonoBehaviour
{
    public Vector2 endPos = new Vector2(-1, -1);
    [SerializeReference] private float moveSpeed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().enabled = false;
        //endPos.x = -1;
        //endPos.y = -1;
    }

    public void setEndPos(Vector2 pos)
    {
        endPos.x = pos.x;
        endPos.y = pos.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (endPos.x != -1 && endPos.y != -1)
        {
            GetComponent<Renderer>().enabled = true;
            if (transform.position.x < endPos.x)
                GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            if (transform.position.y < endPos.y)
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, moveSpeed);
            if (transform.position.x > endPos.x)
                GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            if (transform.position.y > endPos.y)
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, -moveSpeed);
        }
        if (endPos.x > transform.position.x - moveSpeed && endPos.x < transform.position.x + moveSpeed &&
            endPos.y > transform.position.y - moveSpeed && endPos.y < transform.position.y + moveSpeed)
        {
            if (endPos.x != 0.5f && endPos.y != 0.5f)
                endPos = new Vector2(0.5f, 0.5f);
            else
            {
                GetComponent<Renderer>().enabled = false;
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                //GameObject.Destroy(this.gameObject);
            }
        }
    }
}
