//-----------------------------------------------------------------------------
// Copyright (C) Sickhead Games, LLC
//-----------------------------------------------------------------------------

singleton Material(pallet_wood_material)
{
   mapTo = "pallet_wood";  
   baseTex[0] = "";
   bumpTex[0] = "";
   overlayTex[0] = "";

//   detailTex[0] = "crate_diffuse_transparency.png";
//   detailScale[0] = "11 16";
//   detailBumpMap[0] = true;

   pixelSpecular = 1;
   specular = "1 1 1 0";
   specularPower = 20;
   diffuseMap[0] = "crate_diffuse_transparency.dds";
   overlayMap[0] = "crate_diffuse_transparency.dds";
   normalMap[0] = "crate_normal_specular.dds";
   materialTag0 = "Prop";
   backlight = "1";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   specularMap[0] = "art/shapes/physicsShapes/crate_specular.dds";

};

singleton Material(barrel_black)
{
   mapTo = "barrel_black";  
   baseTex[0] = "";
   bumpTex[0] = "";

   detailTex[0] = "";
   detailScale[0] = "11 16";
// detail scale = horizrepeat vertrepeat
//   detailBumpMap[0] = true;

   pixelSpecular = 0;
   specular = "1 1 1 0";
   specularPower = 6;
   diffuseMap[0] = "art/shapes/props/barrels/barreblack_diffuse_transparency.dds";
   detailMap[0] = "";
   normalMap[0] = "art/shapes/props/barrels/barreblack_normal_specular.dds";
   materialTag0 = "Prop";
   detailNormalMap[0] = "art/shapes/props/barrels/barrel_detailnormal.dds";
   specularMap[0] = "art/shapes/props/barrels/barreblack_specular.dds";
   materialTag1 = "Vegetation";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   backlight = "1";

};


singleton Material(block_short_material)
{
	mapTo = "shrinerocks";

	diffuseMap[0] = "art/shapes/props/blocks/blockflat_diffuse.dds";
	normalMap[0] = "art/shapes/props/blocks/block_normal.dds";
	specularMap[0] = "art/shapes/props/blocks/block_specular.dds";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 81;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   pixelSpecular[0] = "0";
   materialTag0 = "Rock";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   backlight = "1";
};



//--- pier_piece_1_posts.DAE MATERIALS BEGIN ---
singleton Material(pier_piece_1_posts_pier_material)
{
	mapTo = "pier_material";

	diffuseMap[0] = "art/shapes/physicsShapes/tex_pier_dif.dds";
	normalMap[0] = "art/shapes/physicsShapes/tex_pier_nrm.dds";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "61";
   materialTag0 = "Structure";
   backlight = "1";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
};



//--- watertower_broken.DAE MATERIALS END ---


singleton Material(watertower_material)
{
	mapTo = "tex_watertower";

	diffuseMap[0] = "art/shapes/physicsShapes/tex_watertower_dif.dds";
	normalMap[0] = "art/shapes/physicsShapes/tex_watertower_nrm.dds";
	specularMap[0] = "art/shapes/physicsShapes/tex_watertower_spc.dds";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 1;

	doubleSided = false;
	translucent = true;
	translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "114";
   pixelSpecular[0] = "0";
   materialTag1 = "Vegetation";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   materialTag0 = "Prop";
   backlight = "1";
};


//--- shed_1_unbroken.DAE MATERIALS BEGIN ---
singleton Material(shed_1_unbroken_tex_covered_structure)
{
	mapTo = "tex_covered_structure";

	diffuseMap[0] = "art/shapes/physicsShapes/tex_covered_structure_dif.dds";
	normalMap[0] = "art/shapes/physicsShapes/tex_covered_structure_nrm.dds";
	specularMap[0] = "art/shapes/physicsShapes/tex_covered_structure_spc.dds";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "1 1 1 1";
	specularPower[0] = 31;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   pixelSpecular[0] = "0";
   alphaTest = "1";
   alphaRef = "60";
   materialTag0 = "Structure";
   materialTag1 = "Vegetation";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   backlight = "1";
};


//--- shed_1_unbroken.DAE MATERIALS END ---

