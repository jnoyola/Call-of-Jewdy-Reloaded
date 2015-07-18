//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------
echo("++++++++++++++++====================++++++++++++++++");
// CrateSmall

datablock PhysicsDebrisData( CrateSquareDebris )
{
   lifetime = 60.0;
   lifetimeVariance = 0.0;

   velocity = 0.1;
   velocityVariance = 0;
   
   shapeFile = "art/shapes/physicsShapes/crate_square_broken.DAE";
   
   mass = 10;
   dynamicFriction = 0;
   staticFriction = 0.5;
   restitution = 0.0;
   linearDamping = 0.0;
   angularDamping = 0.0;
   linearSleepThreshold = 1.0;
   angularSleepThreshold = 1.0;
   waterDampingScale = 1.0;
   buoyancyDensity = "0.1";
   castShadows = "1";
   friction = "0.4";
};

datablock PhysicsShapeData( PSCrateSquare )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/crate_square_unbroken.DAE";
   emap = 1;

   mass = "1";
   massCenter = "0 0 0";    // Center of mass for rigid body
   massBox = "0 0 0";         // Size of box used for moment of inertia,
                              // if zero it defaults to object bounding box
   drag = 0.2;                // Drag coefficient
   bodyFriction = 0.2;
   bodyRestitution = 0.1;
   minImpactSpeed = 5;        // Impacts over this invoke the script callback
   softImpactSpeed = 5;       // Play SoftImpact Sound
   hardImpactSpeed = 15;      // Play HardImpact Sound
   integration = 4;           // Physics integration: TickSec/Rate
   collisionTol = 0.1;        // Collision distance tolerance
   contactTol = 0.1;          // Contact velocity tolerance
   
   minRollSpeed = 10;
   
   maxDrag = 0.5;
   minDrag = 0.01;

   triggerDustHeight = 1;
   dustHeight = 10;

   dragForce = 0.05;
   vertFactor = 0.05;

   normalForce = 0.05;
   restorativeForce = 0.05;
   rollForce = 0.05;
   pitchForce = 0.05;
   
   debris = CrateSquareDebris;
   //Explosion = "WoodMinorExplosion";
   friction = "0.4";
   linearDamping = "0.1";
   angularDamping = "0.2";
   buoyancyDensity = "0.9";
   staticFriction = "0.5";
   explosion = WoodMinorExplosion;
   
   radiusDamage        = 0;
   damageRadius        = 0;
   areaImpulse         = 0;
   restitution = "0.3";
   invulnerable = "0";
   waterDampingScale = "10";
};


// CrateSmallUnbreakable

datablock PhysicsShapeData( PSCrateSquareUnbreakable )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/crate_square_unbroken.DAE";
   
   invulnerable = 1;
   mass = "10";
   friction = "1";
   staticFriction = "0.1";
   buoyancyDensity = "0.09";
};


// CrateBig

datablock PhysicsDebrisData( CrateRectDebris )
{
   lifetime = 60.0;
   lifetimeVariance = 0.0;

   velocity = 0.1;
   velocityVariance = 0;
   
   shapeFile = "art/shapes/physicsShapes/crate_rect_broken.DAE";
   
   mass = "10";
   dynamicFriction = 0;
   staticFriction = 0.2;
   restitution = 0.0;
   linearDamping = 0.0;
   angularDamping = 0.0;
   linearSleepThreshold = 1.0;
   angularSleepThreshold = 1.0;
   waterDampingScale = 1.0;
   buoyancyDensity = "0.1";
   friction = "0";
};

datablock PhysicsShapeData( PSCrateRect )
{	
   invulnerable = 0;
   
   category = "PhysicsShape";
   
   explosion = WoodMinorExplosion;
	
   shapeName = "art/shapes/physicsShapes/crate_rect_unbroken.DAE";
   debris = CrateRectDebris;
   friction = "1";
   staticFriction = "0.1";
   buoyancyDensity = "0.1";
   destroyedShape = "";
   mass = "1";
};


// Barrel

datablock PhysicsDebrisData( BarrelDebris )
{
   lifetime = 60.0;
   lifetimeVariance = 0.0;

   velocity = 0.1;
   velocityVariance = 0;
   
   shapeFile = "art/shapes/physicsShapes/barrelblack_broken.DAE";
   
   mass = "10";
   dynamicFriction = 0;
   staticFriction = "0.1";
   restitution = 0.0;
   linearDamping = 0.0;
   angularDamping = 0.0;
   linearSleepThreshold = 1.0;
   angularSleepThreshold = 1.0;
   waterDampingScale = 1.0;
   buoyancyDensity = "0.1";
   friction = "1";
};

datablock PhysicsShapeData( PSBarrel )
{	
   invulnerable = 0;
   
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/barrelblack_unbroken.DAE";
   debris = BarrelDebris;
   mass = "10";
   friction = "1";
   staticFriction = "0.1";
   
   radiusDamage        = 0;
   damageRadius        = 0;
   areaImpulse         = 25;
   buoyancyDensity = "0.1";
};


// Pallet

datablock PhysicsDebrisData( PalletDebris )
{
   lifetime = 60.0;
   lifetimeVariance = 0.0;

   velocity = 0.1;
   velocityVariance = 0;
   
   shapeFile = "art/shapes/physicsShapes/pallet_broken.DAE";
   
   mass = "10";
   dynamicFriction = 0;
   staticFriction = "0.1";
   restitution = 0.0;
   linearDamping = 0.0;
   angularDamping = 0.0;
   linearSleepThreshold = 1.0;
   angularSleepThreshold = 1.0;
   waterDampingScale = 1.0;
   buoyancyDensity = "0.09";
   friction = "1";
};

datablock PhysicsShapeData( PSPallet )
{	
   invulnerable = 0;
   
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/pallet_unbroken.DAE";
   debris = PalletDebris;
   friction = "0.4";
   mass = "10";
   explosion = WoodMinorExplosion;
   staticFriction = "0.5";
   buoyancyDensity = "0.1";
   destroyedShape = "";
};

