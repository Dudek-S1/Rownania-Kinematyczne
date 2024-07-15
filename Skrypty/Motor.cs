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
		//wykonuj dop�ki przewidywany czas jest wi�kszy ni� czas od zacz�cia gry
		if (Time.fixedTime < Timer.przewidywanyCzas)
		{
			//akualna pr�dko�� jest przyspieszana co sekunde
			aktualnaPredkosc += przyspieszenie * Time.fixedDeltaTime;
			// ruszamy naszym obiektem
			transform.Translate(Vector3.right * aktualnaPredkosc * Time.fixedDeltaTime);
		}

	}
}
