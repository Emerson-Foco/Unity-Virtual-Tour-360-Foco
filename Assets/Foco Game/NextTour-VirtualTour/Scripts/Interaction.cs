using UnityEngine;

public class Interaction : MonoBehaviour
{
    public GameObject actualTour;
    public GameObject nextTour;
    
    private bool _mouseOn = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_mouseOn && Input.GetKeyUp(KeyCode.Mouse0))
        {
            actualTour.SetActive(false);
            nextTour.SetActive(true);
        }
    }

    public void OnMouseEnter()
    {
        _mouseOn = true;
    }

    public void OnMouseExit()
    {
        _mouseOn = false;
    }
}