// Pallet Small

datablock PhysicsDebrisData( PalletDebris_Small )
{
   lifetime = 60.0;
   lifetimeVariance = 0.0;

   velocity = 0.1;
   velocityVariance = 0;
   
   shapeFile = "art/shapes/physicsShapes/palletsmall_broken.DAE";
   
   mass = "10";
   dynamicFriction = 0;
   staticFriction = "0.1";
   restitution = 0.0;
   linearDamping = 0.0;
   angularDamping = 0.0;
   linearSleepThreshold = 1.0;
   angularSleepThreshold = 1.0;
   waterDampingScale = 1.0;
   buoyancyDensity = "0.09";
   friction = "1";
};

datablock PhysicsShapeData( PSPallet_Small )
{	
   invulnerable = 0;
   
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/palletsmall_unbroken.DAE";
   debris = PalletDebris_Small;
   friction = "0.4";
   mass = "10";
   explosion = WoodMinorExplosion;
   staticFriction = "0.5";
   buoyancyDensity = "0.1";
   destroyedShape = "";
};

// Target

datablock PhysicsDebrisData( TargetDebris )
{
   lifetime = 60.0;
   lifetimeVariance = 0.0;

   velocity = 0.1;
   velocityVariance = 0;
   
   shapeFile = "art/shapes/physicsShapes/target_broken.DAE";
   
   mass = 1;
   dynamicFriction = 0;
   staticFriction = 0.0;
   restitution = 0.0;
   linearDamping = 0.0;
   angularDamping = 0.0;
   linearSleepThreshold = 1.0;
   angularSleepThreshold = 1.0;
   waterDampingScale = 1.0;
   buoyancyDensity = 0.0;
};


datablock PhysicsShapeData( PSTarget )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/target_unbroken.DAE";
   emap = 1;

   mass = 0;
   massCenter = "0 0 0";    // Center of mass for rigid body
   massBox = "0 0 0";         // Size of box used for moment of inertia,
                              // if zero it defaults to object bounding box
   drag = 0.2;                // Drag coefficient
   bodyFriction = 0.2;
   bodyRestitution = 0.1;
   minImpactSpeed = 5;        // Impacts over this invoke the script callback
   softImpactSpeed = 5;       // Play SoftImpact Sound
   hardImpactSpeed = 15;      // Play HardImpact Sound
   integration = 4;           // Physics integration: TickSec/Rate
   collisionTol = 0.1;        // Collision distance tolerance
   contactTol = 0.1;          // Contact velocity tolerance
   explosion = WoodMinorExplosion;
   minRollSpeed = 10;
   
   maxDrag = 0.5;
   minDrag = 0.01;

   triggerDustHeight = 1;
   dustHeight = 10;

   dragForce = 0.05;
   vertFactor = 0.05;

   normalForce = 0.05;
   restorativeForce = 0.05;
   rollForce = 0.05;
   pitchForce = 0.05;
   
   debris = TargetDebris;
   //Explosion = "GroundMinorExplosion";
   friction = "1";
   linearDamping = "0.1";
   angularDamping = "0.1";
   buoyancyDensity = "0.2";
   staticFriction = "0.1";
   //explosion = GroundMinorExplosion;
   
   radiusDamage        = 0;
   damageRadius        = 0;
   areaImpulse         = 0;
   restitution = "0.3";
   invulnerable = "0";
};



// BlockShortUnbreakable

datablock PhysicsShapeData( PSBlockShortUnbreakable )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/block_short.DAE";
   
   invulnerable = 1;
   mass = "3";
   friction = "10";
   staticFriction = "10";
};


// BlockTallUnbreakable

datablock PhysicsShapeData( PSBlockTallUnbreakable )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/block_tall.DAE";
   
   invulnerable = 1;
   mass = "2";
   friction = "10";
   staticFriction = "10";
};





datablock ExplosionData(SplinterExplosion)
{
   lifeTimeMS = 200; 

   // Volume
   //particleEmitter = GroundMinorVolumeEmitter;
   //particleDensity = 30;
   //particleRadius = 1.5;

   // Point emission
   emitter[0] = EmitterSplinter; 
};



// Pier Piece 1




datablock PhysicsDebrisData( PSpierpiece1debris )
{
   lifetime = 60.0;
   lifetimeVariance = 0.0;

   velocity = 0.1;
   velocityVariance = 0;
   
   shapeFile = "art/shapes/physicsShapes/pier_piece_1_broken.DAE";
   
   mass = "10";
   dynamicFriction = 0;
   staticFriction = "0.1";
   restitution = 0.0;
   linearDamping = "0";
   angularDamping = "0";
   linearSleepThreshold = 1.0;
   angularSleepThreshold = 1.0;
   waterDampingScale = "1";
   buoyancyDensity = "0.09";
   friction = "1";
};


datablock PhysicsShapeData( PSpierpiece1shape )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/pier_piece_1_unbroken.DAE";

   mass = 0;
   

   
   debris =PSpierpiece1debris;
   explosion = "SplinterExplosion";
   friction = "1";
   linearDamping = "0.1";
   angularDamping = "0.1";
   buoyancyDensity = "0.2";
   staticFriction = "0.1";
   
   restitution = "0.3";
   invulnerable = "0";
   destroyedShape = "pier_piece_1_broken";
   minDamageAmount = "1.25";
};


datablock PhysicsShapeData(pier_piece_1_broken)
{
   category = "PhysicsShape";

   shapeName = "art/shapes/physicsShapes/pier_piece_1_posts.DAE";
   invulnerable = "1";
   mass = "0";
};




// Pier Piece T-shape




