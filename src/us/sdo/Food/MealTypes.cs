// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Food
{
	///<summary>
	/// Defines the set of values that can be specified whenever a MealTypes
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a MealTypes object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	[Serializable]
	public class MealTypes : SifEnum
	{
	/// <summary>AdultMeal ("AdultMeal")</summary>
	public static readonly MealTypes ADULTMEAL = new MealTypes("AdultMeal");

	/// <summary>StaffMeal ("StaffMeal")</summary>
	public static readonly MealTypes STAFFMEAL = new MealTypes("StaffMeal");

	/// <summary>FirstMeal ("FirstMeal")</summary>
	public static readonly MealTypes FIRSTMEAL = new MealTypes("FirstMeal");

	/// <summary>AlaCarte ("AlaCarte")</summary>
	public static readonly MealTypes ALACARTE = new MealTypes("AlaCarte");

	/// <summary>SecondMeal ("SecondMeal")</summary>
	public static readonly MealTypes SECONDMEAL = new MealTypes("SecondMeal");

	///<summary>Wrap an arbitrary string value in a MealTypes object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static MealTypes Wrap( String wrappedValue ) {
		return new MealTypes( wrappedValue );
	}

	private MealTypes( string enumDefValue ) : base( enumDefValue ) {}
	}
}
