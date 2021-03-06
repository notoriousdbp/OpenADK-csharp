// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using System.Text;
using System.Security.Permissions;
using System.Runtime.Serialization;
using OpenADK.Library;
using OpenADK.Library.Global;
using OpenADK.Library.us.Common;

namespace OpenADK.Library.us.Food{

/// <summary>Reimbursement Rate of the meal</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.5r1</para>
/// </remarks>
[Serializable]
public class Rate : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a Rate
	/// </summary>
	public Rate() : base ( FoodDTD.RATE ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="severeNeed">
	///         Severe need identifier for the rate. When SevereNeed is Yes then the rate shown is the combined rate.
	///         For certain programs the severe need identifier does not apply.  In such cases the value NA should
	///         be used.
	///       </param>
	///<param name="value">The rate value</param>
	///<param name="mealStatus">This gives information about a student's meal status.</param>
	///
	public Rate( YesNoNA severeNeed, string value, MealStatus mealStatus ) : base( FoodDTD.RATE )
	{
		this.SetSevereNeed( severeNeed );
		this.Value = value;
		this.MealStatus = mealStatus;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Rate( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { FoodDTD.RATE_VALUE }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>SevereNeed</c> attribute.
	/// </summary>
	/// <value> The <c>SevereNeed</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "
	///         Severe need identifier for the rate. When SevereNeed is Yes then the rate shown is the combined rate.
	///         For certain programs the severe need identifier does not apply.  In such cases the value NA should
	///         be used.
	///       "</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string SevereNeed
	{
		get
		{ 
			return GetFieldValue( FoodDTD.RATE_SEVERENEED );
		}
		set
		{
			SetField( FoodDTD.RATE_SEVERENEED, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>SevereNeed</c> attribute.
	/// </summary>
	/// <param name="val">A YesNoNA object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "
	///         Severe need identifier for the rate. When SevereNeed is Yes then the rate shown is the combined rate.
	///         For certain programs the severe need identifier does not apply.  In such cases the value NA should
	///         be used.
	///       "</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void SetSevereNeed( YesNoNA val )
	{
		SetField( FoodDTD.RATE_SEVERENEED, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>Value</c> attribute.
	/// </summary>
	/// <value> The <c>Value</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The rate value"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string Value
	{
		get
		{
			return (string) GetSifSimpleFieldValue( FoodDTD.RATE_VALUE ) ;
		}
		set
		{
			SetFieldValue( FoodDTD.RATE_VALUE, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;MealStatus&gt;</c> element.</summary>
	/// <param name="Type">Meal status type.</param>
	///<remarks>
	/// <para>This form of <c>setMealStatus</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>MealStatus</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void SetMealStatus( FreeReducedStatus Type ) {
		RemoveChild( FoodDTD.RATE_MEALSTATUS);
		AddChild( FoodDTD.RATE_MEALSTATUS, new MealStatus( Type ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;MealStatus&gt;</c> element.
	/// </summary>
	/// <value> A MealStatus </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "This gives information about a student's meal status."</para>
	/// <para>To remove the <c>MealStatus</c>, set <c>MealStatus</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public MealStatus MealStatus
	{
		get
		{
			return (MealStatus)GetChild( FoodDTD.RATE_MEALSTATUS);
		}
		set
		{
			RemoveChild( FoodDTD.RATE_MEALSTATUS);
			if( value != null)
			{
				AddChild( FoodDTD.RATE_MEALSTATUS, value );
			}
		}
	}

}}
