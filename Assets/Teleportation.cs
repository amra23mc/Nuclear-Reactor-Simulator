using UnityEngine;

public class Teleportation : MonoBehaviour
{

    //public Vector3 place;
    //private RaycastHit hit;

    public Vector3[] currentTp;
    public Vector3 place;
    public int index = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit)){
        //    place = new Vector3(hit.point.x, hit.point.y, hit.point.z);

        //    if (Input.GetMouseButtonDown(0))
        //    {
        //        this.gameObject.SetActive(false);
        //        transform.position = place;
        //        this.gameObject.SetActive(true);
        //    }
        //}

        
        if(index != 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                index-=1;
                Teleport();
            }
        }

        if(index < currentTp.Length - 1)
        {
            if (Input.GetMouseButtonDown(1))
            {
                index+=1;
                Teleport();
            }
        }
    }

    void Teleport()
    {
        place = currentTp[index];
        this.gameObject.SetActive(false);
        transform.position = place;
        this.gameObject.SetActive(true);
    }
}
