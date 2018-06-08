using System.Collections;
using UnityEngine;
using VRTK;


public class push_button : MonoBehaviour {

    //private KeyPad keyP = new KeyPad();
    private VRTK_InteractableObject io;
    private bool touched = false;
    public int ThisNum = 0;
    public GameObject An;
    public AudioClip Click;
    private IEnumerator coroutin;

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

    IEnumerator wait (int t)
    {
        
        if (touched)
        {
            //Do when button is touched.
            //GetComponent<AudioSource>().PlayOneShot(Click);
            if (ThisNum == 0) { KeyPad.Add0(); An.GetComponent<Animation>().Play("Press0"); }
            if (ThisNum == 1) { KeyPad.Add1(); An.GetComponent<Animation>().Play("Press1"); }
            if (ThisNum == 2) { KeyPad.Add2(); An.GetComponent<Animation>().Play("Press2"); }
            if (ThisNum == 3) { KeyPad.Add3(); An.GetComponent<Animation>().Play("Press3"); }
            if (ThisNum == 4) { KeyPad.Add4(); An.GetComponent<Animation>().Play("Press4"); }
            if (ThisNum == 5) { KeyPad.Add5(); An.GetComponent<Animation>().Play("Press5"); }
            if (ThisNum == 6) { KeyPad.Add6(); An.GetComponent<Animation>().Play("Press6"); }
            if (ThisNum == 7) { KeyPad.Add7(); An.GetComponent<Animation>().Play("Press7"); }
            if (ThisNum == 8) { KeyPad.Add8(); An.GetComponent<Animation>().Play("Press8"); }
            if (ThisNum == 9) { KeyPad.Add9(); An.GetComponent<Animation>().Play("Press9"); }
        }
        yield return new WaitForSeconds(5);
    }
    void Update()
    {
        coroutin = wait(5);
        StartCoroutine(coroutin);
    }
}
