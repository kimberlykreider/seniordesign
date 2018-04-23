<<<<<<< HEAD
﻿//======= Copyright (c) Valve Corporation, All rights reserved. ===============
//
// Purpose: Provides a haptic bump when colliding with balloons
//
//=============================================================================

using UnityEngine;
using System.Collections;

namespace Valve.VR.InteractionSystem
{
	//-------------------------------------------------------------------------
	public class BalloonHapticBump : MonoBehaviour
	{
		public GameObject physParent;

		//-------------------------------------------------
		void OnCollisionEnter( Collision other )
		{
			Balloon contactBalloon = other.collider.GetComponentInParent<Balloon>();
			if ( contactBalloon != null )
			{
				Hand hand = physParent.GetComponentInParent<Hand>();
				if ( hand != null )
				{
					hand.controller.TriggerHapticPulse( 500 );
				}
			}
		}
	}
}
=======
﻿//======= Copyright (c) Valve Corporation, All rights reserved. ===============
//
// Purpose: Provides a haptic bump when colliding with balloons
//
//=============================================================================

using UnityEngine;
using System.Collections;

namespace Valve.VR.InteractionSystem
{
	//-------------------------------------------------------------------------
	public class BalloonHapticBump : MonoBehaviour
	{
		public GameObject physParent;

		//-------------------------------------------------
		void OnCollisionEnter( Collision other )
		{
			Balloon contactBalloon = other.collider.GetComponentInParent<Balloon>();
			if ( contactBalloon != null )
			{
				Hand hand = physParent.GetComponentInParent<Hand>();
				if ( hand != null )
				{
					hand.controller.TriggerHapticPulse( 500 );
				}
			}
		}
	}
}
>>>>>>> 55a10351f611f5493cf6f67f6cf76a4844defc4d
