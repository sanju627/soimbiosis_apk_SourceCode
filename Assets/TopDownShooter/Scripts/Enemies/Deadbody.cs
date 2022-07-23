using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deadbody : MonoBehaviour
{
    Zombie zombie;
    bool applied;

    // Start is called before the first frame update
    void Start()
    {
        zombie = GetComponent<Zombie>();
    }

    // Update is called once per frame
    void Update()
    {
        if (applied) return;

        if(zombie.dead)
        {
            Destroy(gameObject, 5f);
            applied = true;
        }
    }
}
