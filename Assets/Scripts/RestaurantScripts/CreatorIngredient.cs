using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatorIngredient: MonoBehaviour
{
    public GameObject item;
    public Transform trans;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            Instantiate(item, trans);
        }
    }
}