datablock PhysicsDebrisData( PSpierpieceTshapedebris )
{
   lifetime = 60.0;
   lifetimeVariance = 0.0;

   velocity = 0.1;
   velocityVariance = 0;
   
   shapeFile = "art/shapes/physicsShapes/pier_piece_t_broken.DAE";
   
   mass = "10";
   dynamicFriction = 0;
   staticFriction = "0.1";
   restitution = 0.0;
   linearDamping = 0.0;
   angularDamping = 0.0;
   linearSleepThreshold = 1.0;
   angularSleepThreshold = 1.0;
   waterDampingScale = 1.0;
   buoyancyDensity = "0.09";
   friction = "1";
};


datablock PhysicsShapeData( PSpierpieceTshape )
{	
   category = "PhysicsShape";

   shapeName = "art/shapes/physicsShapes/pier_piece_t_unbroken.DAE";

   mass = "0";
   debris =PSpierpieceTshapedebris;
   explosion = "SplinterExplosion";
   friction = "0.1";
   linearDamping = "0.1";
   angularDamping = "0.1";
   buoyancyDensity = "0.2";
   staticFriction = "0.1";
   
   restitution = "0.3";
   invulnerable = "0";
   minDamageAmount = "1.25";
   destroyedShape = "pier_piece_1_broken";
   shapeFile = "art/shapes/physicsShapes/pier_piece_busted_broken.DAE";
   lifetime = "120";
   velocity = "0.1";
   velocityVariance = "0";
   dynamicFriction = "0";
};



// Pier Piece Busted shape




datablock PhysicsDebrisData( PSpierpiecebusteddebris )
{
   lifetime = 60.0;
   lifetimeVariance = 0.0;

   velocity = 0.1;
   velocityVariance = 0;
   
   shapeFile = "art/shapes/physicsShapes/pier_piece_busted_broken.DAE";
   
   mass = "10";
   dynamicFriction = 0;
   staticFriction = "0.1";
   restitution = 0.0;
   linearDamping = 0.0;
   angularDamping = 0.0;
   linearSleepThreshold = 1.0;
   angularSleepThreshold = 1.0;
   waterDampingScale = 1.0;
   buoyancyDensity = "0.08";
   friction = "1";
};


datablock PhysicsShapeData( PSpierpiecebustedshape )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/pier_piece_busted_unbroken.DAE";

   mass = 0;
   debris =PSpierpiecebusteddebris;
   explosion = "SplinterExplosion";
   friction = "0.1";
   linearDamping = "0.1";
   angularDamping = "0.1";
   buoyancyDensity = "0.2";
   staticFriction = "0.1";
   
   restitution = "0.3";
   invulnerable = "0";
   minDamageAmount = "1.25";
   destroyedShape = "pier_piece_1_broken";
};


// Watertower




datablock PhysicsDebrisData( PSwatertowerdebris )
{
   lifetime = 60.0;
   lifetimeVariance = 0.0;

   velocity = 0.1;
   velocityVariance = 0;
   
   shapeFile = "art/shapes/physicsShapes/watertower_broken.DAE";
   
   mass = 5;
   dynamicFriction = 0;
   staticFriction = 0.3;
   restitution = 0.0;
   linearDamping = 0.1;
   angularDamping = 0.1;
   linearSleepThreshold = 1.0;
   angularSleepThreshold = 1.0;
   waterDampingScale = 10;
   buoyancyDensity = 0.8;
   friction = "0.2";
};



datablock PhysicsShapeData( PSwatertower )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/watertower_unbroken.DAE";

   mass = 0;
   debris =PSwatertowerdebris;
   explosion = "SplinterExplosion";
   friction = "0.1";
   linearDamping = "0.1";
   angularDamping = "0.1";
   buoyancyDensity = "0.2";
   staticFriction = "0.1";
   
   restitution = "0.3";
   invulnerable = "0";
   minDamageAmount = "1.25";
   destroyedShape = "PSwatertower_BrokenBase";
};

datablock PhysicsShapeData( PSwatertower_BrokenBase )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/watertower_base.DAE";

   mass = 0;   
};



// covered structure 1




datablock PhysicsDebrisData( PScoveredshed1debris )
{
   lifetime = 60.0;
   lifetimeVariance = 0.0;

   velocity = 0.1;
   velocityVariance = 0;
   
   shapeFile = "art/shapes/physicsShapes/shed_1_broken.DAE";
   
   mass = 5;
   dynamicFriction = 0;
   staticFriction = 0.3;
   restitution = 0.0;
   linearDamping = 0.1;
   angularDamping = 0.1;
   linearSleepThreshold = 1.0;
   angularSleepThreshold = 1.0;
   waterDampingScale = 10;
   buoyancyDensity = 0.8;
   friction = "0.2";
};

datablock PhysicsShapeData( PScoveredshed1base )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/shed_1_base.DAE";

   mass = 0;   
   invulnerable = "1";
};

datablock PhysicsShapeData( PScoveredshed1 )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/shed_1_unbroken.DAE";

   mass = 0;
   debris =PScoveredshed1debris;
   explosion = "SplinterExplosion";
   friction = "0.1";
   linearDamping = "0.1";
   angularDamping = "0.1";
   buoyancyDensity = "0.2";
   staticFriction = "0.1";
   
   restitution = "0.3";
   invulnerable = "0";
   minDamageAmount = "1.25";
   destroyedShape = "PScoveredshed1base";
};



// covered structure 2




datablock PhysicsDebrisData( PScoveredshed2debris )
{
   lifetime = 60.0;
   lifetimeVariance = 0.0;

   velocity = 0.1;
   velocityVariance = 0;
   
   shapeFile = "art/shapes/physicsShapes/shed_2_broken.DAE";
   
   mass = 5;
   dynamicFriction = 0;
   staticFriction = 0.3;
   restitution = 0.0;
   linearDamping = 0.1;
   angularDamping = 0.1;
   linearSleepThreshold = 1.0;
   angularSleepThreshold = 1.0;
   waterDampingScale = 10;
   buoyancyDensity = 0.8;
   friction = "0.2";
};

