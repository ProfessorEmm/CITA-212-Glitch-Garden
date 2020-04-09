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
        // obtain world (grid) values (as integer)
        Vector2 V2gridPos = SnapToGrid(V2worldPos);
        return V2gridPos;
    } // GetSquareClicked()

    private Vector2 SnapToGrid(Vector2 V2rawWorldPos)
    {
        // want to round x and y values to an integer value
        // obtain x and y values as float
        float fltNewX = Mathf.RoundToInt(V2rawWorldPos.x);
        float fltNewY = Mathf.RoundToInt(V2rawWorldPos.y);
        return new Vector2(fltNewX, fltNewY);

    } // SnapToGrid()
    private void SpawnDefender(Vector2 V2roundedPos)
    {
        // instantiate a defender with NO rotation 
        GameObject GOnewDefender =
            Instantiate(GOdefender, V2roundedPos, 
            Quaternion.identity) as GameObject;
        Debug.Log(V2roundedPos);
    } // SpawnDefender()

} // class DefenderSapwner
