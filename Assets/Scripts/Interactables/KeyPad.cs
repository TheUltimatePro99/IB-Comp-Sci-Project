using UnityEngine;

public class KeyPad : Interactable
{
    [SerializeField]
    private GameObject door;
    private bool doorOpen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        doorOpen = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    protected override void Interact()
    {
        doorOpen = !doorOpen;
        door.GetComponent<Animator>().SetBool("isOpen", doorOpen);
    }
}
   