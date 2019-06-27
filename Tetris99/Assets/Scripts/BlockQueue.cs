using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockQueue : MonoBehaviour {
    public int[] queue;
    public Object[] sprites;

    private SpriteRenderer sr;
    private Sprite IBlock;
    private Sprite JBlock;
    private Sprite LBlock;
    private Sprite SBlock;
    private Sprite ZBlock;
    private Sprite OBlock;
    private Sprite TBlock;

    void Awake() {
        IBlock = Resources.Load<Sprite>("IBlockSprite");
        JBlock = Resources.Load<Sprite>("JBlockSprite");
        LBlock = Resources.Load<Sprite>("LBlockSprite");
        SBlock = Resources.Load<Sprite>("SBlockSprite");
        ZBlock = Resources.Load<Sprite>("ZBlockSprite");
        OBlock = Resources.Load<Sprite>("OBlockSprite");
        TBlock = Resources.Load<Sprite>("TBlockSprite");
        Debug.Log("Sprites loaded");
    }

    public void updateQueue() {
        rotateQueue();  //get rid of first in queue, and move all down one. Generate new 6th block.
    }

    private void rotateQueue() {
        Debug.Log("Rotating Queue:");
        setQueue(0, queue[1]);
        setQueue(1, queue[2]);
        setQueue(2, queue[3]);
        setQueue(3, queue[4]);
        setQueue(4, queue[5]);
        setQueue(5, Random.Range(1, 7));  //generate new random tetrimino for the last block in the queue
    }

    public void generateQueue() {
        Debug.Log("Generating Queue:");
        for (int i = 0; i < 6; i++) {
            setQueue(i, Random.Range(1, 7));
        }
    }

    private void setQueue(int index, int type) {
        queue[index] = type;
        Debug.Log("queue[" + index + "] = " + queue[index]);
        /*GameObject spriteObj;
        switch (type) {
            case 1:
                spriteObj = sprites[index];
                sr = spriteObj.GetComponentInChildren<SpriteRenderer>();
                sr.sprite = IBlock;
                break;
            case 2:
                sr = (sprites[index] as GameObject).GetComponentInChildren<SpriteRenderer>();
                sr.sprite = JBlock;
                break;
            case 3:
                sr = (sprites[index] as GameObject).GetComponentInChildren<SpriteRenderer>();
                sr.sprite = LBlock;
                break;
            case 4:
                sr = (sprites[index] as GameObject).GetComponentInChildren<SpriteRenderer>();
                sr.sprite = OBlock;
                break;
            case 5:
                sr = (sprites[index] as GameObject).GetComponentInChildren<SpriteRenderer>();
                sr.sprite = SBlock;
                break;
            case 6:
                sr = (sprites[index] as GameObject).GetComponentInChildren<SpriteRenderer>();
                sr.sprite = ZBlock;
                break;
            case 7:
                sr = (sprites[index] as GameObject).GetComponentInChildren<SpriteRenderer>();
                sr.sprite = TBlock;
                break;
            default:
                sr = (sprites[index] as GameObject).GetComponentInChildren<SpriteRenderer>();
                sr.sprite = IBlock;
                break;
        }
        Debug.Log("SR = " + sr.sprite);
    }*/}
}
