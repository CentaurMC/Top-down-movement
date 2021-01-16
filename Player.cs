using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int MovementSpeed;
    public Rigidbody2D rb2d;

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxisRaw("Horizontal")* MovementSpeed * Time.deltaTime;
        float ver = Input.GetAxisRaw("Vertical") * MovementSpeed * Time.deltaTime;
        rb2d.velocity = new Vector3(hor, ver);
    }
}
