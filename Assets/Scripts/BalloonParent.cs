using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonParent : MonoBehaviour
{


    public int time;
    private float baseSpeed = .1f;
    public float speed;
    private int curtime;

    private bool BalExist = true;

    // Start is called before the first frame update
    void Start()
    {
      curtime = time;
      speed = speed * baseSpeed;
    }

    // Update is called once per frame
    void Update()
    {
      if(BalExist)
      {
          Patrol();
      }

    }

    void Patrol()
    {
      if(curtime != 0)
      {
        transform.Translate(new Vector3(speed, 0, 0));
      }
      if (curtime > 0)
      {
        curtime -= 1;
      }
      else
      {
        curtime = time * 2;
        speed = -1 * speed;
      }


      BalExist = BalloonCheck();
    }

    bool BalloonCheck()
    {
      if(this.transform.childCount == 1)
      {
        return false;
      }
      else
      {
        return true;
      }
    }
}
