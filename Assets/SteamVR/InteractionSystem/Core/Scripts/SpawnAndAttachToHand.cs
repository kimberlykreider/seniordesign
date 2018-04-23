<<<<<<< HEAD
﻿//======= Copyright (c) Valve Corporation, All rights reserved. ===============
//
// Purpose: Creates an object and attaches it to the hand
//
//=============================================================================

using UnityEngine;
using System.Collections;

namespace Valve.VR.InteractionSystem
{
	//-------------------------------------------------------------------------
	public class SpawnAndAttachToHand : MonoBehaviour
	{
		public Hand hand;
		public GameObject prefab;


		//-------------------------------------------------
		public void SpawnAndAttach( Hand passedInhand )
		{
			Hand handToUse = passedInhand;
			if ( passedInhand == null )
			{
				handToUse = hand;
			}

			if ( handToUse == null )
			{
				return;
			}

			GameObject prefabObject = Instantiate( prefab ) as GameObject;
			handToUse.AttachObject( prefabObject );
		}
	}
}
=======
﻿//======= Copyright (c) Valve Corporation, All rights reserved. ===============
//
// Purpose: Creates an object and attaches it to the hand
//
//=============================================================================

using UnityEngine;
using System.Collections;

namespace Valve.VR.InteractionSystem
{
	//-------------------------------------------------------------------------
	public class SpawnAndAttachToHand : MonoBehaviour
	{
		public Hand hand;
		public GameObject prefab;


		//-------------------------------------------------
		public void SpawnAndAttach( Hand passedInhand )
		{
			Hand handToUse = passedInhand;
			if ( passedInhand == null )
			{
				handToUse = hand;
			}

			if ( handToUse == null )
			{
				return;
			}

			GameObject prefabObject = Instantiate( prefab ) as GameObject;
			handToUse.AttachObject( prefabObject );
		}
	}
}
>>>>>>> 55a10351f611f5493cf6f67f6cf76a4844defc4d
