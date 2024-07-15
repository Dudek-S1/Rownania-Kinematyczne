using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Motor : MonoBehaviour
{

	public float predkoscPoczatkowa;
	public float przyspieszenie;
	float aktualnaPredkosc;

	// Use this for initialization
	void Start()
	{
		aktualnaPredkosc = predkoscPoczatkowa;
	}

	void FixedUpdate()
	{
		//wykonuj dopóki przewidywany czas jest wiêkszy ni¿ czas od zaczêcia gry
		if (Time.fixedTime < Timer.przewidywanyCzas)
		{
			//akualna prêdkoœæ jest przyspieszana co sekunde
			aktualnaPredkosc += przyspieszenie * Time.fixedDeltaTime;
			// ruszamy naszym obiektem
			transform.Translate(Vector3.right * aktualnaPredkosc * Time.fixedDeltaTime);
		}

	}
}
