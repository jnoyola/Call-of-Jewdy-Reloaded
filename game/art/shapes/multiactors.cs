//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

//error( "***********************************************************************" );
//error( "MultiActors.cs - Start of File" );
//error( "***********************************************************************" );

datablock PxMaterial( PxMaterial_Default ) 
{
   restitution = 0.2;
   staticFriction = 0.6;
   dynamicFriction = 0.4;
};


//PHYSXDOX BEGIN******************************************

/*
datablock PxMultiActorData( px01nonbreakableboard ) 
{
	category = "Physics";
	
	shapeName = "./physXdocs/01_nonbreakableboard.DAE";
	physXStream = "./physXdocs/01_nonbreakableboard.xml";

	//pxMaterial = PhysXMaterial_Default;
	
   noCorrection = true;
         
   waterDragScale = 6;
   buoyancyDensity = 7;

   angularDrag = 0.3;
   linearDrag = 0.3;
   
   clientOnly = false;
   singlePlayerOnly = true;
};


datablock PxMultiActorData( px02breakableboard ) 
{
	category = "Physics";
	
	shapeName = "./physXdocs/02_breakableboard.DAE";
	physXStream = "./physXdocs/02_breakableboard.xml";

	//pxMaterial = PhysXMaterial_Default;
	
   noCorrection = true;
         
   waterDragScale = 6;
   buoyancyDensity = 7;

   angularDrag = 0.3;
   linearDrag = 0.3;
   
   clientOnly = false;
   singlePlayerOnly = true;

   breakForce = 2;

};*/


//PHYSXDOX END*******************************************


datablock PxMultiActorData( pxCoveredStructure ) 
{
	category = "Physics";
	
	shapeName = "./structures/coveredstructure/coveredstructure.dae";
	physXStream = "./structures/coveredstructure/coveredstructure.xml";

	//pxMaterial = PhysXMaterial_Default;
	
   noCorrection = true;
         
   waterDragScale = 6;
   buoyancyDensity = 7;

   angularDrag = 0.3;
   linearDrag = 0.3;
   
   clientOnly = false;
   singlePlayerOnly = true;
};


datablock PxMultiActorData( pxPier ) 
{
	category = "Physics";
	
	shapeName = "./structures/pier/pier.dae";
	physXStream = "./structures/pier/pier.xml";

	pxMaterial = PxMaterial_Default;
	
   noCorrection = true;
         
   waterDragScale = 6;
   buoyancyDensity = 7;

   angularDrag = 0.3;
   linearDrag = 3;
   
   clientOnly = false;
   singlePlayerOnly = true;
};

/*
datablock PxMultiActorData( pxBlackBarrel ) 
{
	category = "Physics";
	
	shapeName = "./props/barrels/barrel_black.dae";
	physXStream = "./props/barrels/barrel_black.xml";

	pxMaterial = PxMaterial_Default;
	
   noCorrection = true;
         
   waterDragScale = 6;
   buoyancyDensity = 1;

   angularDrag = 0.3;
   linearDrag = 0.3;
   
   clientOnly = false;
   singlePlayerOnly = true;
   
   breakForce = 0;
};*/

/*
datablock PxMultiActorData( pxTarget ) 
{
	category = "Physics";
	
	shapeName = "./structures/pier/target.dae";
	physXStream = "./structures/pier/target.xml";

	pxMaterial = PxMaterial_Default;
	
   noCorrection = true;
         
   waterDragScale = 6;
   buoyancyDensity = 7;

   angularDrag = 0.3;
   linearDrag = 0.3;
   
   clientOnly = false;
   singlePlayerOnly = true;
};*/


datablock PxMultiActorData( pxWatertower ) 
{
	category = "Physics";
	
	shapeName = "./structures/pier/watertower.dae";
	physXStream = "./structures/pier/watertower.xml";

	pxMaterial = PxMaterial_Default;
	
   noCorrection = true;
   
   mountNode0 = "light_mount";
         
   waterDragScale = 6;
   buoyancyDensity = 7;

   angularDrag = 0.3;
   linearDrag = 0.3;
   
   clientOnly = false;
   singlePlayerOnly = true;
};

/*
datablock PxMultiActorData( pxCrateSqaure ) 
{
	category = "Physics";
	
	shapeName = "./props/crates/cratesquare.dae";
	physXStream = "./props/crates/cratesquare.xml";

//	pxMaterial = PxMaterial_Default;
	
   noCorrection = true;
         
   waterDragScale = 6;
   buoyancyDensity = 7;

   angularDrag = 0.3;
   linearDrag = 0.3;
   
   clientOnly = false;
   singlePlayerOnly = true;
};
*/

/*
datablock PxMultiActorData( pxCrateRect ) 
{
	category = "Physics";
	
	shapeName = "./props/crates/crate_rectangle.dae";
	physXStream = "./props/crates/crate_rectangle.xml";

//	pxMaterial = PxMaterial_Default;
	
   noCorrection = true;
         
   waterDragScale = 6;
   buoyancyDensity = 7;

   angularDrag = 0.3;
   linearDrag = 0.3;
   
   clientOnly = false;
   singlePlayerOnly = true;
};*/

/*
datablock PxMultiActorData( pxPallet ) 
{
	category = "Physics";
	
	shapeName = "./props/crates/pallet.dae";
	physXStream = "./props/crates/pallet.xml";

//	pxMaterial = PxMaterial_Default;
	
   noCorrection = true;   
         
   waterDragScale = 6;
   buoyancyDensity = 7;

   angularDrag = 0.3;
   linearDrag = 0.3;
   
   clientOnly = false;
   singlePlayerOnly = true;
};*/

datablock LightFlareData( WaterTowerLightFlare )
{
   overallScale = 2.0;
   flareEnabled = true;
   flareTexture = "art/datablocks/../special/lensFlareSheet1";
   
   elementRect[0] = "0 512 512 512";
   elementDist[0] = 0.0;
   elementScale[0] = 0.5;
   elementTint[0] = "0.6 0.5 0.5 1";
   elementRotate[0] = false;
   elementUseLightColor[0] = false;
   
   elementRect[1] = "512 0 512 512";
   elementDist[1] = 0.0;
   elementScale[1] = 1;
   elementTint[1] = "0.55 0.5 0.5 1.0";
   elementRotate[1] = false;
   elementUseLightColor[1] = false;
};

function pxWatertower::onAdd( %this, %obj )
{
   // This code was causing a crash when exiting from the editor
   // I removed it so we can ship. This will be addressed after
   // 1.1 final - MP
   /* 
   %light = new PointLight()
   { 
      radius = 10;
      castShadows = false;
      color = "0.992157 0.443137 0.454902 1";
      brightness = 1.5;
      animationType = "PulseLightAnim";
      flareType = "WaterTowerLightFlare";
      flareScale = 0.8;
   };   
   
   %obj.mountObject( %light, 0 ); 
   if ( !isObject( DynamicLights ) )
      new SimSet( DynamicLights );     
   DynamicLights.add( %light );*/ 
}


//error( "***********************************************************************" );
//error( "MultiActors.cs - End of File" );
//error( "***********************************************************************" );