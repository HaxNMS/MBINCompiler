﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xD688A2199D952E15)]
    public class GcPlayerWeapons : NMSTemplate
    {
		public enum WeaponModeEnum { Bolt, Shotgun, Burst, Laser, Rail, Grenade, MineGrenade, Scope, FrontShield, TerrainEdit }
		public WeaponModeEnum WeaponMode;
    }
}
