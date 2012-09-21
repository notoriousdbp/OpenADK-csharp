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
using OpenADK.Library.uk.Common;

namespace OpenADK.Library.uk.Learner{

/// <summary>An EntitlementPeriod</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class EntitlementPeriod : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of an EntitlementPeriod
	/// </summary>
	public EntitlementPeriod() : base ( LearnerDTD.ENTITLEMENTPERIOD ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="startDate">Date Specific Entitlement starts</param>
	///
	public EntitlementPeriod( DateTime? startDate ) : base( LearnerDTD.ENTITLEMENTPERIOD )
	{
		this.StartDate = startDate;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected EntitlementPeriod( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { LearnerDTD.ENTITLEMENTPERIOD_STARTDATE }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StartDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>StartDate</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Date Specific Entitlement starts"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public DateTime? StartDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( LearnerDTD.ENTITLEMENTPERIOD_STARTDATE ) ;
		}
		set
		{
			SetFieldValue( LearnerDTD.ENTITLEMENTPERIOD_STARTDATE, new SifDate( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;EndDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>EndDate</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Date Specific Entitlement Ends has to be on or after Start date"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public DateTime? EndDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( LearnerDTD.ENTITLEMENTPERIOD_ENDDATE ) ;
		}
		set
		{
			SetFieldValue( LearnerDTD.ENTITLEMENTPERIOD_ENDDATE, new SifDate( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Note&gt;</c> element.
	/// </summary>
	/// <value> The <c>Note</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "A note relating to entitlement period"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string Note
	{
		get
		{
			return (string) GetSifSimpleFieldValue( LearnerDTD.ENTITLEMENTPERIOD_NOTE ) ;
		}
		set
		{
			SetFieldValue( LearnerDTD.ENTITLEMENTPERIOD_NOTE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Value&gt;</c> element.
	/// </summary>
	/// <value> The <c>Value</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string Value
	{
		get
		{
			return (string) GetSifSimpleFieldValue( LearnerDTD.ENTITLEMENTPERIOD_VALUE ) ;
		}
		set
		{
			SetFieldValue( LearnerDTD.ENTITLEMENTPERIOD_VALUE, new SifString( value ), value );
		}
	}

}}