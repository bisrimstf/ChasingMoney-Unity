using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class coinscript : MonoBehaviour
{
    [SerializeField]
    public GameObject coin;

    private void SpawnCoin()
    {
        bool coinSpawned = false;
        while(!coinSpawned)
        {
            Vector3 coinPosition = new Vector3(Random.Range(-7f, 7f), Random.Range(-4f, 4f), 0f);
            if ((coinPosition - transform.position).magnitude<3)
            {
                continue;
            }
            else
            {
                Instantiate(coin, coinPosition, Quaternion.identity);
                coinSpawned = true;
            }
        }
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<PlayerMovement>())
        {
            ScoreTextScript.coinAmount += 1;
            SoundManagerScript.PlaySound("CoinSounds");
            SpawnCoin();
            Destroy(gameObject);
        }
        else
        { 
        
        }
    }   
}
