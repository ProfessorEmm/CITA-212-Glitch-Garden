using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] GameObject GOdefender;
    private void OnMouseDown()
    {
        // spawn the defender
        SpawnDefender(GetSquareClicked());

    } // OnMouseDown()

    private Vector2 GetSquareClicked()
    {
        // obtain the mouse position to add a defender
        Vector2 V2clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        // convert from a screen to a World coordinate
        Vector2 V2worldPos = Camera.main.ScreenToWorldPoint(V2clickPos);
        return V2worldPos;
    } // GetSquareClicked()

    private void SpawnDefender(Vector2 V2worldPos)
    {
        // instantiate a defender with NO rotation 
        GameObject GOnewDefender = 
            Instantiate(GOdefender, V2worldPos, 
            Quaternion.identity) as GameObject;
    } // SpawnDefender()

} // class DefenderSapwner
