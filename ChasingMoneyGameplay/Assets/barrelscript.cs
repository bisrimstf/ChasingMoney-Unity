using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrelscript : MonoBehaviour
{
    [SerializeField]
    GameObject oldman_0;

    float fireRate;
    float nextFire;

    // Start is called before the first frame update
    void Start()
    {
        fireRate = 2f;
        nextFire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        CheckIfTimeToFire();
    }

    void levelspawnrate()
    {
        if (ScoreTextScript.coinAmount > 99)
        {
            fireRate = 1f;
            nextFire = Time.time + fireRate;


        }
        
        
    }

    void CheckIfTimeToFire()
    {
        if (Time.time > nextFire)
        {
            Instantiate(oldman_0, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
            levelspawnrate();
        }
    }

   
}