datablock PhysicsShapeData( PScoveredshed2base )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/shed_2_base.DAE";

   mass = 0;   
   invulnerable = "1";
};


datablock PhysicsShapeData( PScoveredshed2 )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/shed_2_unbroken.DAE";

   mass = 0;
   debris =PScoveredshed2debris;
   explosion = "SplinterExplosion";
   friction = "0.1";
   linearDamping = "0.1";
   angularDamping = "0.1";
   buoyancyDensity = "0.2";
   staticFriction = "0.1";
   
   restitution = "0.3";
   invulnerable = "0";
   minDamageAmount = "1.25";
   destroyedShape = "PScoveredshed2base";
};



// covered structure 3




datablock PhysicsDebrisData( PScoveredshed3debris )
{
   lifetime = 60.0;
   lifetimeVariance = 0.0;

   velocity = 0.1;
   velocityVariance = 0;
   
   shapeFile = "art/shapes/physicsShapes/shed_3_broken.DAE";
   
   mass = 5;
   dynamicFriction = 0;
   staticFriction = 0.3;
   restitution = 0.0;
   linearDamping = 0.1;
   angularDamping = 0.1;
   linearSleepThreshold = 1.0;
   angularSleepThreshold = 1.0;
   waterDampingScale = 10;
   buoyancyDensity = 0.8;
   friction = "0.2";
};

datablock PhysicsShapeData( PScoveredshed3base )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/shed_3_base.DAE";

   mass = 0;   
   invulnerable = "1";
};

datablock PhysicsShapeData( PScoveredshed3 )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/shed_3_unbroken.DAE";

   mass = 0;
   debris =PScoveredshed3debris;
   explosion = "SplinterExplosion";
   friction = "0.1";
   linearDamping = "0.1";
   angularDamping = "0.1";
   buoyancyDensity = "0.2";
   staticFriction = "0.1";
   
   restitution = "0.3";
   invulnerable = "0";
   minDamageAmount = "1.25";
   destroyedShape = "PScoveredshed3base";
};



// covered structure 4




datablock PhysicsDebrisData( PScoveredshed4debris )
{
   lifetime = 60.0;
   lifetimeVariance = 0.0;

   velocity = 0.1;
   velocityVariance = 0;
   
   shapeFile = "art/shapes/physicsShapes/shed_4_broken.DAE";
   
   mass = 5;
   dynamicFriction = 0;
   staticFriction = 0.3;
   restitution = 0.0;
   linearDamping = 0.1;
   angularDamping = 0.1;
   linearSleepThreshold = 1.0;
   angularSleepThreshold = 1.0;
   waterDampingScale = 10;
   buoyancyDensity = 0.8;
   friction = "0.2";
};

datablock PhysicsShapeData( PScoveredshed4base )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/shed_4_base.DAE";

   mass = 0;   
   invulnerable = "1";
};

datablock PhysicsShapeData( PScoveredshed4 )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/shed_4_unbroken.DAE";

   mass = 0;
   debris =PScoveredshed4debris;
   explosion = "SplinterExplosion";
   friction = "0.1";
   linearDamping = "0.1";
   angularDamping = "0.1";
   buoyancyDensity = "0.2";
   staticFriction = "0.1";
   
   restitution = "0.3";
   invulnerable = "0";
   minDamageAmount = "1.25";
   destroyedShape = "PScoveredshed4base";
};



// fence post




datablock PhysicsDebrisData( PSfencepostdebris )
{
   lifetime = 60.0;
   lifetimeVariance = 0.0;

   velocity = 0.1;
   velocityVariance = 0;
   
   shapeFile = "art/shapes/physicsShapes/fence_post_broken.DAE";
   
   mass = 1.5;
   dynamicFriction = 0;
   staticFriction = 0.3;
   restitution = 0.0;
   linearDamping = 0.1;
   angularDamping = 0.1;
   linearSleepThreshold = 1.0;
   angularSleepThreshold = 1.0;
   waterDampingScale = 10;
   buoyancyDensity = 0.8;
   friction = "0.2";
};

datablock PhysicsShapeData( PSfencepostbase )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/fence_post_base.DAE";

   mass = 0;   
   invulnerable = "1";
};

datablock PhysicsShapeData( PSfencepost )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/fence_post_unbroken.DAE";

   mass = 0;
   debris =PSfencepostdebris;
   explosion = "SplinterExplosion";
   friction = "0.1";
   linearDamping = "0.1";
   angularDamping = "0.1";
   buoyancyDensity = "0.2";
   staticFriction = "0.1";
   
   restitution = "0.3";
   invulnerable = "0";
   minDamageAmount = "1.25";
   destroyedShape = "PSfencepostbase";
};



// fence 1 broken state A




datablock PhysicsDebrisData( PSfence1Adebris )
{
   lifetime = 60.0;
   lifetimeVariance = 0.0;

   velocity = 0.1;
   velocityVariance = 0;
   
   shapeFile = "art/shapes/physicsShapes/fence_1_bkstate_a.DAE";
   
   mass = 1.5;
   dynamicFriction = 0;
   staticFriction = 0.3;
   restitution = 0.0;
   linearDamping = 0.1;
   angularDamping = 0.1;
   linearSleepThreshold = 1.0;
   angularSleepThreshold = 1.0;
   waterDampingScale = 10;
   buoyancyDensity = 0.8;
   friction = "0.2";
};



datablock PhysicsShapeData( PSfence1A )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/fence_1_unbk.DAE";

   mass = 0;
   debris =PSfence1Adebris;
   explosion = "SplinterExplosion";
   friction = "0.1";
   linearDamping = "0.1";
   angularDamping = "0.1";
   buoyancyDensity = "0.2";
   staticFriction = "0.1";
   
   restitution = "0.3";
   invulnerable = "0";
   minDamageAmount = "0.5";
   destroyedShape = "PSfence1B";
};



// fence 1 broken state B




