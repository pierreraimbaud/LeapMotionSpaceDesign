using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Leap;
using Leap.Unity;
using System.Threading;

namespace Leap.Unity {
	public class ChangeCurrentForm : MonoBehaviour {
		Rigidbody m_Rigidbody;
		public string form;
		void Start () {
			m_Rigidbody = GetComponent<Rigidbody>();
			m_Rigidbody.constraints = RigidbodyConstraints.FreezeAll;
					}
		
		void OnCollisionEnter (Collision col)
		{
			if (col.rigidbody){
				col.rigidbody.isKinematic = true;
			}			
			if (form.Equals("Sphere")){
				DetectionGroundHandTouch.form=PrimitiveType.Sphere;
				DetectionGroundHandTouch.augmentation=200;
			}
			if (form.Equals("Cube")){
				DetectionGroundHandTouch.form=PrimitiveType.Cube;
				DetectionGroundHandTouch.augmentation=50;
			}
			if (form.Equals("Rect")){
				DetectionGroundHandTouch.form=PrimitiveType.Cylinder;
				DetectionGroundHandTouch.augmentation=300;
			}
		}
	}
}