using UnityEngine;

public class MoveControlRods : MonoBehaviour
{

    public float range = 1000f;

    public Camera fpsCam;

    public Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            if (hit.transform.tag == "Control Rods")
            {
                //hit.transform.object.animator.SetBool("Up", true);
                animator = hit.transform.GetComponent<Animator>();
                animator.SetBool("Up", true);
            }

            if(hit.transform.tag == "Turbines")
            {
                animator = hit.transform.GetComponent<Animator>();
                animator.SetBool("Rotate", true);
            }
        }
    }
}
