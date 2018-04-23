<<<<<<< HEAD
﻿//======= Copyright (c) Valve Corporation, All rights reserved. ===============
//
// Purpose: This object's rigidbody goes to sleep when created
//
//=============================================================================

using UnityEngine;
using System.Collections;

namespace Valve.VR.InteractionSystem
{
	//-------------------------------------------------------------------------
	public class SleepOnAwake : MonoBehaviour
	{
		//-------------------------------------------------
		void Awake()
		{
			Rigidbody rigidbody = GetComponent<Rigidbody>();
			if ( rigidbody )
			{
				rigidbody.Sleep();
			}
		}
	}
}
=======
﻿//======= Copyright (c) Valve Corporation, All rights reserved. ===============
//
// Purpose: This object's rigidbody goes to sleep when created
//
//=============================================================================

using UnityEngine;
using System.Collections;

namespace Valve.VR.InteractionSystem
{
	//-------------------------------------------------------------------------
	public class SleepOnAwake : MonoBehaviour
	{
		//-------------------------------------------------
		void Awake()
		{
			Rigidbody rigidbody = GetComponent<Rigidbody>();
			if ( rigidbody )
			{
				rigidbody.Sleep();
			}
		}
	}
}
>>>>>>> 55a10351f611f5493cf6f67f6cf76a4844defc4d