//--- fence_post_base.DAE MATERIALS BEGIN ---
singleton Material(fence_post_base_tex_fence)
{
	mapTo = "tex_fence";

	diffuseMap[0] = "art/shapes/physicsShapes/tex_fence_dif.dds";
	normalMap[0] = "art/shapes/physicsShapes/tex_fence_nrm.dds";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "1 1 1 1";
	specularPower[0] = 8;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "100";
   materialTag0 = "Structure";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   backlight = "1";
};

//--- fence_post_base.DAE MATERIALS END ---

singleton Material(tex_shrine_material)
{
	mapTo = "tex_shrine";

	diffuseMap[0] = "art/shapes/physicsShapes/tex_temple_ruins_dif.dds";
	normalMap[0] = "art/shapes/physicsShapes/tex_temple_ruins_nrm.dds";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "73";
   materialTag0 = "Structure";
};


singleton Material(tex_shrine_detail_material)
{
	mapTo = "tex_shrine_detail";

	diffuseMap[0] = "art/shapes/physicsShapes/tex_temple_ruins_detail_dif.dds";
	normalMap[0] = "art/shapes/physicsShapes/tex_temple_ruins_detail_nrm.dds";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "1 1 1 1";
	specularPower[0] = 8;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "LerpAlpha";
   materialTag0 = "Structure";
   materialTag1 = "Vegetation";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   backlight = "1";
};

//--- shrine_bowl_A_unbk.DAE MATERIALS END ---


//--- bridge_base.DAE MATERIALS BEGIN ---
singleton Material(bridge_base_tex_bridge)
{
	mapTo = "tex_bridge";

	diffuseMap[0] = "art/shapes/physicsShapes/tex_bridge_dif.dds";
	normalMap[0] = "art/shapes/physicsShapes/tex_bridge_nrm.dds";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   materialTag0 = "Structure";
   alphaTest = "1";
   alphaRef = "73";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   backlight = "1";
};

//--- bridge_base.DAE MATERIALS END ---

//--- barrel_unbk.DAE MATERIALS BEGIN ---


singleton Material(barrel_unbk_tex_barrel__barrelunbroken200_)
{
	mapTo = "tex_barrel__barrelunbroken200_";

	diffuseMap[0] = "art/shapes/physicsShapes/tex_barrel_dif";
	normalMap[0] = "art/shapes/physicsShapes/tex_barrel_nrm.dds";
	specularMap[0] = "art/shapes/physicsShapes/tex_barrel_spc.dds";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 4;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   materialTag0 = "Prop";
   pixelSpecular[0] = "0";
   detailScale[0] = "28 28";
   detailNormalMap[0] = "art/shapes/props/barrels/barrel_detailnormal.dds";
   detailNormalMapStrength[0] = "1.2";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   backlight = "1";
};

//--- barrel_unbk.DAE MATERIALS END ---

//--- barrel_bk.DAE MATERIALS BEGIN ---
singleton Material(barrel_bk_tex_barrel)
{
	mapTo = "tex_barrel";

	diffuseMap[0] = "art/shapes/physicsShapes/tex_barrel_bk_dif.dds";
	normalMap[0] = "art/shapes/physicsShapes/tex_barrel_nrm.dds";
	specularMap[0] = "art/shapes/physicsShapes/tex_barrel_spc.dds";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 6;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   materialTag0 = "Prop";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   backlight = "1";
};

//--- barrel_bk.DAE MATERIALS END ---

//--- barrelred_bk.DAE MATERIALS BEGIN ---


singleton Material(barrelred_bk_tex_barrel_bk)
{
	mapTo = "tex_barrel_bk";

	diffuseMap[0] = "tex_barrel_bk_dif";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
};

//--- barrelred_bk.DAE MATERIALS END ---

//--- beached_boat_bk_a.DAE MATERIALS BEGIN ---
singleton Material(beached_boat_bk_a_tex_windows)
{
	mapTo = "tex_windows";

	diffuseMap[0] = "art/shapes/physicsShapes/tex_boat_windows_dif";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   cubemap = "NewLevelSkyCubemap";
   materialTag0 = "Prop";
};

