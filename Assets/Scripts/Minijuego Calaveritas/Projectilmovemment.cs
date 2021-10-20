using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectilmovemment : MonoBehaviour
{
    // Start is called before the first frame update


    public float throwForce;
    public Vector3 launchSetOff;


    void Start()
    {
        var direction = transform.right + Vector3.up;
        GetComponent<Rigidbody2D>().AddForce(direction * throwForce, ForceMode2D.Impulse);
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * throwForce * Time.deltaTime;

    }


    public void spawnMexicanSweets()
    {

        


    }
}
