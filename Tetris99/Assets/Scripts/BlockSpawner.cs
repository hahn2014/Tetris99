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
        int i = queue.queue[0];
        Debug.Log(getBlock(i).name + " has been spawned.");
        Instantiate(getBlock(i), transform.position, Quaternion.identity);
        queue.updateQueue();
    }

    private GameObject getBlock(int i) {
        GameObject prefab = null;
        switch (i) {
            case 1:
                prefab = GameObject.FindGameObjectWithTag("iBlock");
                break;
            case 2:
                prefab = GameObject.FindGameObjectWithTag("jBlock");
                break;
            case 3:
                prefab = GameObject.FindGameObjectWithTag("lBlock");
                break;
            case 4:
                prefab = GameObject.FindGameObjectWithTag("oBlock");
                break;
            case 5:
                prefab = GameObject.FindGameObjectWithTag("sBlock");
                break;
            case 6:
                prefab = GameObject.FindGameObjectWithTag("zBlock");
                break;
            case 7:
                prefab = GameObject.FindGameObjectWithTag("tBlock");
                break;
        }
        return prefab;
    }

    void Update() {
        update += Time.deltaTime;
        if (update > 3.0f) {
            update = 0.0f;
            spawnNext();
        }
    }
}