datablock PhysicsDebrisData( PSfence1Bdebris )
{
   lifetime = 60.0;
   lifetimeVariance = 0.0;

   velocity = 0.1;
   velocityVariance = 0;
   
   shapeFile = "art/shapes/physicsShapes/fence_1_bkstate_b.DAE";
   
   mass = 1.5;
   dynamicFriction = 0;
   staticFriction = 0.3;
   restitution = 0.0;
   linearDamping = 0.1;
   angularDamping = 0.1;
   linearSleepThreshold = 1.0;
   angularSleepThreshold = 1.0;
   waterDampingScale = 10;
   buoyancyDensity = 0.8;
   friction = "0.2";
};

datablock PhysicsShapeData( PSfence1baseB )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/fence_1_bkbase_b.DAE";

   mass = 0;   
   invulnerable = "1";
};

datablock PhysicsShapeData( PSfence1B )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/fence_1_bkbase_a.DAE";

   mass = 0;
   debris =PSfence1Bdebris;
   explosion = "SplinterExplosion";
   friction = "0.1";
   linearDamping = "0.1";
   angularDamping = "0.1";
   buoyancyDensity = "0.2";
   staticFriction = "0.1";
   
   restitution = "0.3";
   invulnerable = "0";
   minDamageAmount = "1.25";
   destroyedShape = "PSfence1baseB";
};



// fence 2 broken state A




datablock PhysicsDebrisData( PSfence2Adebris )
{
   lifetime = 60.0;
   lifetimeVariance = 0.0;

   velocity = 0.1;
   velocityVariance = 0;
   
   shapeFile = "art/shapes/physicsShapes/fence_2_bkstate_a.DAE";
   
   mass = 1.5;
   dynamicFriction = 0;
   staticFriction = 0.3;
   restitution = 0.0;
   linearDamping = 0.1;
   angularDamping = 0.1;
   linearSleepThreshold = 1.0;
   angularSleepThreshold = 1.0;
   waterDampingScale = 10;
   buoyancyDensity = 0.8;
   friction = "0.2";
};



datablock PhysicsShapeData( PSfence2A )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/fence_2_unbk.DAE";

   mass = 0;
   debris =PSfence2Adebris;
   explosion = "SplinterExplosion";
   friction = "0.1";
   linearDamping = "0.1";
   angularDamping = "0.1";
   buoyancyDensity = "0.2";
   staticFriction = "0.1";
   
   restitution = "0.3";
   invulnerable = "0";
   minDamageAmount = "0.5";
   destroyedShape = "PSfence2B";
};



// fence 2 broken state B




datablock PhysicsDebrisData( PSfence2Bdebris )
{
   lifetime = 60.0;
   lifetimeVariance = 0.0;

   velocity = 0.1;
   velocityVariance = 0;
   
   shapeFile = "art/shapes/physicsShapes/fence_2_bkstate_b.DAE";
   
   mass = 1.5;
   dynamicFriction = 0;
   staticFriction = 0.3;
   restitution = 0.0;
   linearDamping = 0.1;
   angularDamping = 0.1;
   linearSleepThreshold = 1.0;
   angularSleepThreshold = 1.0;
   waterDampingScale = 10;
   buoyancyDensity = 0.8;
   friction = "0.2";
};

datablock PhysicsShapeData( PSfence2baseB )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/fence_2_bkbase_b.DAE";

   mass = 0;   
   invulnerable = "1";
};

datablock PhysicsShapeData( PSfence2B )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/fence_2_bkbase_a.DAE";

   mass = 0;
   debris =PSfence2Bdebris;
   explosion = "SplinterExplosion";
   friction = "0.1";
   linearDamping = "0.1";
   angularDamping = "0.1";
   buoyancyDensity = "0.2";
   staticFriction = "0.1";
   
   restitution = "0.3";
   invulnerable = "0";
   minDamageAmount = "1.25";
   destroyedShape = "PSfence2baseB";
};


// fence 3 broken state A




datablock PhysicsDebrisData( PSfence3Adebris )
{
   lifetime = 60.0;
   lifetimeVariance = 0.0;

   velocity = 0.1;
   velocityVariance = 0;
   
   shapeFile = "art/shapes/physicsShapes/fence_3_bkstate_a.DAE";
   
   mass = 1.5;
   dynamicFriction = 0;
   staticFriction = 0.3;
   restitution = 0.0;
   linearDamping = 0.1;
   angularDamping = 0.1;
   linearSleepThreshold = 1.0;
   angularSleepThreshold = 1.0;
   waterDampingScale = 10;
   buoyancyDensity = 0.8;
   friction = "0.2";
};



datablock PhysicsShapeData( PSfence3A )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/fence_3_unbk.DAE";

   mass = 0;
   debris =PSfence3Adebris;
   explosion = "SplinterExplosion";
   friction = "0.1";
   linearDamping = "0.1";
   angularDamping = "0.1";
   buoyancyDensity = "0.2";
   staticFriction = "0.1";
   
   restitution = "0.3";
   invulnerable = "0";
   minDamageAmount = "0.5";
   destroyedShape = "PSfence3B";
};



// fence 3 broken state B




datablock PhysicsDebrisData( PSfence3Bdebris )
{
   lifetime = 60.0;
   lifetimeVariance = 0.0;

   velocity = 0.1;
   velocityVariance = 0;
   
   shapeFile = "art/shapes/physicsShapes/fence_3_bkstate_b.DAE";
   
   mass = 1.5;
   dynamicFriction = 0;
   staticFriction = 0.3;
   restitution = 0.0;
   linearDamping = 0.1;
   angularDamping = 0.1;
   linearSleepThreshold = 1.0;
   angularSleepThreshold = 1.0;
   waterDampingScale = 10;
   buoyancyDensity = 0.8;
   friction = "0.2";
};

datablock PhysicsShapeData( PSfence3baseB )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/fence_3_bkbase_b.DAE";

   mass = 0;   
   invulnerable = "1";
};

