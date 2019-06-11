using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour {

    private float update;
    public GameObject[] groups;

    public void spawnNext() {
        int i = Random.Range(0, groups.Length);
        Debug.Log(groups[i].name + " has been spawned.");
        Instantiate(groups[i], transform.position, Quaternion.identity);
    }

    void Update() {
        update += Time.deltaTime;
        if (update > 1.0f) {
            update = 0.0f;
            spawnNext();
        }
    }
}
