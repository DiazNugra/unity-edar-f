using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragControl : MonoBehaviour
{
    public GameObject item;
    public GameObject itemDrop;

    public int jarak;

    Vector2 itemPos;
    // Start is called before the first frame update
    void Start()
    {
        itemPos = item.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void itemDrag()
    {
        item.transform.position = Input.mousePosition;
    }

    public void itemEndDrag()
    {
        float distance = Vector3.Distance(item.transform.localPosition, itemDrop.transform.localPosition);

        if(distance < jarak)
        {
            item.transform.localPosition = itemDrop.transform.localPosition;
        }
        else
        {
            item.transform.localPosition = itemPos;
        }
    }
}
