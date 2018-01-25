using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

    private string _itemName;
    private string _itemID;

    public string itemName
    {
        get{

            return _itemName;
         
        }
        set
        {

            _itemName = value; // add string checking.
        }

    }

    public string itemID
    {
        get
        {

            return _itemID;

        }
        set
        {

            _itemID = value; // add int check
        }

    }

}
