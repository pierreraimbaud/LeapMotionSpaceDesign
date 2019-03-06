using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Leap;
using Leap.Unity;
using System.Threading;
using TMPro;

namespace Leap.Unity {
	public class DetectionGroundHandTouch : MonoBehaviour {

		public static PrimitiveType form;
		public static int augmentation=50;
		public GameObject scenario;
	    public TextMeshPro countText;

		private int count;		
		
		Material m_Material;
		Rigidbody m_Rigidbody;
		Frame frame;
		Controller controller;
		GameObject lastObject;		
		bool neverClosed=false;
		bool okForCreating = true;

		// Use this for initialization
		
		void Start () {
			count = 0;
			m_Rigidbody = GetComponent<Rigidbody>();
			m_Material = GetComponent<Renderer>().material;
			m_Rigidbody.constraints = RigidbodyConstraints.FreezeAll;
			controller = new Controller();
			form=PrimitiveType.Cube;
		}
		
		Hand searchRightHand(List<Hand> hands){
			Hand hand=null;
			for (int i = 0; i < hands.Count; i++)
			{
				if(hands[i].IsRight){
					hand=hands[i];
				}
			}
			return hand;
		}
		
		Hand searchLeftHand(List<Hand> hands){
			Hand hand=null;
			for (int i = 0; i < hands.Count; i++)
			{
				if(hands[i].IsLeft){
					hand=hands[i];
				}
			}
			return hand;
		}
		
		void SetCountText ()
		{
			countText.text = count.ToString () + "$";
		}
	
		// Update is called once per frame
		void Update () {
			
			frame= controller.Frame (); 
			
			List<Hand> hands = frame.Hands;
			
			if(hands.Count > 1){				
				
				Hand lHand = searchLeftHand(hands);
				Hand rHand = searchRightHand(hands);

				if (okForCreating==false&&lHand!=null&&!lHand.Fingers[0].IsExtended && !lHand.Fingers[1].IsExtended && !lHand.Fingers[2].IsExtended && !lHand.Fingers[3].IsExtended && !lHand.Fingers[4].IsExtended){
					okForCreating=true;
					count = count + augmentation;
					SetCountText ();
				}
				if (rHand!=null&&lastObject!=null&&okForCreating==false&&!rHand.Fingers[0].IsExtended && !rHand.Fingers[1].IsExtended && !rHand.Fingers[2].IsExtended && !rHand.Fingers[3].IsExtended && !rHand.Fingers[4].IsExtended){
					Destroy(lastObject);
					okForCreating=true;
				}
			};		
		}
				 
		void OnCollisionEnter (Collision col)
		{
			if(okForCreating){
				
				if (col.rigidbody){
					col.rigidbody.isKinematic = true;
				}
				
				List<Hand> hands = frame.Hands;
				
				if(hands.Count>0){
					Hand rightHand = searchRightHand(hands);
					if(rightHand!=null){
						Finger finger = rightHand.Fingers[0];
						if(finger!=null){
							Leap.Vector position = finger.TipPosition;
							if(col.gameObject.transform.parent!=null){
								if(col.gameObject.transform.parent.parent!=null){
									if (rightHand.Fingers[0].IsExtended&&col.gameObject.transform.parent.parent.gameObject.name.Contains("RigidRoundHand_R")){

									GameObject cube = GameObject.CreatePrimitive(form);
									Vector3 pt =col.contacts[0].point;
									cube.transform.position = new Vector3(pt.x,pt.y,pt.z);
									cube.transform.localScale = new Vector3(0.05f,0.05f,0.05f);
									Color co= new Color((float)Random.Range(0,0),(float)Random.Range(0,0),(float)Random.Range(0,0));
									cube.GetComponent<Renderer>().material.SetColor("_Color",Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f));
									cube.transform.SetParent(scenario.transform);
									cube.AddComponent<Rigidbody>();
									cube.GetComponent<Rigidbody>().useGravity = false;
									cube.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
									okForCreating=false;
									lastObject=cube;
									}
								}
							}
						}
					}
				
				}
			}			
		} 
	}
}