using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour {

    public BlockQueue queue;
    private float update;

    void Start() {
        if (queue == null)
            queue = GameObject.Find("BlockQueue").GetComponent<BlockQueue>();
        queue.generateQueue();
    }

    public void spawnNext() {
        //GameObject i = queue.blocks[0];
        //Debug.Log(i.name + " has been spawned.");
    //    Instantiate(i, transform.position, Quaternion.identity);
        queue.updateQueue();
    }

    void Update() {
        update += Time.deltaTime;
        if (update > 1.0f) {
            update = 0.0f;
            spawnNext();
        }
    }
}
