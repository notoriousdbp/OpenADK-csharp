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
using OpenADK.Library.au.Common;

namespace OpenADK.Library.au.School{

/// <summary>A SessionInfo</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class SessionInfo : SifDataObject
{
	/// <summary>
	/// Creates an instance of a SessionInfo
	/// </summary>
	public SessionInfo() : base( Adk.SifVersion, SchoolDTD.SESSIONINFO ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">The GUID of the Object</param>
	///<param name="schoolInfoRefId">The ID (GUID) of the school for which this attendance information is being reported.</param>
	///<param name="timeTableCellRefId">The (GUID) of the piece of Curriculum (TT Grid) scheduled</param>
	///<param name="schoolYear">A SchoolYear</param>
	///<param name="localId">A LocalId</param>
	///<param name="timeTableSubjectLocalId">TimeTableSubject Local Identifier</param>
	///<param name="teachingGroupLocalId">Teaching Group Local Identifier</param>
	///<param name="dayId">Day Id</param>
	///<param name="periodId">Period Id within the Day Id</param>
	///<param name="sessionDate">Date of Session</param>
	///
	public SessionInfo( string refId, string schoolInfoRefId, string timeTableCellRefId, int? schoolYear, string localId, string timeTableSubjectLocalId, string teachingGroupLocalId, string dayId, string periodId, DateTime? sessionDate ) : base( Adk.SifVersion, SchoolDTD.SESSIONINFO )
	{
		this.RefId = refId;
		this.SchoolInfoRefId = schoolInfoRefId;
		this.TimeTableCellRefId = timeTableCellRefId;
		this.SchoolYear = schoolYear;
		this.LocalId = localId;
		this.TimeTableSubjectLocalId = timeTableSubjectLocalId;
		this.TeachingGroupLocalId = teachingGroupLocalId;
		this.DayId = dayId;
		this.PeriodId = periodId;
		this.SessionDate = sessionDate;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected SessionInfo( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { SchoolDTD.SESSIONINFO_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The GUID of the Object"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( SchoolDTD.SESSIONINFO_REFID ) ;
		}
		set
		{
			SetFieldValue( SchoolDTD.SESSIONINFO_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SchoolInfoRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>SchoolInfoRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The ID (GUID) of the school for which this attendance information is being reported."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string SchoolInfoRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( SchoolDTD.SESSIONINFO_SCHOOLINFOREFID ) ;
		}
		set
		{
			SetFieldValue( SchoolDTD.SESSIONINFO_SCHOOLINFOREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;TimeTableCellRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>TimeTableCellRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The (GUID) of the piece of Curriculum (TT Grid) scheduled"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string TimeTableCellRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( SchoolDTD.SESSIONINFO_TIMETABLECELLREFID ) ;
		}
		set
		{
			SetFieldValue( SchoolDTD.SESSIONINFO_TIMETABLECELLREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SchoolYear&gt;</c> element.
	/// </summary>
	/// <value> The <c>SchoolYear</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public int? SchoolYear
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( SchoolDTD.SESSIONINFO_SCHOOLYEAR ) ;
		}
		set
		{
			SetFieldValue( SchoolDTD.SESSIONINFO_SCHOOLYEAR, new SifInt( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LocalId&gt;</c> element.
	/// </summary>
	/// <value> The <c>LocalId</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string LocalId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( SchoolDTD.SESSIONINFO_LOCALID ) ;
		}
		set
		{
			SetFieldValue( SchoolDTD.SESSIONINFO_LOCALID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;TimeTableSubjectLocalId&gt;</c> element.
	/// </summary>
	/// <value> The <c>TimeTableSubjectLocalId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "TimeTableSubject Local Identifier"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string TimeTableSubjectLocalId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( SchoolDTD.SESSIONINFO_TIMETABLESUBJECTLOCALID ) ;
		}
		set
		{
			SetFieldValue( SchoolDTD.SESSIONINFO_TIMETABLESUBJECTLOCALID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;TeachingGroupLocalId&gt;</c> element.
	/// </summary>
	/// <value> The <c>TeachingGroupLocalId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Teaching Group Local Identifier"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string TeachingGroupLocalId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( SchoolDTD.SESSIONINFO_TEACHINGGROUPLOCALID ) ;
		}
		set
		{
			SetFieldValue( SchoolDTD.SESSIONINFO_TEACHINGGROUPLOCALID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SchoolLocalId&gt;</c> element.
	/// </summary>
	/// <value> The <c>SchoolLocalId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "School Local Identifier"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string SchoolLocalId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( SchoolDTD.SESSIONINFO_SCHOOLLOCALID ) ;
		}
		set
		{
			SetFieldValue( SchoolDTD.SESSIONINFO_SCHOOLLOCALID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StaffPersonalLocalId&gt;</c> element.
	/// </summary>
	/// <value> The <c>StaffPersonalLocalId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Staff Local Identifier"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string StaffPersonalLocalId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( SchoolDTD.SESSIONINFO_STAFFPERSONALLOCALID ) ;
		}
		set
		{
			SetFieldValue( SchoolDTD.SESSIONINFO_STAFFPERSONALLOCALID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;RoomNumber&gt;</c> element.
	/// </summary>
	/// <value> The <c>RoomNumber</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Room number as presented to the user or application.  Needs to be provided if changed from  TimeTableCell."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string RoomNumber
	{
		get
		{
			return (string) GetSifSimpleFieldValue( SchoolDTD.SESSIONINFO_ROOMNUMBER ) ;
		}
		set
		{
			SetFieldValue( SchoolDTD.SESSIONINFO_ROOMNUMBER, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;DayId&gt;</c> element.
	/// </summary>
	/// <value> The <c>DayId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Day Id"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string DayId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( SchoolDTD.SESSIONINFO_DAYID ) ;
		}
		set
		{
			SetFieldValue( SchoolDTD.SESSIONINFO_DAYID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PeriodId&gt;</c> element.
	/// </summary>
	/// <value> The <c>PeriodId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Period Id within the Day Id"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string PeriodId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( SchoolDTD.SESSIONINFO_PERIODID ) ;
		}
		set
		{
			SetFieldValue( SchoolDTD.SESSIONINFO_PERIODID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SessionDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>SessionDate</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Date of Session"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public DateTime? SessionDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( SchoolDTD.SESSIONINFO_SESSIONDATE ) ;
		}
		set
		{
			SetFieldValue( SchoolDTD.SESSIONINFO_SESSIONDATE, new SifDate( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StartTime&gt;</c> element.
	/// </summary>
	/// <value> The <c>StartTime</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Optional Start Time"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public DateTime? StartTime
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( SchoolDTD.SESSIONINFO_STARTTIME ) ;
		}
		set
		{
			SetFieldValue( SchoolDTD.SESSIONINFO_STARTTIME, new SifTime( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;FinishTime&gt;</c> element.
	/// </summary>
	/// <value> The <c>FinishTime</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Optional End Time"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public DateTime? FinishTime
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( SchoolDTD.SESSIONINFO_FINISHTIME ) ;
		}
		set
		{
			SetFieldValue( SchoolDTD.SESSIONINFO_FINISHTIME, new SifTime( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;RollMarked&gt;</c> element.
	/// </summary>
	/// <value> The <c>RollMarked</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Was the Roll Marked for this Period?"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string RollMarked
	{
		get
		{ 
			return GetFieldValue( SchoolDTD.SESSIONINFO_ROLLMARKED );
		}
		set
		{
			SetField( SchoolDTD.SESSIONINFO_ROLLMARKED, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;RollMarked&gt;</c> element.
	/// </summary>
	/// <param name="val">A AUCodeSetsYesOrNoCategoryType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Was the Roll Marked for this Period?"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetRollMarked( AUCodeSetsYesOrNoCategoryType val )
	{
		SetField( SchoolDTD.SESSIONINFO_ROLLMARKED, val );
	}

}}