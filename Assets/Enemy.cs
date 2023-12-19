using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    int hp = 1;
    // Start is called before the first frame update
  public void TakeDamge()
    {
        hp -= 1;
        if (hp == 0)
        {
            Destroy(gameObject);
        }
    }

}
