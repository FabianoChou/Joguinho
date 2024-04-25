using UnityEngine;

public class Animation_Ani : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            GetComponent<Animator>().SetInteger("Dinossauro", 0);
        }
        else
        {
            GetComponent<Animator>().SetInteger("Dinossauro", 1);
        }
    }
}