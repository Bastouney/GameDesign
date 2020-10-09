using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class dispPlaneteState : MonoBehaviour
{
    public Spaceship spacesh;
    public Spaceship miner;
    public Spaceship colonie;
    public Spaceship clone;
    void Start()
    {
    }

    private void OnMouseDown()
    {
        clone = (Spaceship)Instantiate(colonie, new Vector3(0.5f, 0.5f, 2), transform.rotation);
        clone.setEndPos(new Vector2(transform.position.x, transform.position.y));
        clone.endPos.x = transform.position.x;
        clone.endPos.y = transform.position.y;}
}
