using VRTK;
using UnityEngine;

public class BookTrigger : MonoBehaviour {

    private VRTK_InteractableObject io;
    private bool grabbed;
    public GameObject BooktoRead;

    void OnEnable()
    {
        io = GetComponent<VRTK_InteractableObject>();
        grabbed = false;
        io.InteractableObjectGrabbed += Io_InteractableObjectGrabbed;
        io.InteractableObjectUngrabbed += Io_InteractableObjectUngrabbed;
    }

    private void Io_InteractableObjectUngrabbed(object sender, InteractableObjectEventArgs e)
    {
        //book is ungrabbed
        grabbed = false;
    }

    private void Io_InteractableObjectGrabbed(object sender, InteractableObjectEventArgs e)
    {
        //book is grabbed
        grabbed = true;
    }

    void OnDisable()
    {
        io.InteractableObjectGrabbed -= Io_InteractableObjectGrabbed;
        io.InteractableObjectUngrabbed -= Io_InteractableObjectUngrabbed;

    }

    void Update()
    {
        if (grabbed) { BooktoRead.SetActive(true); }
            
        else { BooktoRead.SetActive(false); }
    }
}
