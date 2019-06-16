using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour{
    public int fallSpeed = 1;
    public int fallHeight = 0;

    void Update() {
        if (fallHeight < 30) {
            transform.position += new Vector3(0.0f, 1.0f, 0.0f);
        }
    }

    public void tick() {
        
    }
}
