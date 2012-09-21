// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Student
{
	///<summary>
	/// Defines the set of values that can be specified whenever a WeaponTypeCode
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a WeaponTypeCode object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	[Serializable]
	public class WeaponTypeCode : SifEnum
	{
	/// <summary>Handgun ("0011")</summary>
	public static readonly WeaponTypeCode C0011_HANDGUN = new WeaponTypeCode("0011");

	/// <summary>Other Sharp Objects ("0030")</summary>
	public static readonly WeaponTypeCode C0030_OTHER_SHARP_OBJECT = new WeaponTypeCode("0030");

	/// <summary>Firearm ("0010")</summary>
	public static readonly WeaponTypeCode C0010_FIREARM = new WeaponTypeCode("0010");

	/// <summary>Knife ("0020")</summary>
	public static readonly WeaponTypeCode C0020_KNIFE = new WeaponTypeCode("0020");

	/// <summary>Knife with blade greater than or equal to 2.5 inches ("0023")</summary>
	public static readonly WeaponTypeCode C0023_KNIFE_GREATER_2_5 = new WeaponTypeCode("0023");

	/// <summary>Shotgun/rifle ("0012")</summary>
	public static readonly WeaponTypeCode C0012_SHOTGUN_RIFLE = new WeaponTypeCode("0012");

	/// <summary>Other ("0097")</summary>
	public static readonly WeaponTypeCode C0097_OTHER = new WeaponTypeCode("0097");

	/// <summary>Other type of firearm ("0013")</summary>
	public static readonly WeaponTypeCode C0013_OTHER_FIREARM = new WeaponTypeCode("0013");

	/// <summary>Substance Used as Weapon ("0050")</summary>
	public static readonly WeaponTypeCode C0050_SUBSTANCE = new WeaponTypeCode("0050");

	/// <summary>Other Object ("0040")</summary>
	public static readonly WeaponTypeCode C0040_OTHER_OBJECT = new WeaponTypeCode("0040");

	/// <summary>Other knife ("0029")</summary>
	public static readonly WeaponTypeCode C0029_OTHER_KNIFE = new WeaponTypeCode("0029");

	/// <summary>Unknown Weapon ("0099")</summary>
	public static readonly WeaponTypeCode C0099_UNKNOWN_WEAPON = new WeaponTypeCode("0099");

	/// <summary>No Weapon ("0098")</summary>
	public static readonly WeaponTypeCode C0098_NO_WEAPON = new WeaponTypeCode("0098");

	/// <summary>Knife with blade less than 2.5 inches ("0021")</summary>
	public static readonly WeaponTypeCode C0021_KNIFE_LESS_2_5 = new WeaponTypeCode("0021");

	///<summary>Wrap an arbitrary string value in a WeaponTypeCode object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static WeaponTypeCode Wrap( String wrappedValue ) {
		return new WeaponTypeCode( wrappedValue );
	}

	private WeaponTypeCode( string enumDefValue ) : base( enumDefValue ) {}
	}
}