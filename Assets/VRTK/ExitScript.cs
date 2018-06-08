using VRTK;
using UnityEngine;

public class ExitScript : MonoBehaviour
{
    private VRTK_InteractableObject io;
    private bool touched = false;
    public GameObject exit_collide;

    void OnEnable()
    {
        io = GetComponent<VRTK_InteractableObject>();
        touched = false;
        io.InteractableObjectTouched += Io_InteractableObjectTouched;
        io.InteractableObjectUntouched += Io_InteractableObjectUntouched;
    }

    void OnDisable()
    {
        io.InteractableObjectTouched -= Io_InteractableObjectTouched;
        io.InteractableObjectUntouched -= Io_InteractableObjectUntouched;

    }
    private void Io_InteractableObjectUntouched(object sender, InteractableObjectEventArgs e)
    {
        //button is untouched
        touched = false;
    }

    private void Io_InteractableObjectTouched(object sender, InteractableObjectEventArgs e)
    {
        //button is touched
        touched = true;
    }

    void Update()
    {
        if (touched) { Application.LoadLevel(Application.loadedLevel); }
    }
}
