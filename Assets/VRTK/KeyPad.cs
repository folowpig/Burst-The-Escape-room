using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPad : MonoBehaviour {
    public int Num1 = 0;
    public int Num2 = 0;
    public int Num3 = 0;
    public int Num4 = 0;
    public string Code = "";
    public GameObject Screen1;

    public bool RandomCode = true;
    public static string TestCode = "";
    private static int Add = 0;
    public GameObject SetActiveTrue;
    public GameObject SetActiveFalse;

    public Texture Nothing;
    public Texture T1;
    public Texture T2;
    public Texture T3;
    public Texture T4;
    public Texture Incorrect;
    public static bool Active = true;

    private static int N1 = 1;
    private static int N2 = 2;
    private static int N3 = 3;
    private static int N4 = 4;
    private static int N5 = 5;
    private static int N6 = 6;
    private static int N7 = 7;
    private static int N8 = 8;
    private static int N9 = 9;
    private static int N0 = 0;
    private bool Wait = false;
    public AudioClip FailSound;
    public AudioClip WinSound;
    private IEnumerator coroutin;

    void OpenSound() { GetComponent< AudioSource > ().PlayOneShot(WinSound); }

    IEnumerator Reset()
    {
        Wait = true;
        GetComponent< AudioSource > ().PlayOneShot(FailSound);
        Screen1.GetComponent< Renderer > ().material.mainTexture = Incorrect;
        yield return new WaitForSeconds(3);
        Add = 0;
        TestCode = "";
        Wait = false;
        Screen1.GetComponent< Renderer > ().material.mainTexture = Nothing;
    }

    // Use this for initialization
    void Start () {
        if (RandomCode == true)
        {
            Num1 = Random.Range(0, 9);
            Num2 = Random.Range(0, 9);
            Num3 = Random.Range(0, 9);
            Num4 = Random.Range(0, 9);
        }
        Code = Num1.ToString();
        Code += Num2.ToString();
        Code += Num3.ToString();
        Code += Num4.ToString();
    }
	
	// Update is called once per frame
	void Update () {
        if (Add == 0 && Wait == false) { Screen1.GetComponent< Renderer > ().material.mainTexture = Nothing; }
        if (Add == 1) { Screen1.GetComponent< Renderer > ().material.mainTexture = T1; }
        if (Add == 2) { Screen1.GetComponent< Renderer > ().material.mainTexture = T2; }
        if (Add == 3) { Screen1.GetComponent< Renderer > ().material.mainTexture = T3; }

        if (Code == TestCode && Add == 4 && Active == true)
        {
            Screen1.GetComponent< Renderer > ().material.mainTexture = T4;
            OpenSound();
            Active = false;
            //Effects when correct
            SetActiveTrue.SetActive(true);
            SetActiveFalse.SetActive(false);
        }
        if (Code != TestCode && Add == 4 && Wait == false)
        {
            coroutin = Reset();
            StartCoroutine(coroutin);
        }
    }

    public static void Add1() { if (Active == true) { TestCode += N1.ToString(); Add += 1; } }
    public static void Add2() { if (Active == true) { TestCode += N2.ToString(); Add += 1; } }
    public static void Add3() { if (Active == true) { TestCode += N3.ToString(); Add += 1; } }
    public static void Add4() { if (Active == true) { TestCode += N4.ToString(); Add += 1; } }
    public static void Add5() { if (Active == true) { TestCode += N5.ToString(); Add += 1; } }
    public static void Add6() { if (Active == true) { TestCode += N6.ToString(); Add += 1; } }
    public static void Add7() { if (Active == true) { TestCode += N7.ToString(); Add += 1; } }
    public static void Add8() { if (Active == true) { TestCode += N8.ToString(); Add += 1; } }
    public static void Add9() { if (Active == true) { TestCode += N9.ToString(); Add += 1; } }
    public static void Add0() { if (Active == true) { TestCode += N0.ToString(); Add += 1; } }
}
