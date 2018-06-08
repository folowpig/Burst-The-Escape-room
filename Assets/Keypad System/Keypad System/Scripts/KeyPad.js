var Num1 = 0;
var Num2 = 0;
var Num3 = 0;
var Num4 = 0;
var Code = "";
var Screen1 : GameObject;

var RandomCode = true;
var TestCode = "";
private var Add = 0;
var SetActiveTrue : GameObject;
var SetActiveFalse : GameObject;

var Nothing : Texture;
var T1 : Texture;
var T2 : Texture;
var T3 : Texture;
var T4 : Texture;
var Incorrect : Texture;
var Active = true;

private var N1 = 1;
private var N2 = 2;
private var N3 = 3;
private var N4 = 4;
private var N5 = 5;
private var N6 = 6;
private var N7 = 7;
private var N8 = 8;
private var N9 = 9;
private var N0 = 0;
private var Wait = false;
var FailSound : AudioClip;
var WinSound : AudioClip;

function OpenSound () {GetComponent.<AudioSource>().PlayOneShot(WinSound);}

function Reset ()
{
	Wait = true;
	GetComponent.<AudioSource>().PlayOneShot(FailSound);
	Screen1.GetComponent.<Renderer>().material.mainTexture = Incorrect;
	yield WaitForSeconds(1);
	Add = 0;
	TestCode = "";	
	Wait = false;
	Screen1.GetComponent.<Renderer>().material.mainTexture = Nothing;
}
function Start () 
{
	if(RandomCode == true)
	{
		Num1 = Random.Range(0,9);
		Num2 = Random.Range(0,9);
		Num3 = Random.Range(0,9);
		Num4 = Random.Range(0,9);
	}
	Code = Num1.ToString();
	Code += Num2.ToString();
	Code += Num3.ToString();
	Code += Num4.ToString();
}

function Update () 
{
	if(Add == 0 && Wait == false){Screen1.GetComponent.<Renderer>().material.mainTexture = Nothing;}
	if(Add == 1){Screen1.GetComponent.<Renderer>().material.mainTexture = T1;}
	if(Add == 2){Screen1.GetComponent.<Renderer>().material.mainTexture = T2;}
	if(Add == 3){Screen1.GetComponent.<Renderer>().material.mainTexture = T3;}
	
	if(Code == TestCode && Add == 4 && Active == true)
	{
		Screen1.GetComponent.<Renderer>().material.mainTexture = T4;
		OpenSound();
		Active = false;
		//Effects when correct
		SetActiveTrue.SetActive(true);
		SetActiveFalse.SetActive(false);
	}
	if(Code != TestCode && Add == 4 && Wait == false)
	{
		Reset();
	}
}

function Add1 (){if(Active == true){TestCode += N1.ToString(); Add += 1;}}
function Add2 (){if(Active == true){TestCode += N2.ToString(); Add += 1;}}
function Add3 (){if(Active == true){TestCode += N3.ToString(); Add += 1;}}
function Add4 (){if(Active == true){TestCode += N4.ToString(); Add += 1;}}
function Add5 (){if(Active == true){TestCode += N5.ToString(); Add += 1;}}
function Add6 (){if(Active == true){TestCode += N6.ToString(); Add += 1;}}
function Add7 (){if(Active == true){TestCode += N7.ToString(); Add += 1;}}
function Add8 (){if(Active == true){TestCode += N8.ToString(); Add += 1;}}
function Add9 (){if(Active == true){TestCode += N9.ToString(); Add += 1;}}
function Add0 (){if(Active == true){TestCode += N0.ToString(); Add += 1;}}