datablock PhysicsShapeData( PSfence3B )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/fence_3_bkbase_a.DAE";

   mass = 0;
   debris =PSfence3Bdebris;
   explosion = "SplinterExplosion";
   friction = "0.1";
   linearDamping = "0.1";
   angularDamping = "0.1";
   buoyancyDensity = "0.2";
   staticFriction = "0.1";
   
   restitution = "0.3";
   invulnerable = "0";
   minDamageAmount = "1.25";
   destroyedShape = "PSfence3baseB";
};











// Shrine Column A




datablock PhysicsDebrisData( PScolumnAdebris )
{
   lifetime = 60.0;
   lifetimeVariance = 0.0;

   velocity = 0.1;
   velocityVariance = 0;
   
   shapeFile = "art/shapes/physicsShapes/shrine_column_A_bk.DAE";
   
   mass = 15;
   dynamicFriction = 0;
   staticFriction = 0.3;
   restitution = 0.0;
   linearDamping = 0.1;
   angularDamping = 0.1;
   linearSleepThreshold = 1.0;
   angularSleepThreshold = 1.0;
   waterDampingScale = 10;
   buoyancyDensity = 0.8;
   friction = "0.2";
};

datablock PhysicsShapeData( PScolumnAbase )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/shrine_column_A_base.DAE";

   mass = 0;   
   invulnerable = "1";
};


datablock PhysicsShapeData( PScolumnA )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/shrine_column_A_unbk.DAE";

   mass = 0;
   debris =PScolumnAdebris;
   explosion = "SplinterExplosion";
   friction = "0.1";
   linearDamping = "0.1";
   angularDamping = "0.1";
   buoyancyDensity = "0.2";
   staticFriction = "0.1";
   
   restitution = "0.3";
   invulnerable = "0";
   minDamageAmount = "1.25";
   destroyedShape = "PScolumnAbase";
};



// Shrine Column B




datablock PhysicsDebrisData( PScolumnBdebris )
{
   lifetime = 60.0;
   lifetimeVariance = 0.0;

   velocity = 0.1;
   velocityVariance = 0;
   
   shapeFile = "art/shapes/physicsShapes/shrine_column_B_bk.DAE";
   
   mass = 10;
   dynamicFriction = 0;
   staticFriction = 0.3;
   restitution = 0.0;
   linearDamping = 0.1;
   angularDamping = 0.1;
   linearSleepThreshold = 1.0;
   angularSleepThreshold = 1.0;
   waterDampingScale = 10;
   buoyancyDensity = 0.8;
   friction = "0.2";
};

datablock PhysicsShapeData( PScolumnBbase )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/shrine_column_B_base.DAE";

   mass = 0;   
   invulnerable = "1";
};


datablock PhysicsShapeData( PScolumnB )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/shrine_column_B_unbk.DAE";

   mass = 0;
   debris =PScolumnBdebris;
   explosion = "SplinterExplosion";
   friction = "0.1";
   linearDamping = "0.1";
   angularDamping = "0.1";
   buoyancyDensity = "0.2";
   staticFriction = "0.1";
   
   restitution = "0.3";
   invulnerable = "0";
   minDamageAmount = "1.25";
   destroyedShape = "PScolumnBbase";
};




// Shrine Column C




datablock PhysicsDebrisData( PScolumnCdebris )
{
   lifetime = 60.0;
   lifetimeVariance = 0.0;

   velocity = 0.1;
   velocityVariance = 0;
   
   shapeFile = "art/shapes/physicsShapes/shrine_column_C_bk.DAE";
   
   mass = 10;
   dynamicFriction = 0;
   staticFriction = 0.3;
   restitution = 0.0;
   linearDamping = 0.1;
   angularDamping = 0.1;
   linearSleepThreshold = 1.0;
   angularSleepThreshold = 1.0;
   waterDampingScale = 10;
   buoyancyDensity = 0.8;
   friction = "0.2";
};

datablock PhysicsShapeData( PScolumnCbase )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/shrine_column_C_base.DAE";

   mass = 0;   
   invulnerable = "1";
};


datablock PhysicsShapeData( PScolumnC )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/shrine_column_C_unbk.DAE";

   mass = 0;
   debris =PScolumnCdebris;
   explosion = "SplinterExplosion";
   friction = "0.1";
   linearDamping = "0.1";
   angularDamping = "0.1";
   buoyancyDensity = "0.2";
   staticFriction = "0.1";
   
   restitution = "0.3";
   invulnerable = "0";
   minDamageAmount = "1.25";
   destroyedShape = "PScolumnCbase";
};



// Shrine Column D




datablock PhysicsDebrisData( PScolumnDdebris )
{
   lifetime = 60.0;
   lifetimeVariance = 0.0;

   velocity = 0.1;
   velocityVariance = 0;
   
   shapeFile = "art/shapes/physicsShapes/shrine_column_D_bk.DAE";
   
   mass = 20;
   dynamicFriction = 0;
   staticFriction = 0.3;
   restitution = 0.0;
   linearDamping = 0.1;
   angularDamping = 0.1;
   linearSleepThreshold = 1.0;
   angularSleepThreshold = 1.0;
   waterDampingScale = 10;
   buoyancyDensity = 0.8;
   friction = "0.2";
};

datablock PhysicsShapeData( PScolumnDbase )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/shrine_column_D_base.DAE";

   mass = 0;   
   invulnerable = "1";
};


datablock PhysicsShapeData( PScolumnD )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/shrine_column_D_unbk.DAE";

   mass = 0;
   debris =PScolumnDdebris;
   explosion = "SplinterExplosion";
   friction = "0.1";
   linearDamping = "0.1";
   angularDamping = "0.1";
   buoyancyDensity = "0.2";
   staticFriction = "0.1";
   
   restitution = "0.3";
   invulnerable = "0";
   minDamageAmount = "1.25";
   destroyedShape = "PScolumnDbase";
};



