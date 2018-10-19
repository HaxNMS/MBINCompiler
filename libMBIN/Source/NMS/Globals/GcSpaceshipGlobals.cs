﻿using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Globals {

    [NMS( GUID = 0x49843E9480857ED0 )]
    public class GcSpaceshipGlobals : GlobalData {

        /* 0x0 */  public float MaximumShipHeightWhenExiting;
		/* 0x4 */  public float DistanceFromShipToAllowSpawningOnFreighter;
		/* 0x8 */  public bool AltControls;
		/* 0x9 */  public bool SpaceMapInWorld;
		/* 0xA */  public bool _3rdPersonShipEnabled;
		/* 0xB */  public bool AimZoomAuto;
		/* 0xC */  public bool EnableDepthTestedCrosshairSections;
		/* 0xD */  public bool CritsFromBehind;
		/* 0xE */  public bool DrawLineLockTarget;
		/* 0xF */  public bool ApplyHeightForce;
		/* 0x10 */ public bool ApplyHeightAlign;
		/* 0x11 */ public bool DoPreCollision;
		/* 0x12 */ public bool SpeedTrackModeEnabled;
		/* 0x14 */ public int TrailMaxNumPointsPerFrameOverride;
		/* 0x18 */ public float TestTrailSpeed;
		/* 0x1C */ public float TestTrailRadius;
		/* 0x20 */ public float CockpitExitAnimTime;
		/* 0x24 */ public float CockpitExitAnimOffset;
		/* 0x28 */ public TkCurveType CockpitExitAnimCurve;
		/* 0x2C */ public float LandingHoverOffset;
		/* 0x30 */ public float LandingMaxSpeed;
		/* 0x34 */ public float LandingMargin;
		/* 0x38 */ public float LandingTooManyLowPointsFraction;
		/* 0x3C */ public float WingmanSpeedTrackForceMax;
		/* 0x40 */ public float WingmanSpeedTrackForceMin;
		/* 0x44 */ public float WingmanSpeedTrackDistance;
		/* 0x48 */ public float WingmanSpeedTrackOffset;
		/* 0x4C */ public float WingmanSpeedApproachSpeed;
		/* 0x50 */ public float WingmanSpeedApproachSpeedSpace;

        [NMS(Size = 0xC, Ignore = true)]
        /* 0x54 */ public byte[] Padding54;

        /* 0x60 */ public Vector4f DebugShipSpawnPos;
        /* 0x70 */ public Vector4f DebugShipSpawnFacing;
        /* 0x80 */ public Vector4f DebugShipSpawnUp;
        /* 0x90 */ public float DockingAttractAlign;
        /* 0x94 */ public float DockingAttractAlignRange;

        [NMS(Size = 0x8, Ignore = true)]
        /* 0x98 */ public byte[] Padding98;

        /* 0xA0 */ public Colour LandingEffectSpaceColourOverride;
        /* 0xB0 */ public Colour GroundEffectBuildingColour;
        /* 0xC0 */ public Colour GroundEffectWaterColour;
        /* 0xD0 */ public float GroundNearEffectLightFactor;
        /* 0xD4 */ public float GroundNearEffectWaterLightFactor;
        /* 0xD8 */ public float GroundWaterSpeedFactor;
        /* 0xDC */ public float AtmosphereLightIntensity;
        /* 0xE0 */ public Colour AtmosphereLightOffset;
        /* 0xF0 */ public float OutpostDockSpeedAlignMinDistance;
        /* 0xF4 */ public float OutpostDockSpeedAlignRange;
        /* 0xF8 */ public float NearGroundPitchCorrectMinHeight;
        /* 0xFC */ public float NearGroundPitchCorrectRange;
        /* 0x100 */ public float NearGroundPitchCorrectMinHeightRemote;
        /* 0x104 */ public float NearGroundPitchCorrectRangeRemote;
        /* 0x108 */ public float MiniWarpMarkerApproachSlowdown;
        /* 0x10C */ public float MiniWarpMarkerAlignSlowdown;
        /* 0x110 */ public float MiniWarpMarkerAlignSlowdownRange;
        /* 0x114 */ public float MiniWarpAlignSlerp;
        /* 0x118 */ public float WarpInTime;
        /* 0x11C */ public float WarpInFlashTime;
        /* 0x120 */ public float WarpInRange;
        /* 0x124 */ public float WarpScale;
        /* 0x128 */ public float WarpInTimeFreighter;
        /* 0x12C */ public float WarpInFlashTimeFreighter;
        /* 0x130 */ public float WarpInRangeFreighter;
        /* 0x134 */ public float WarpScaleFreighter;
        /* 0x138 */ public float WarpFadeInTime;
        /* 0x13C */ public float WarpInLineWidth;
        /* 0x140 */ public TkCurveType WarpInCurve;
        /* 0x144 */ public float WarpOutRange;
        /* 0x148 */ public float WarpOutTime;
        /* 0x14C */ public float NetworkDockSearchRadius;
        /* 0x150 */ public float DirectionDockingIndicatorRange;
        /* 0x154 */ public float DirectionDockingIndicatorMinHeight;
        /* 0x158 */ public float DirectionDockingIndicatorMaxHeight;
        /* 0x160 */ public Colour DirectionDockingInRangeColour;
        /* 0x170 */ public Colour DirectionDockingOutRangeColour;
        /* 0x180 */ public float DirectionDockingCircleOffset;
        /* 0x184 */ public float DirectionDockingCircleOffsetExtra;
        /* 0x188 */ public float DirectionDockingCircleWidth;
        /* 0x18C */ public float DirectionDockingCircleRadius;
        /* 0x190 */ public float DirectionDockingCircleRadiusExtra;
        /* 0x194 */ public float DirectionDockingIndicatorSpeed;
        /* 0x198 */ public TkCurveType DirectionDockingIndicatorCurve;
        /* 0x19C */ public float ExhaustSpeed;
        /* 0x1A0 */ public float GroundNearEffectHeight;
        /* 0x1A4 */ public float GroundNearEffectRange;
        /* 0x1A8 */ public float GroundNearEffectNormalOffset;
        /* 0x1AC */ public float GroundNearEffectBuildingFade;
        /* 0x1B0 */ public bool TestShipAnims;
        /* 0x1B4 */ public float TestShipAnimRoll;
        /* 0x1B8 */ public float TestShipAnimThrust;
        /* 0x1BC */ public float TestShipAnimPulse;
        /* 0x1C0 */ public float TestShipAnimSpace;
        /* 0x1C4 */ public GcSpaceshipAvoidanceData Avoidance;
        /* 0x1E8 */ public float DefaultTrailInitialSpeed;
        /* 0x1EC */ public float DefaultTrailSpeedDamping;
        /* 0x1F0 */ public float DefaultTrailMinForwardSpeed;
        /* 0x1F4 */ public float TrailVelocityFactor;
        /* 0x1F8 */ public float ContrailSpeedDamping;
        /* 0x1FC */ public float MaxOverspeedBrake;
        /* 0x200 */ public float PostWarpSlowDownTime;
        /* 0x204 */ public float PulseDrivePlanetApproachMinAngle;
        /* 0x208 */ public float PulseDrivePlanetApproachMaxAngle;
        /* 0x20C */ public float PulseDrivePlanetApproachHeight;
        /* 0x210 */ public float TestJetsStage1;
        /* 0x214 */ public float TestJetsStage2;
        /* 0x218 */ public float TestJetsBoost;
        /* 0x21C */ public float TestTrailThreshold;
        /* 0x220 */ public float ContrailDefaultAlpha;
        /* 0x224 */ public float EngineJetLightIntensityMultiplier;
        /* 0x228 */ public float EngineEffectsThrustContribution;
        /* 0x22C */ public float TestShieldEffect;
        /* 0x230 */ public float ShieldEffectHitTime;
        /* 0x234 */ public TkCurveType ShieldEffectHitCurve;

        [NMS(Size = 0x8, Ignore = true)]
        /* 0x238 */ public byte[] Padding238;

        /* 0x240 */ public GcScanEffectData ShieldEffectScanData;
        /* 0x290 */ public float _3rdPersonUpOffsetRollChangeSpeed;
        /* 0x294 */ public float _3rdPersonRollAngle;
        /* 0x298 */ public float _3rdPersonRollAngleDropship;
        /* 0x29C */ public float _3rdPersonRollAngleScience;
        /* 0x2A0 */ public float _3rdPersonPitchAngle;
        /* 0x2A4 */ public float _3rdPersonYawAngle;
        /* 0x2A8 */ public float _3rdPersonYawAngleLateralExtra;
        /* 0x2AC */ public float _3rdPersonAngleSpringTime;
        /* 0x2B0 */ public float _3rdPersonAngleMinSpeed;
        /* 0x2B4 */ public float _3rdPersonAngleSpeedRangePitch;
        /* 0x2B8 */ public float _3rdPersonAngleSpeedRangeYaw;
        /* 0x2BC */ public float _3rdPersonLowHeightMin;
        /* 0x2C0 */ public float _3rdPersonLowHeightMax;
        /* 0x2C4 */ public float _3rdPersonLowHeightOffsetVertRotationY;
        /* 0x2C8 */ public float _3rdPersonLowHeightOffsetY;
        /* 0x2CC */ public float _3rdPersonLowHeightSpringTime;
        /* 0x2D0 */ public float _3rdPersonAvoidanceAdjustPitchFactor;
        /* 0x2D4 */ public float _3rdPersonHeightForceAdjustPitchFactor;
        /* 0x2D8 */ public float _3rdPersonAvoidanceAdjustRollFactor;
        /* 0x2DC */ public float _3rdPersonAvoidanceAdjustYawFactor;
        /* 0x2E0 */ public float _3rdPersonFlashIntensity;
        /* 0x2E4 */ public float _3rdPersonFlashDuration;
        /* 0x2E8 */ public float _3rdPersonTransitionTime;
        /* 0x2EC */ public float CockpitRollAngleExtra;
        /* 0x2F0 */ public float CockpitRollAngle;
        /* 0x2F4 */ public float CockpitRollTime;
        /* 0x2F8 */ public float CockpitRollMultiplierCentre;
        /* 0x2FC */ public float CockpitRollMultiplierOpposite;
        /* 0x300 */ public float CockpitDriftAngle;
        /* 0x304 */ public float AvoidancePower;
        /* 0x308 */ public float AvoidanceDistancePower;
        /* 0x30C */ public float CollisionDeflectForce;
        /* 0x310 */ public float CollisionAlignStrength;

        [NMS(Size = 0xC, Ignore = true)]
        /* 0x314 */ public byte[] Padding314;

        /* 0x320 */ public Vector4f DefaultCentreOffset;
        /* 0x330 */ public Vector4f DefaultCentreOffsetDropship;
        /* 0x340 */ public Vector4f DefaultCentreOffsetScientific;
        /* 0x350 */ public Vector4f DefaultCentreOffsetRoyal;
        /* 0x360 */ public float WeaponDamagePotentialReferenceRange;
        /* 0x364 */ public float DirectionBrakeVerticalMultiplier;
        /* 0x368 */ public float LateralDriftRollAmount;
        /* 0x36C */ public float LateralDriftRange;
        /* 0x370 */ public float PadTurnSpeed;
        /* 0x374 */ public float KBThrustSmoothTime;
        /* 0x378 */ public float HoverTakeoffHeight;
        /* 0x37C */ public float HoverTime;
        /* 0x380 */ public float HoverAlignTime;
        /* 0x384 */ public float HoverSpeedFactor;
        /* 0x388 */ public float HoverHeightFactor;
        /* 0x38C */ public float HoverMinSpeed;
        /* 0x390 */ public float HoverLandReachedMinTime;
        /* 0x394 */ public float HoverLandReachedDistance;
        /* 0x398 */ public float HoverLandManeuvreTimeMin;
        /* 0x39C */ public float HoverLandManeuvreTimeMax;
        /* 0x3A0 */ public float HoverLandManeuvreBrake;
        /* 0x3A4 */ public float LandingOnGroundTip;
        /* 0x3A8 */ public bool LandingCheckBuildings;
        /* 0x3AC */ public float LandingCheckBuildingRadiusFactor;
        /* 0x3B0 */ public float AutoLevelWaterMargin;
        /* 0x3B4 */ public float AutoLevelWaterTorque;
        /* 0x3B8 */ public float AutoLevelWaterAngle;
        /* 0x3BC */ public float AutoLevelPitchCorrectMargin;
        /* 0x3C0 */ public Vector4f PostCollisionAngularFactor;
        /* 0x3D0 */ public float DrawLineLockTargetLineWidth;
        /* 0x3D4 */ public float DamageFlashScale;
        /* 0x3D8 */ public float DamageFlashMin;
        /* 0x3DC */ public float LandingButtonMinTime;
        /* 0x3E0 */ public float LandingPushNoseUpFactor;
        /* 0x3E4 */ public float GroundHeightSoftForce;
        /* 0x3E8 */ public float GroundHeightSoft;
        /* 0x3EC */ public float GroundHeightSoftHorizontal;
        /* 0x3F0 */ public TkCurveType GroundHeightSoftCurve;
        /* 0x3F4 */ public float GroundHeightHard;
        /* 0x3F8 */ public float GroundHeightHardHorizontal;
        /* 0x3FC */ public TkCurveType GroundHeightHardCurve;
        /* 0x400 */ public float GroundHeightPostCollisionMultiplier;
        /* 0x404 */ public float GroundHeightPostCollisionMultiplierTime;
        /* 0x408 */ public float GroundHeightDownSpeedMultiplier;
        /* 0x40C */ public float GroundHeightBrakeMultiplier;
        /* 0x410 */ public float CockpitPitchCorrectAngle;
        /* 0x414 */ public float PitchCorrectDownSpeedMinSpeed;
        /* 0x418 */ public float PitchCorrectDownSpeedRange;
        /* 0x41C */ public float PitchCorrectDownSpeedSoftAngle;
        /* 0x420 */ public float PitchCorrectDownSpeedMaxDownAngle;
        /* 0x424 */ public float PitchCorrectDownSpeedHeightMin;
        /* 0x428 */ public float PitchCorrectDownSpeedHeightMax;
        /* 0x42C */ public float PitchCorrectCockpitSpring;
        /* 0x430 */ public float PitchCorrectSoftDownAngle;
        /* 0x434 */ public float PitchCorrectMaxDownAngle;
        /* 0x438 */ public float PitchCorrectMaxDownAnglePostCollision;
        /* 0x43C */ public float PitchCorrectSoftDownAnglePostCollision;
        /* 0x440 */ public float PitchCorrectMaxDownAngleWater;
        /* 0x444 */ public float PitchCorrectSoftDownAngleWater;
        /* 0x448 */ public float PitchCorrectTimeMin;
        /* 0x44C */ public float PitchCorrectTimeMax;
        /* 0x450 */ public float PitchCorrectTimeHeight;
        /* 0x454 */ public float PitchCorrectHeightSpring;
        /* 0x458 */ public float PitchCorrectHeightMin;
        /* 0x45C */ public float PitchCorrectHeightMax;
        /* 0x460 */ public TkCurveType PitchCorrectHeightCurve;
        /* 0x464 */ public TkCurveType LandingCurve;
        /* 0x468 */ public TkCurveType LandingCurveHeavy;
        /* 0x46C */ public GcPlayerSpaceshipControlData Control;
        /* 0x568 */ public GcPlayerSpaceshipControlData ControlLight;
        /* 0x664 */ public GcPlayerSpaceshipControlData ControlHeavy;
        /* 0x760 */ public GcPlayerSpaceshipClassBonuses ControlBonusC;
        /* 0x790 */ public GcPlayerSpaceshipClassBonuses ControlBonusB;
        /* 0x7C0 */ public GcPlayerSpaceshipClassBonuses ControlBonusA;
        /* 0x7F0 */ public GcPlayerSpaceshipClassBonuses ControlBonusS;
        /* 0x820 */ public float HaulerTakeOffMod;
        /* 0x824 */ public float FighterTakeOffMod;
        /* 0x828 */ public float ShuttleTakeOffMod;
        /* 0x82C */ public float ExplorerTakeOffMod;
        /* 0x830 */ public float RoyalTakeOffMod;

        [NMS(Size = 0xC, Ignore = true)]
        /* 0x834 */ public byte[] Padding834;

        /* 0x840 */ public Colour AlarmLightColour;
        [NMS(Size = 0x2)]
        /* 0x850 */ public Vector4f[] AlarmLightOffsets;
        /* 0x870 */ public float AlarmLightIntensity;
        /* 0x874 */ public float AlarmRate;
        /* 0x878 */ public float LockTargetMinDistance;
        /* 0x87C */ public float LockTargetRange;
        /* 0x880 */ public float LockTargetMinScale;
        /* 0x884 */ public float LockTargetMaxScale;
        /* 0x888 */ public float AutoLevelMinPitchAngle;
        /* 0x88C */ public float AutoLevelMaxPitchAngle;
        /* 0x890 */ public float AutoLevelMinAngle;
        /* 0x894 */ public float AutoLevelMaxAngle;
        /* 0x898 */ public bool AutoEjectOnLanding;
        /* 0x899 */ public bool LandedCockpitFreeLook;
        /* 0x89C */ public float FrigateTargetLockRange;
        /* 0x8A0 */ public float TargetLockRange;
        /* 0x8A4 */ public float TargetLockNearestAngle;
        /* 0x8A8 */ public float RemotePlayerLockTimeAfterShot;
        /* 0x8B0 */ public Colour TargetLockPassiveColour;
        /* 0x8C0 */ public Colour TargetLockDangerColour;
        /* 0x8D0 */ public float ShieldRechargeMinHitTime;
        /* 0x8D4 */ public float ShieldRechargeRate;
        /* 0x8D8 */ public float NoBoostStationDistance;
        /* 0x8DC */ public float NoBoostAnomalyDistance;
        /* 0x8E0 */ public float NoBoostSpaceAnomalyDistance;
        /* 0x8E4 */ public float NoBoostFreighterDistance;
        /* 0x8E8 */ public float NoBoostFreighterAngle;
        /* 0x8EC */ public float NoBoostShipDistance;
        /* 0x8F0 */ public float NoBoostShipNearMinTime;
        /* 0x8F4 */ public float NoBoostShipLastHitTime;
        /* 0x8F8 */ public float NoBoostCombatEventTime;
        /* 0x8FC */ public float ThrustDecaySpring;
        /* 0x900 */ public float DriftEffectIntensity;
        /* 0x904 */ public float SpeedCoolOffset;
        /* 0x908 */ public float SpeedCoolNormalSpeedAmount;
        /* 0x90C */ public int HitAsteroidDamage;
        /* 0x910 */ public float CameraPostWarpFovTime;
        /* 0x914 */ public float CameraPostWarpFov;
        /* 0x918 */ public float NormalModeTakeOffCostMultiplier;
        /* 0x91C */ public float SurvivalTakeOffCostMultiplier;
        /* 0x920 */ public float PlayerFreighterClearSpaceRadius;
        /* 0x924 */ public float DriftSpring;
        /* 0x928 */ public float DriftTurnStrengthMultiplier;
        /* 0x92C */ public float DriftTurnBrakeMultiplier;
        /* 0x930 */ public float TurnRudderStrength;
        /* 0x934 */ public float MuzzleLightIntensity;
        /* 0x938 */ public float MuzzleAnimSpeed;
        /* 0x93C */ public TkHitCurveData MuzzleLightCurve;
        /* 0x950 */ public Colour MuzzleLightColour;
        /* 0x960 */ public Vector4f DamageLightOffsetTop;
        /* 0x970 */ public Vector4f DamageLightOffsetLeft;
        /* 0x980 */ public Vector4f DamageLightOffsetRight;
        /* 0x990 */ public float DamageLightIntensity;
        /* 0x994 */ public TkHitCurveData DamageLightCurve;
        /* 0x9B0 */ public Colour DamageLightColourShield;
        /* 0x9C0 */ public Colour DamageLightColour;
        /* 0x9D0 */ public bool AltAtmosphere;
        /* 0x9D4 */ public float AsteroidHitAngle;
        /* 0x9D8 */ public float AsteroidHitAngleBoosting;
        /* 0x9DC */ public float AimCritAngle;
        /* 0x9E0 */ public float AimCritMinFwdAngle;
        /* 0x9E4 */ public float AimCritBehindAngle;
        /* 0x9E8 */ public float MissileShootTime;
        /* 0x9EC */ public float CruiseHeight;
        /* 0x9F0 */ public float CruiseHeightRange;
        /* 0x9F4 */ public float CruiseOffAngle;
        /* 0x9F8 */ public float CruiseOffAngleRange;
        /* 0x9FC */ public float CruiseForce;
        /* 0xA00 */ public float HoverMaxSpeed;
        /* 0xA04 */ public float HoverStopTime;
        /* 0xA08 */ public float LandOffset;
        /* 0xA0C */ public float AimFoVBoost;
        /* 0xA10 */ public float AimFoVBoostTime;
        /* 0xA14 */ public float AimFoVBoostTimeAuto;
        /* 0xA18 */ public float AimTurnSlower;
        /* 0xA1C */ public float AimMaxAutoAngle;
        /* 0xA20 */ public float HoverBrakeStrength;
        /* 0xA24 */ public float StickyTurnMinAngle;
        /* 0xA28 */ public float StickyTurnAngleRange;
        /* 0xA2C */ public float StickyTurnLow;
        /* 0xA30 */ public float StickyTurnHigh;
        /* 0xA34 */ public float StickyStickAngle;
        /* 0xA38 */ public Vector2f DeathSpinRoll;
        /* 0xA40 */ public Vector2f DeathSpinPitch;
        /* 0xA48 */ public int MiniWarpLinesNum;
        /* 0xA4C */ public float MiniWarpLinesSpacing;
        /* 0xA50 */ public float MiniWarpLinesOffset;
        /* 0xA54 */ public float MiniWarpLinesHeight;
        /* 0xA58 */ public float GravityDropMinHeight;
        /* 0xA5C */ public float GravityDropMaxForceHeight;
        /* 0xA60 */ public float GravityDropMaxHeight;
        /* 0xA64 */ public float GravityDropForce;
        /* 0xA68 */ public GcPlayerStickData StickData;
        /* 0xA84 */ public float ResourceCollectOffset;
        /* 0xA88 */ public float AimSpeedTrackDistance;
        /* 0xA8C */ public float AimSpeedTrackForce;
        /* 0xA90 */ public float CombatBoostMultiplier;
        /* 0xA94 */ public float CombatBoostTurnDamp;
        /* 0xA98 */ public float MarkerEventTime;
        /* 0xA9C */ public int GunAmmoMultiplier;
        [NMS(Size = 0x3)]
        /* 0xAA0 */ public GcPlayerSpaceshipAim[] LaserAimArray;
        /* 0xAE8 */ public float LaserAimLevel;
        [NMS(Size = 0x3)]
        /* 0xAEC */ public GcPlayerSpaceshipAim[] GunAimArray;
        /* 0xB34 */ public int TakeOffCost;
        /* 0xB38 */ public int LandingCost;
        /* 0xB3C */ public int GunAimLevel;
        /* 0xB40 */ public GcPlayerSpaceshipAim MissileAim;
        /* 0xB58 */ public float MissileLockSpeedUp;
        /* 0xB5C */ public float MissileLockTime;
        /* 0xB60 */ public float AutoPilotAlignStrength;
        /* 0xB64 */ public float FreighterApproachDistanceMin;
        /* 0xB68 */ public float FreighterApproachDistanceMax;
        /* 0xB6C */ public float FreighterApproachSpeedDamper;
        /* 0xB70 */ public float FreighterApproachExtraMargin;
        /* 0xB74 */ public float MiniWarpShakeStrength;
        /* 0xB78 */ public float MiniWarpPlanetRadius;
        /* 0xB7C */ public float MiniWarpStationRadius;
        /* 0xB80 */ public float MiniWarpFuelTime;
        /* 0xB84 */ public float MiniWarpAlignStrength;
        /* 0xB88 */ public float MiniWarpChargeTime;
        /* 0xB8C */ public float MiniWarpSpeed;
        /* 0xB90 */ public float MiniWarpTopSpeedTime;
        /* 0xB94 */ public float MiniWarpTime;
        /* 0xB98 */ public float MiniWarpCooldownTime;
        /* 0xB9C */ public float MiniWarpStoppingMarginPlanet;
        /* 0xBA0 */ public float MiniWarpMinPlanetDistance;
        /* 0xBA4 */ public float MiniWarpStoppingMarginStation;
        /* 0xBA8 */ public float MiniWarpTrackingMargin;
        /* 0xBAC */ public float MiniWarpExitSpeed;
        /* 0xBB0 */ public float MiniWarpExitSpeedStation;
        /* 0xBB4 */ public float MiniWarpExitTime;
        /* 0xBB8 */ public float MiniWarpHUDArrowAttractAngle;
        /* 0xBBC */ public TkCurveType MiniWarpCurve;
        /* 0xBC0 */ public float MiniWarpFlashIntensity;
        /* 0xBC4 */ public float MiniWarpFlashDuration;
        /* 0xBC8 */ public float MiniWarpFlashDelay;
        /* 0xBCC */ public float MiniWarpNoAsteroidRadius;
        /* 0xBD0 */ public float BoostNoAsteroidRadius;
        /* 0xBD4 */ public float LaserOverheatTime;
        /* 0xBD8 */ public float LaserOverheatDownTime;
        /* 0xBDC */ public float LaserCoolFactor;
        /* 0xBE0 */ public float LaserFireTime;
        /* 0xBE4 */ public float LaserWaitTime;
        /* 0xBE8 */ public float ProjectileOverheatTime;
        /* 0xBEC */ public float ProjectileFireRate;
        /* 0xBF0 */ public float ProjectileReloadTime;
        /* 0xBF4 */ public int ProjectileClipSize;
        /* 0xBF8 */ public float SummonShipAnywhereHeightOffset;
        /* 0xBFC */ public float SummonShipAnywhereFwdOffset;
        /* 0xC00 */ public float SummonShipAnywhereRangeMax;
        /* 0xC04 */ public float SummonShipAnywhereRangeMin;
        /* 0xC08 */ public float SummonShipHeightOffset;
        /* 0xC0C */ public float SummonShipApproachOffset;
        /* 0xC10 */ public float LandingHelperMinAngle;
        /* 0xC14 */ public float LandingHelperTurnTime;
        /* 0xC18 */ public float LandingHelperRollTime;
        /* 0xC1C */ public float AnomalyStationMaxApproachSpeed;
        /* 0xC20 */ public float LandGroundTakeOffTime;
        /* 0xC24 */ public float LandLookingForward;
        /* 0xC28 */ public float LandHeightThreshold;
        /* 0xC2C */ public float LandWidthThreshold;
        /* 0xC30 */ public float LandSlopeMax;
        /* 0xC34 */ public float LandingAreaRadius;
        /* 0xC38 */ public float LandingAreaFloorOffset;
        /* 0xC3C */ public float TargetLockTime;
        /* 0xC40 */ public float TargetLockChangeTime;
        /* 0xC44 */ public float TargetLockLoseTime;
        /* 0xC48 */ public float BoostChargeRate;
        /* 0xC4C */ public float DamageMinHitTime;
        /* 0xC50 */ public float DamageMaxHitTime;
        /* 0xC54 */ public float DamageMinWoundTime;
        /* 0xC58 */ public float SpaceBrakeMinAngularSpeed;
        /* 0xC5C */ public float SpaceBrakeAngularRange;
        /* 0xC60 */ public float CollisionSpeedDamageAmount;
        /* 0xC64 */ public float CollisionDeflectTime;
        /* 0xC68 */ public float CollisionDeflectDamping;
        /* 0xC6C */ public float CollisionDeflectNormalFactor;
        /* 0xC70 */ public float CollisionAsteroidDamp;
        /* 0xC74 */ public float CollisionGroundDamp;
        /* 0xC78 */ public float CollisionDistance;
        /* 0xC7C */ public float CollisionDistanceGround;
        /* 0xC80 */ public float CollisionDistanceAsteroid;
        /* 0xC84 */ public float CollisionDistanceAsteroidSide;
        /* 0xC88 */ public float CollisionDistanceSpaceships;
        /* 0xC8C */ public float DeflectDistance;
        /* 0xC90 */ public float DeflectAlignTimeMin;
        /* 0xC94 */ public float DeflectAlignTimeMax;
        /* 0xC98 */ public TkCurveType DeflectCurve;
        /* 0xC9C */ public float CollisionRadiusMultiplier;
        /* 0xCA0 */ public float GroundHeightHardTimeMin;
        /* 0xCA4 */ public float GroundHeightHardTimeMax;
        /* 0xCA8 */ public float GroundHeightPostCollisionDamper;
        /* 0xCAC */ public float GroundHeightSpeedLength;
        /* 0xCB0 */ public float GroundHeightSpeedAngle;
        /* 0xCB4 */ public float GroundHeightSpeedAngleRange;
        /* 0xCB8 */ public int GroundHeightNumRays;
        /* 0xCBC */ public float GroundHeightSmoothTime;
        /* 0xCC0 */ public float LinearDamping;
        /* 0xCC4 */ public float AngularDamping;
        /* 0xCC8 */ public float DirectionDockingAngle;
        /* 0xCCC */ public float DirectionDockTime;
        /* 0xCD0 */ public float DirectionDockingInfoRange;
        /* 0xCD4 */ public float LootAttractDistance;
        /* 0xCD8 */ public float LootAttractTime;
        /* 0xCDC */ public float LootDampForce;
        /* 0xCE0 */ public float LootCollectDistance;
        /* 0xCE4 */ public float GunOffset3rdPersonMultiplier;

        [NMS(Size = 0x8, Ignore = true)]
        /* 0xCE8 */ public byte[] PaddingCE8;

        /* 0xCF0 */ public Vector4f GunOffsetLeft;
        /* 0xD00 */ public Vector4f GunOffsetRight;
        /* 0xD10 */ public Vector4f GunOffsetLeft2;
        /* 0xD20 */ public Vector4f GunOffsetRight2;
        /* 0xD30 */ public Vector4f GunOffset3rdPersonLeft;
        /* 0xD40 */ public Vector4f GunOffset3rdPersonRight;
        /* 0xD50 */ public GcPlayerSpaceshipWarpData Warp;
        /* 0xD80 */ public float DockingRotateSpeed;
        /* 0xD84 */ public float EjectAnimSwitchPoint;
        /* 0xD88 */ public float EjectAnimSpeedFactor;
        /* 0xD8C */ public float ShipDifferentRepelRange;
        /* 0xD90 */ public float ShipDifferentRepelAmount;
        /* 0xD94 */ public float AtmosphereSpeed;
        /* 0xD98 */ public float AtmosphereAngle;
        /* 0xD9C */ public float DroneAlignUpTime;
        /* 0xDA0 */ public float DroneDustHeight;
        /* 0xDA4 */ public float DroneMinHeight;
        /* 0xDA8 */ public float DroneHeightAdjust;
        /* 0xDAC */ public float FreighterSpeed;
        /* 0xDB0 */ public float DroneWarpTime;
        /* 0xDB4 */ public float DroneWarpMinForce;
        /* 0xDB8 */ public float DroneWarpMaxForce;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0xDBC */ public byte[] PaddingDBC;

        /* 0xDC0 */ public Vector4f CockpitScale;
        /* 0xDD0 */ public float ShakePowerScaler;
        /* 0xDD4 */ public float ShakeSpeed;
        /* 0xDD8 */ public float ShakeMaxPower;
        /* 0xDDC */ public float ShakeMaxSpeed;
        /* 0xDE0 */ public float ShakeAlignBrake;
        /* 0xDE4 */ public float WingmanAtTimeStart;
        /* 0xDE8 */ public float WingmanAtTime;
        /* 0xDEC */ public float WingmanAtTimeBack;
        /* 0xDF0 */ public float WingmanPerpTime;
        /* 0xDF4 */ public float WingmanAttackOffset;
        /* 0xDF8 */ public float WingmanAttackRange;
        /* 0xDFC */ public float WingmanAttackMinRange;
        /* 0xE00 */ public float WingmanAttackAngle;
        /* 0xE04 */ public float WingmanViewerAngle;
        /* 0xE08 */ public float WingmanAttackAimAngle;
        /* 0xE0C */ public float WingmanAttackTime;
        /* 0xE10 */ public float WingmanAttackTimeout;
        /* 0xE14 */ public float WingmanAttackCoolTime;
        /* 0xE18 */ public float WingmanSpawnDist;
        /* 0xE1C */ public float WingmanAlign;
        /* 0xE20 */ public float WingmanAngle;
        /* 0xE24 */ public float WingmanAngle2;
        /* 0xE28 */ public float WingmanRadius;
        /* 0xE2C */ public float WingmanFwd1;
        /* 0xE30 */ public float WingmanFwd2;
        /* 0xE34 */ public float DronePlanetAttackRange;
        /* 0xE38 */ public float DronePlanetAttackMinRange;
        /* 0xE3C */ public float DroneShootTime;
        /* 0xE40 */ public float DroneAlertAngle;
        /* 0xE44 */ public float DroneAlertRange;
        /* 0xE48 */ public float DronePatrolRadius;
        /* 0xE4C */ public float DroneMoveArrivedRange;
        /* 0xE50 */ public float DronePatrolTime;
        /* 0xE54 */ public float ShipEnterRange;
        /* 0xE58 */ public float ShipEnterAngle;
        /* 0xE5C */ public float ShipEnterTransitionTime;
        /* 0xE60 */ public float ShipEnterSpeed;
        /* 0xE64 */ public float ShipEnterMinTime;
        [NMS(Size = 0x4)]
        /* 0xE68 */ public NMSString0x80[] ShipModels;
        /* 0x1068 */ public float HUDBoostUpgradeMultiplier;
        /* 0x106C */ public float LaunchThrustersRegenTimePeriod;
        /* 0x1070 */ public float LaunchThrustersMinimumSummonPercentage;
        /* 0x1074 */ public float LaunchThrustersSummonCostMultiplier;
		/* 0x1078 */ public float SpeedUpDistanceThreshold;
		/* 0x107C */ public float SpeedUpDistanceFadeThreshold;
		/* 0x1080 */ public float SpeedUpVelocityThreshold;
		/* 0x1084 */ public float SpeedUpVelocityCoeff;
		/* 0x1088 */ public float MaxSpeedUpDistance;
		/* 0x108C */ public float MaxSpeedUpVelocity;

    }

}