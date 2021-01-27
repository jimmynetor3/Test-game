using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whatSideGetsHit : MonoBehaviour
{
    //
    // public void OnTriggerEnter2D(Collider2D collider)
    // {
    //     
    //     Vector2 PointOnBoxHit = collider.ClosestPoint(transform.position);
    //     Vector2 centerOfObject = collider.bounds.center;
    //     float xMinPoint = Mathf.Abs((collider.bounds.size.x/2) - centerOfObject.x);
    //     float xMaxPoint = Mathf.Abs(xMinPoint + collider.bounds.size.x);
    //     float yMinPoint = Mathf.Abs((collider.bounds.size.y / 2) - centerOfObject.y);
    //     float yMaxPoint = Mathf.Abs(yMinPoint + collider.bounds.size.y);
    //
    //     if (PointOnBoxHit.x >= xMinPoint && PointOnBoxHit.x <= xMaxPoint)
    //         print("bottom");
    //     else if (PointOnBoxHit.x >= xMinPoint && PointOnBoxHit.x <= xMaxPoint)
    //         print("Top");
    //     else if (PointOnBoxHit.y >= yMinPoint && PointOnBoxHit.y <= yMaxPoint)
    //         print("Right");
    //     else
    //         print("Left");
    //     print($"xminpoint = {xMinPoint} xMaxPoint = {xMaxPoint} yMinPoint = {yMinPoint} yMaxPoint = {yMaxPoint} ");
    // }
}