// Shrine Column E




datablock PhysicsDebrisData( PScolumnEdebris )
{
   lifetime = 60.0;
   lifetimeVariance = 0.0;

   velocity = 0.1;
   velocityVariance = 0;
   
   shapeFile = "art/shapes/physicsShapes/shrine_column_E_bk.DAE";
   
   mass = 20;
   dynamicFriction = 0;
   staticFriction = 0.3;
   restitution = 0.0;
   linearDamping = 0.1;
   angularDamping = 0.1;
   linearSleepThreshold = 1.0;
   angularSleepThreshold = 1.0;
   waterDampingScale = 10;
   buoyancyDensity = 0.8;
   friction = "0.2";
};

datablock PhysicsShapeData( PScolumnEbase )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/shrine_column_E_base.DAE";

   mass = 0;   
   invulnerable = "1";
};


datablock PhysicsShapeData( PScolumnE )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/shrine_column_E_unbk.DAE";

   mass = 0;
   debris =PScolumnEdebris;
   explosion = "SplinterExplosion";
   friction = "0.1";
   linearDamping = "0.1";
   angularDamping = "0.1";
   buoyancyDensity = "0.2";
   staticFriction = "0.1";
   
   restitution = "0.3";
   invulnerable = "0";
   minDamageAmount = "1.25";
   destroyedShape = "PScolumnEbase";
};




// Shrine Robot




datablock PhysicsDebrisData( PSrobotdebris )
{
   lifetime = 60.0;
   lifetimeVariance = 0.0;

   velocity = 0.1;
   velocityVariance = 0;
   
   shapeFile = "art/shapes/physicsShapes/shrine_robot_bk.DAE";
   
   mass = 20;
   dynamicFriction = 0;
   staticFriction = 0.3;
   restitution = 0.0;
   linearDamping = 0.1;
   angularDamping = 0.1;
   linearSleepThreshold = 1.0;
   angularSleepThreshold = 1.0;
   waterDampingScale = 10;
   buoyancyDensity = 0.8;
   friction = "0.2";
};

datablock PhysicsShapeData( PSrobotbase )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/shrine_robot_base.DAE";

   mass = 0;   
   invulnerable = "1";
};


datablock PhysicsShapeData( PSrobot )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/shrine_robot_unbk.DAE";

   mass = 0;
   debris =PSrobotdebris;
   explosion = "SplinterExplosion";
   friction = "0.1";
   linearDamping = "0.1";
   angularDamping = "0.1";
   buoyancyDensity = "0.2";
   staticFriction = "0.1";
   
   restitution = "0.3";
   invulnerable = "0";
   minDamageAmount = "1.25";
   destroyedShape = "PSrobotbase";
};









// Shrine Bowl A




datablock PhysicsDebrisData( PSbowlAdebris )
{
   lifetime = 60.0;
   lifetimeVariance = 0.0;

   velocity = 0.1;
   velocityVariance = 0;
   
   shapeFile = "art/shapes/physicsShapes/shrine_bowl_A_bk.DAE";
   
   mass = 20;
   dynamicFriction = 0;
   staticFriction = 0.3;
   restitution = 0.0;
   linearDamping = 0.1;
   angularDamping = 0.1;
   linearSleepThreshold = 1.0;
   angularSleepThreshold = 1.0;
   waterDampingScale = 10;
   buoyancyDensity = 0.8;
   friction = "0.2";
};

datablock PhysicsShapeData( PSbowlAbase )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/shrine_bowl_A_base.DAE";

   mass = 0;   
   invulnerable = "1";
};


datablock PhysicsShapeData( PSbowlA )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/shrine_bowl_A_unbk.DAE";

   mass = 0;
   debris =PSbowlAdebris;
   explosion = "SplinterExplosion";
   friction = "0.1";
   linearDamping = "0.1";
   angularDamping = "0.1";
   buoyancyDensity = "0.2";
   staticFriction = "0.1";
   
   restitution = "0.3";
   invulnerable = "0";
   minDamageAmount = "1.25";
   destroyedShape = "PSbowlAbase";
};








// Shrine Bowl B




datablock PhysicsDebrisData( PSbowlBdebris )
{
   lifetime = 60.0;
   lifetimeVariance = 0.0;

   velocity = 0.1;
   velocityVariance = 0;
   
   shapeFile = "art/shapes/physicsShapes/shrine_bowl_B_bk.DAE";
   
   mass = 20;
   dynamicFriction = 0;
   staticFriction = 0.3;
   restitution = 0.0;
   linearDamping = 0.1;
   angularDamping = 0.1;
   linearSleepThreshold = 1.0;
   angularSleepThreshold = 1.0;
   waterDampingScale = 10;
   buoyancyDensity = 0.8;
   friction = "0.2";
};

datablock PhysicsShapeData( PSbowlBbase )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/shrine_bowl_B_base.DAE";

   mass = 0;   
   invulnerable = "1";
};


datablock PhysicsShapeData( PSbowlB )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/shrine_bowl_B_unbk.DAE";

   mass = 0;
   debris =PSbowlBdebris;
   explosion = "SplinterExplosion";
   friction = "0.1";
   linearDamping = "0.1";
   angularDamping = "0.1";
   buoyancyDensity = "0.2";
   staticFriction = "0.1";
   
   restitution = "0.3";
   invulnerable = "0";
   minDamageAmount = "1.25";
   destroyedShape = "PSbowlBbase";
};




// Shrine Ledge




datablock PhysicsDebrisData( PSledgedebris )
{
   lifetime = 60.0;
   lifetimeVariance = 0.0;

   velocity = 0.1;
   velocityVariance = 0;
   
   shapeFile = "art/shapes/physicsShapes/shrine_ledge_bk.DAE";
   
   mass = 85;
   dynamicFriction = 0;
   staticFriction = 0.3;
   restitution = 0.0;
   linearDamping = 0.1;
   angularDamping = 0.1;
   linearSleepThreshold = 1.0;
   angularSleepThreshold = 1.0;
   waterDampingScale = 10;
   buoyancyDensity = 0.8;
   friction = "0.2";
};

