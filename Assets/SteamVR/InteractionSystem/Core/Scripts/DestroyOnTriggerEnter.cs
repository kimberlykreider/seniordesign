<<<<<<< HEAD
﻿//======= Copyright (c) Valve Corporation, All rights reserved. ===============
//
// Purpose: Destroys this object when it enters a trigger
//
//=============================================================================

using UnityEngine;
using System.Collections;

namespace Valve.VR.InteractionSystem
{
	//-------------------------------------------------------------------------
	public class DestroyOnTriggerEnter : MonoBehaviour
	{
		public string tagFilter;

		private bool useTag;

		//-------------------------------------------------
		void Start()
		{
			if ( !string.IsNullOrEmpty( tagFilter ) )
			{
				useTag = true;
			}
		}


		//-------------------------------------------------
		void OnTriggerEnter( Collider collider )
		{
			if ( !useTag || ( useTag && collider.gameObject.tag == tagFilter ) )
			{
				Destroy( collider.gameObject.transform.root.gameObject );
			}
		}
	}
}
=======
﻿//======= Copyright (c) Valve Corporation, All rights reserved. ===============
//
// Purpose: Destroys this object when it enters a trigger
//
//=============================================================================

using UnityEngine;
using System.Collections;

namespace Valve.VR.InteractionSystem
{
	//-------------------------------------------------------------------------
	public class DestroyOnTriggerEnter : MonoBehaviour
	{
		public string tagFilter;

		private bool useTag;

		//-------------------------------------------------
		void Start()
		{
			if ( !string.IsNullOrEmpty( tagFilter ) )
			{
				useTag = true;
			}
		}


		//-------------------------------------------------
		void OnTriggerEnter( Collider collider )
		{
			if ( !useTag || ( useTag && collider.gameObject.tag == tagFilter ) )
			{
				Destroy( collider.gameObject.transform.root.gameObject );
			}
		}
	}
}
>>>>>>> 55a10351f611f5493cf6f67f6cf76a4844defc4d
