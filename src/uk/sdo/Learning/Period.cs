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

namespace OpenADK.Library.uk.Learning{

/// <summary>A Period</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class Period : SifElement
{
	/// <summary>
	/// Creates an instance of a Period
	/// </summary>
	public Period() : base ( LearningDTD.PERIOD ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="periodIndex">Ordinal position of period within the day (1,2,3,etc)</param>
	///<param name="shortName">A ShortName</param>
	///<param name="longName">A LongName</param>
	///<param name="type">What this period represents. Note that currently some programs represent registration, breaks and lunches as a "period" and some don't. This Type could differ from the lesson Type (see section C4) if this teacher is doing something in this period which differs from the majority of the school.</param>
	///
	public Period( int? periodIndex, string shortName, string longName, PeriodType type ) : base( LearningDTD.PERIOD )
	{
		this.PeriodIndex = periodIndex;
		this.ShortName = shortName;
		this.LongName = longName;
		this.SetType( type );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Period( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { LearningDTD.PERIOD_PERIODINDEX, LearningDTD.PERIOD_SHORTNAME, LearningDTD.PERIOD_LONGNAME, LearningDTD.PERIOD_TYPE }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PeriodIndex&gt;</c> element.
	/// </summary>
	/// <value> The <c>PeriodIndex</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Ordinal position of period within the day (1,2,3,etc)"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public int? PeriodIndex
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( LearningDTD.PERIOD_PERIODINDEX ) ;
		}
		set
		{
			SetFieldValue( LearningDTD.PERIOD_PERIODINDEX, new SifInt( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ShortName&gt;</c> element.
	/// </summary>
	/// <value> The <c>ShortName</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string ShortName
	{
		get
		{
			return (string) GetSifSimpleFieldValue( LearningDTD.PERIOD_SHORTNAME ) ;
		}
		set
		{
			SetFieldValue( LearningDTD.PERIOD_SHORTNAME, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LongName&gt;</c> element.
	/// </summary>
	/// <value> The <c>LongName</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string LongName
	{
		get
		{
			return (string) GetSifSimpleFieldValue( LearningDTD.PERIOD_LONGNAME ) ;
		}
		set
		{
			SetFieldValue( LearningDTD.PERIOD_LONGNAME, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StartTime&gt;</c> element.
	/// </summary>
	/// <value> The <c>StartTime</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Time the period starts"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public DateTime? StartTime
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( LearningDTD.PERIOD_STARTTIME ) ;
		}
		set
		{
			SetFieldValue( LearningDTD.PERIOD_STARTTIME, new SifTime( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;EndTime&gt;</c> element.
	/// </summary>
	/// <value> The <c>EndTime</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Time the period ends"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public DateTime? EndTime
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( LearningDTD.PERIOD_ENDTIME ) ;
		}
		set
		{
			SetFieldValue( LearningDTD.PERIOD_ENDTIME, new SifTime( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Type&gt;</c> element.
	/// </summary>
	/// <value> The <c>Type</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "What this period represents. Note that currently some programs represent registration, breaks and lunches as a "period" and some don't. This Type could differ from the lesson Type (see section C4) if this teacher is doing something in this period which differs from the majority of the school."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string Type
	{
		get
		{ 
			return GetFieldValue( LearningDTD.PERIOD_TYPE );
		}
		set
		{
			SetField( LearningDTD.PERIOD_TYPE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;Type&gt;</c> element.
	/// </summary>
	/// <param name="val">A PeriodType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "What this period represents. Note that currently some programs represent registration, breaks and lunches as a "period" and some don't. This Type could differ from the lesson Type (see section C4) if this teacher is doing something in this period which differs from the majority of the school."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetType( PeriodType val )
	{
		SetField( LearningDTD.PERIOD_TYPE, val );
	}

}}