datablock PhysicsShapeData( PSledgebase )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/shrine_ledge_base.DAE";

   mass = 0;   
   invulnerable = "1";
};


datablock PhysicsShapeData( PSledge )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/shrine_ledge_unbk.DAE";

   mass = 0;
   debris =PSledgedebris;
   explosion = "SplinterExplosion";
   friction = "0.1";
   linearDamping = "0.1";
   angularDamping = "0.1";
   buoyancyDensity = "0.2";
   staticFriction = "0.1";
   
   restitution = "0.3";
   invulnerable = "0";
   minDamageAmount = "1.25";
   destroyedShape = "PSledgebase";
};





// Bridge



datablock PhysicsDebrisData( PSbridgedebris )
{
   lifetime = 60.0;
   lifetimeVariance = 0.0;

   velocity = 0.1;
   velocityVariance = 0;
   
   shapeFile = "art/shapes/physicsShapes/bridge_bk.DAE";
   
   mass = 85;
   dynamicFriction = 0;
   staticFriction = 0.3;
   restitution = 0.0;
   linearDamping = 0.1;
   angularDamping = 0.1;
   linearSleepThreshold = 1.0;
   angularSleepThreshold = 1.0;
   waterDampingScale = 10;
   buoyancyDensity = 0.8;
   friction = "0.2";
};

datablock PhysicsShapeData( PSbridgebase )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/bridge_base.DAE";

   mass = 0;   
   invulnerable = "1";
};


datablock PhysicsShapeData( PSbridge )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/bridge_unbk.DAE";

   mass = 0;
   debris =PSbridgedebris;
   explosion = "SplinterExplosion";
   friction = "0.1";
   linearDamping = "0.1";
   angularDamping = "0.1";
   buoyancyDensity = "0.2";
   staticFriction = "0.1";
   
   restitution = "0.3";
   invulnerable = "0";
   minDamageAmount = "1.25";
   destroyedShape = "PSbridgebase";
};




// Red Barrel

datablock PhysicsDebrisData( RedBarrelDebris )
{
   lifetime = 60.0;
   lifetimeVariance = 0.0;

   velocity = 0.1;
   velocityVariance = 0;
   
   shapeFile = "art/shapes/physicsShapes/barrelred_bk.DAE";
   
   mass = "10";
   dynamicFriction = 0;
   staticFriction = "0.1";
   restitution = 0.0;
   linearDamping = 0.0;
   angularDamping = 0.0;
   linearSleepThreshold = 1.0;
   angularSleepThreshold = 1.0;
   waterDampingScale = 1.0;
   buoyancyDensity = "0.5";
   friction = "1";
};

datablock PhysicsShapeData( PSRedBarrel )
{	
   invulnerable = 0;
   
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/barrelred_unbk.DAE";
   debris = RedBarrelDebris;
   mass = "50";
   friction = "1";
   staticFriction = "0.1";
   
   radiusDamage        = 0;
   damageRadius        = 8;
   areaImpulse         = 25;
   buoyancyDensity = "0.1";
   Explosion = "RocketLauncherExplosion";
};



















// Beached Boat state A




datablock PhysicsDebrisData( PSboatAdebris )
{
   lifetime = 60.0;
   lifetimeVariance = 0.0;

   velocity = 0.1;
   velocityVariance = 0;
   
   shapeFile = "art/shapes/physicsShapes/beached_boat_bk_a.DAE";
   
   mass = 1.5;
   dynamicFriction = 0;
   staticFriction = 0.3;
   restitution = 0.0;
   linearDamping = 0.1;
   angularDamping = 0.1;
   linearSleepThreshold = 1.0;
   angularSleepThreshold = 1.0;
   waterDampingScale = 10;
   buoyancyDensity = 0.8;
   friction = "0.2";
};



datablock PhysicsShapeData( PSboatA )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/beached_boat_unbk.DAE";

   mass = 0;
   debris =PSboatAdebris;
   explosion = "SplinterExplosion";
   friction = "0.1";
   linearDamping = "0.1";
   angularDamping = "0.1";
   buoyancyDensity = "0.2";
   staticFriction = "0.1";
   
   restitution = "0.3";
   invulnerable = "0";
   minDamageAmount = "1.25";
   destroyedShape = "PSboatB";
};



// Beached Boat state B




datablock PhysicsDebrisData( PSboatBdebris )
{
   lifetime = 60.0;
   lifetimeVariance = 0.0;

   velocity = 0.1;
   velocityVariance = 0;
   
   shapeFile = "art/shapes/physicsShapes/beached_boat_bk_b.DAE";
   
   mass = 1.5;
   dynamicFriction = 0;
   staticFriction = 0.3;
   restitution = 0.0;
   linearDamping = 0.1;
   angularDamping = 0.1;
   linearSleepThreshold = 1.0;
   angularSleepThreshold = 1.0;
   waterDampingScale = 10;
   buoyancyDensity = 0.8;
   friction = "0.2";
};

datablock PhysicsShapeData( PSboatbaseB )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/beached_boat_base_b.DAE";

   mass = 0;   
   invulnerable = "1";
};

datablock PhysicsShapeData( PSboatB )
{	
   category = "PhysicsShape";
	
   shapeName = "art/shapes/physicsShapes/beached_boat_base_a.DAE";

   mass = 0;
   debris =PSboatBdebris;
   explosion = "SplinterExplosion";
   friction = "0.1";
   linearDamping = "0.1";
   angularDamping = "0.1";
   buoyancyDensity = "0.2";
   staticFriction = "0.1";
   
   restitution = "0.3";
   invulnerable = "0";
   minDamageAmount = "1.25";
   destroyedShape = "PSboatbaseB";
};