//--- beached_boat_bk_a.DAE MATERIALS END ---

//--- beached_boat_unbk.DAE MATERIALS BEGIN ---
singleton Material(beached_boat_unbk_tex_boat)
{
	mapTo = "tex_boat";

	diffuseMap[0] = "art/shapes/physicsShapes/tex_boat_dif";
	normalMap[0] = "art/shapes/physicsShapes/tex_boat_nrm.dds";
	specularMap[0] = "art/shapes/physicsShapes/tex_boat_spc";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "1 1 1 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   materialTag0 = "Prop";
};



singleton Material(palletsmall_unbroken_ColorEffectR213G154B229_material)
{
   mapTo = "ColorEffectR213G154B229-material";
   diffuseColor[0] = "0.835294 0.603922 0.898039 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(palletsmall_unbroken_pallet_wood_material)
{
   mapTo = "pallet_wood_material";
   diffuseMap[0] = "crate_diffuse_transparency";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(palletsmall_broken_ColorEffectR225G88B199_material)
{
   mapTo = "ColorEffectR225G88B199-material";
   diffuseColor[0] = "0.882353 0.345098 0.780392 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(barrelblack_unbroken_ColorEffectR154G185B229_material)
{
   mapTo = "ColorEffectR154G185B229-material";
   diffuseColor[0] = "0.603922 0.72549 0.898039 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(barrelblack_unbroken_ColorEffectR148G177B26_material)
{
   mapTo = "ColorEffectR148G177B26-material";
   diffuseColor[0] = "0.580392 0.694118 0.101961 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(crate_rect_broken_ColorEffectR57G8B136_material)
{
   mapTo = "ColorEffectR57G8B136-material";
   diffuseColor[0] = "0.223529 0.0313726 0.533333 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(crate_rect_broken_ColorEffectR225G143B87_material)
{
   mapTo = "ColorEffectR225G143B87-material";
   diffuseColor[0] = "0.882353 0.560784 0.341177 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(crate_rect_unbroken_ColorEffectR145G28B177_material)
{
   mapTo = "ColorEffectR145G28B177-material";
   diffuseColor[0] = "0.568627 0.109804 0.694118 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(crate_square_broken_ColorEffectR153G228B184_material)
{
   mapTo = "ColorEffectR153G228B184-material";
   diffuseColor[0] = "0.6 0.894118 0.721569 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   effectColor[0] = "InvisibleBlack";
};

singleton Material(crate_square_broken_ColorEffectR8G61B138_material)
{
   mapTo = "ColorEffectR8G61B138-material";
   diffuseColor[0] = "0.0313726 0.239216 0.541176 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(pallet_broken_ColorEffectR143G225B87_material)
{
   mapTo = "ColorEffectR143G225B87-material";
   diffuseColor[0] = "0.560784 0.882353 0.341177 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(target_broken_ColorEffectR28G89B177_material)
{
   mapTo = "ColorEffectR28G89B177-material";
   diffuseColor[0] = "0.109804 0.34902 0.694118 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(target_broken_ColorEffectR198G224B87_material)
{
   mapTo = "ColorEffectR198G224B87-material";
   diffuseColor[0] = "0.776471 0.878431 0.341177 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(target_broken_ColorEffectR87G224B87_material)
{
   mapTo = "ColorEffectR87G224B87-material";
   diffuseColor[0] = "0.341177 0.878431 0.341177 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(target_broken_pier_wood)
{
   mapTo = "pier_wood";
   diffuseMap[0] = "pier_diffuse_transparency";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(target_broken_beam)
{
   mapTo = "beam";
   diffuseMap[0] = "post_diffuse";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(target_broken_ColorEffectR224G86B86_material)
{
   mapTo = "ColorEffectR224G86B86-material";
   diffuseColor[0] = "0.878431 0.337255 0.337255 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(pier_piece_t_broken_ColorEffectR88G177B27_material)
{
   mapTo = "ColorEffectR88G177B27-material";
   diffuseColor[0] = "0.345098 0.694118 0.105882 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(pier_piece_busted_broken_ColorEffectR108G8B136_material)
{
   mapTo = "ColorEffectR108G8B136-material";
   diffuseColor[0] = "0.423529 0.0313726 0.533333 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(watertower_broken_ColorEffectR227G153B153_material)
{
   mapTo = "ColorEffectR227G153B153-material";
   diffuseColor[0] = "0.890196 0.6 0.6 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(shrine_column_A_bk_ColorEffectR138G8B110_material)
{
   mapTo = "ColorEffectR138G8B110-material";
   diffuseColor[0] = "0.541176 0.0313726 0.431373 1";
   specular[2] = "1 1 1 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(shrine_column_A_bk_ColorEffectR6G135B58_material)
{
   mapTo = "ColorEffectR6G135B58-material";
   diffuseColor[0] = "0.0235294 0.529412 0.227451 1";
   specular[2] = "1 1 1 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(shrine_column_A_bk_ColorEffectR88G199B225_material)
{
   mapTo = "ColorEffectR88G199B225-material";
   diffuseColor[0] = "0.345098 0.780392 0.882353 1";
   specular[2] = "1 1 1 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(shrine_column_A_bk_ColorEffectR87G225B87_material)
{
   mapTo = "ColorEffectR87G225B87-material";
   diffuseColor[0] = "0.341177 0.882353 0.341177 1";
   specular[2] = "1 1 1 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(shrine_column_A_bk_ColorEffectR148G177B27_material)
{
   mapTo = "ColorEffectR148G177B27-material";
   diffuseColor[0] = "0.580392 0.694118 0.105882 1";
   specular[2] = "1 1 1 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(shrine_column_A_bk_ColorEffectR228G184B153_material)
{
   mapTo = "ColorEffectR228G184B153-material";
   diffuseColor[0] = "0.894118 0.721569 0.6 1";
   specular[2] = "1 1 1 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(shrine_column_C_bk_ColorEffectR28G149B177_material)
{
   mapTo = "ColorEffectR28G149B177-material";
   diffuseColor[0] = "0.109804 0.584314 0.694118 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(shrine_column_C_bk_ColorEffectR177G148B27_material)
{
   mapTo = "ColorEffectR177G148B27-material";
   diffuseColor[0] = "0.694118 0.580392 0.105882 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(shrine_column_C_bk_ColorEffectR113G135B6_material)
{
   mapTo = "ColorEffectR113G135B6-material";
   diffuseColor[0] = "0.443137 0.529412 0.0235294 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(shrine_column_C_bk_ColorEffectR177G88B27_material)
{
   mapTo = "ColorEffectR177G88B27-material";
   diffuseColor[0] = "0.694118 0.345098 0.105882 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(target_unbroken_ColorEffectR113G134B6_material)
{
   mapTo = "ColorEffectR113G134B6-material";
   diffuseColor[0] = "0.443137 0.52549 0.0235294 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(block_short_ColorEffectR87G224B198_material)
{
   mapTo = "ColorEffectR87G224B198-material";
   diffuseColor[0] = "0.341177 0.878431 0.776471 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(block_tall_ColorEffectR26G177B148_material)
{
   mapTo = "ColorEffectR26G177B148-material";
   diffuseColor[0] = "0.101961 0.694118 0.580392 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(block_tall_ColorEffectR61G134B6_material)
{
   mapTo = "ColorEffectR61G134B6-material";
   diffuseColor[0] = "0.239216 0.52549 0.0235294 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(pier_piece_t_unbroken_ColorEffectR135G110B8_material)
{
   mapTo = "ColorEffectR135G110B8-material";
   diffuseColor[0] = "0.529412 0.431373 0.0313726 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(shrine_column_D_unbk_ColorEffectR86G86B86_material)
{
   mapTo = "ColorEffectR86G86B86-material";
   diffuseColor[0] = "0.337255 0.337255 0.337255 1";
   specular[2] = "1 1 1 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(shrine_column_E_unbk_ColorEffectR141G7B58_material)
{
   mapTo = "ColorEffectR141G7B58-material";
   diffuseColor[0] = "0.552941 0.027451 0.227451 1";
   specular[2] = "White";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};
