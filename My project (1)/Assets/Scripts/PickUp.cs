using UnityEngine;

public class PickUp : MonoBehaviour
{
    
    private bool isFingersBent = false;
    //Variable for determining finger bending
    public GameObject[] pickableObjects;

   
    
    void Awake()
    {
        //Array of picked objects
        pickableObjects = GameObject.FindGameObjectsWithTag("objects"); 
    }

    void OnMouseDown()
    {
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.parent = GameObject.Find("myhand").transform;
    }


    void PickObject()
    {
        if (isFingersBent)
        {
            /* Object selection logic - here you can add an
               algorithm for matching gesture to objects
               For example, you can select the closest object to
               the player's hand or an object with certain characteristics 
            
               We pick nearest */

            GameObject nearestObject = FindNearestObject();

            if (nearestObject != null)
            {
                //pick up
                nearestObject.transform.SetParent(transform);
                //adjusting the position of the hand relative to the object
                nearestObject.transform.localPosition = new Vector3(0, 15, 5); 
            }
        }
    }

    GameObject FindNearestObject()
    {
        //method to find the nearest object in the pickableObjects array
        GameObject nearestObject = null;
        float nearestDistance = Mathf.Infinity;
        Vector3 handPosition = transform.position;
        //handPosition.y = 15;

        foreach (GameObject obj in pickableObjects)
        {
            float distance = Vector3.Distance(obj.transform.position + new Vector3(0, 15, 5), handPosition);
            if (distance < nearestDistance)
            {
                nearestObject = obj;
                nearestDistance = distance;
            }
        }

        return nearestObject;
    }

    //PLEASE!!! Add the same thing for all fingers bended
    //separately (if you need it, of course) 
    void Update()
    {
        if (Input.GetButton("fistKey"))
        {
            isFingersBent = true;
            PickObject();
            //Debug.Log("Script PickUp is Working");
        }
        else if (Input.GetButton("fistKey"))
        {
            isFingersBent = false;
        }
    }

}
