var ThisNum = 0;
var Box : GameObject;
var An : GameObject;
var Click : AudioClip;

function But ()
{
	
	Box.GetComponent.<AudioSource>().PlayOneShot(Click);
	if(ThisNum == 0){Box.GetComponent("KeyPad").Add0(); An.GetComponent.<Animation>().Play("Press0");}
	if(ThisNum == 1){Box.GetComponent("KeyPad").Add1(); An.GetComponent.<Animation>().Play("Press1");}
	if(ThisNum == 2){Box.GetComponent("KeyPad").Add2(); An.GetComponent.<Animation>().Play("Press2");}
	if(ThisNum == 3){Box.GetComponent("KeyPad").Add3(); An.GetComponent.<Animation>().Play("Press3");}
	if(ThisNum == 4){Box.GetComponent("KeyPad").Add4(); An.GetComponent.<Animation>().Play("Press4");}
	if(ThisNum == 5){Box.GetComponent("KeyPad").Add5(); An.GetComponent.<Animation>().Play("Press5");}
	if(ThisNum == 6){Box.GetComponent("KeyPad").Add6(); An.GetComponent.<Animation>().Play("Press6");}
	if(ThisNum == 7){Box.GetComponent("KeyPad").Add7(); An.GetComponent.<Animation>().Play("Press7");}
	if(ThisNum == 8){Box.GetComponent("KeyPad").Add8(); An.GetComponent.<Animation>().Play("Press8");}
	if(ThisNum == 9){Box.GetComponent("KeyPad").Add9(); An.GetComponent.<Animation>().Play("Press9");}
	
}