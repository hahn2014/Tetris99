using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockQueue : MonoBehaviour {
    public int[] queue;
    public Vector2[] blockPositions;
    public GameObject[] blocks;

    public void updateQueue() {
        for (int i = 0; i < 5; i++) {
            if (blocks[i] != null)
                Destroy(blocks[i]); //make sure to delete the old tetrimino prefab object when replacing
        }
        rotateQueue();  //get rid of first in queue, and move all down one. Generate new 6th block.
    }

    private void rotateQueue() {
        setQueue(0, queue[1]);
        setQueue(1, queue[2]);
        setQueue(2, queue[3]);
        setQueue(3, queue[4]);
        setQueue(4, queue[5]);
        setQueue(5, queue[6]);
        setQueue(6, Random.Range(1, 7));  //generate new random tetrimino for the last block in the queue
    }

    public void generateQueue() {
        for (int i = 0; i < 5; i++) {
            setQueue(i, Random.Range(1, 7));
        }
    }

    private void setQueue(int index, int type) {
        queue[index] = type;
        switch (type) {
            case 1:
                blocks[index] = Instantiate(Resources.Load<GameObject>("IBlockPrefab")) as GameObject;
                break;
            case 2:
                blocks[index] = Instantiate(Resources.Load<GameObject>("JBlockPrefab")) as GameObject;
                break;
            case 3:
                blocks[index] = Instantiate(Resources.Load<GameObject>("LBlockPrefab")) as GameObject;
                break;
            case 4:
                blocks[index] = Instantiate(Resources.Load<GameObject>("OBlockPrefab")) as GameObject;
                break;
            case 5:
                blocks[index] = Instantiate(Resources.Load<GameObject>("SBlockPrefab")) as GameObject;
                break;
            case 6:
                blocks[index] = Instantiate(Resources.Load<GameObject>("ZBlockPrefab")) as GameObject;
                break;
            case 7:
                blocks[index] = Instantiate(Resources.Load<GameObject>("TBlockPrefab")) as GameObject;
                break;
            default:
                blocks[index] = Instantiate(Resources.Load<GameObject>("IBlockPrefab")) as GameObject;
                break;
        }
        blocks[index].transform.position = blockPositions[index];
    }
}
