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

namespace OpenADK.Library.us.Assessment{

/// <summary>An HomeEnrollmentSif3</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class HomeEnrollmentSif3 : SifElement
{
	/// <summary>
	/// Creates an instance of an HomeEnrollmentSif3
	/// </summary>
	public HomeEnrollmentSif3() : base ( AssessmentDTD.HOMEENROLLMENTSIF3 ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="status">Enrollment status as of the SnapDate.</param>
	///<param name="gradeLevel">Grade or academic level of student.</param>
	///
	public HomeEnrollmentSif3( HomeEnrollmentStatusSif3 status, GradeLevel gradeLevel ) : base( AssessmentDTD.HOMEENROLLMENTSIF3 )
	{
		this.SetStatus( status );
		this.GradeLevel = gradeLevel;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected HomeEnrollmentSif3( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { AssessmentDTD.HOMEENROLLMENTSIF3_STATUS, AssessmentDTD.HOMEENROLLMENTSIF3_GRADELEVEL }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StudentSchoolEnrollmentRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>StudentSchoolEnrollmentRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string StudentSchoolEnrollmentRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.HOMEENROLLMENTSIF3_STUDENTSCHOOLENROLLMENTREFID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.HOMEENROLLMENTSIF3_STUDENTSCHOOLENROLLMENTREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SchoolName&gt;</c> element.
	/// </summary>
	/// <value> The <c>SchoolName</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Name of the school."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string SchoolName
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.HOMEENROLLMENTSIF3_SCHOOLNAME ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.HOMEENROLLMENTSIF3_SCHOOLNAME, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SchoolInfoRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>SchoolInfoRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Provide both the HomeEnrollment/SchoolId and HomeEnrollment/LocalId elements if possible. If not, one or the other must be provided."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string SchoolInfoRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.HOMEENROLLMENTSIF3_SCHOOLINFOREFID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.HOMEENROLLMENTSIF3_SCHOOLINFOREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LocalId&gt;</c> element.
	/// </summary>
	/// <value> The <c>LocalId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "
	///           The locally-defined identifier for this school.
	///           Provide both the HomeEnrollment/LocalId and HomeEnrollment/SchoolId elements if possible.
	///           If not, one or the other must be provided.
	///         "</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string LocalId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.HOMEENROLLMENTSIF3_LOCALID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.HOMEENROLLMENTSIF3_LOCALID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StateProvinceId&gt;</c> element.
	/// </summary>
	/// <value> The <c>StateProvinceId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The state or province defined identifier for this school."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string StateProvinceId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.HOMEENROLLMENTSIF3_STATEPROVINCEID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.HOMEENROLLMENTSIF3_STATEPROVINCEID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Status&gt;</c> element.
	/// </summary>
	/// <value> The <c>Status</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Enrollment status as of the SnapDate."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string Status
	{
		get
		{ 
			return GetFieldValue( AssessmentDTD.HOMEENROLLMENTSIF3_STATUS );
		}
		set
		{
			SetField( AssessmentDTD.HOMEENROLLMENTSIF3_STATUS, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;Status&gt;</c> element.
	/// </summary>
	/// <param name="val">A HomeEnrollmentStatusSif3 object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Enrollment status as of the SnapDate."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetStatus( HomeEnrollmentStatusSif3 val )
	{
		SetField( AssessmentDTD.HOMEENROLLMENTSIF3_STATUS, val );
	}

	///<summary>Sets the value of the <c>&lt;GradeLevel&gt;</c> element.</summary>
	/// <param name="Code">Code representing the grade level.</param>
	///<remarks>
	/// <para>This form of <c>setGradeLevel</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>GradeLevel</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetGradeLevel( GradeLevelCode Code ) {
		RemoveChild( AssessmentDTD.HOMEENROLLMENTSIF3_GRADELEVEL);
		AddChild( AssessmentDTD.HOMEENROLLMENTSIF3_GRADELEVEL, new GradeLevel( Code ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;GradeLevel&gt;</c> element.
	/// </summary>
	/// <value> A GradeLevel </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Grade or academic level of student."</para>
	/// <para>To remove the <c>GradeLevel</c>, set <c>GradeLevel</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public GradeLevel GradeLevel
	{
		get
		{
			return (GradeLevel)GetChild( AssessmentDTD.HOMEENROLLMENTSIF3_GRADELEVEL);
		}
		set
		{
			RemoveChild( AssessmentDTD.HOMEENROLLMENTSIF3_GRADELEVEL);
			if( value != null)
			{
				AddChild( AssessmentDTD.HOMEENROLLMENTSIF3_GRADELEVEL, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;HomeroomSif3&gt;</c> element.</summary>
	/// <param name="SifRefObject">The name of the object referenced.</param>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;HomeroomSif3&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setHomeroomSif3</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>HomeroomSif3</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetHomeroomSif3( string SifRefObject, string Value ) {
		RemoveChild( AssessmentDTD.HOMEENROLLMENTSIF3_HOMEROOMSIF3);
		AddChild( AssessmentDTD.HOMEENROLLMENTSIF3_HOMEROOMSIF3, new HomeroomSif3( SifRefObject, Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;HomeroomSif3&gt;</c> element.
	/// </summary>
	/// <value> An HomeroomSif3 </value>
	/// <remarks>
	/// <para>To remove the <c>HomeroomSif3</c>, set <c>HomeroomSif3</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public HomeroomSif3 HomeroomSif3
	{
		get
		{
			return (HomeroomSif3)GetChild( AssessmentDTD.HOMEENROLLMENTSIF3_HOMEROOMSIF3);
		}
		set
		{
			RemoveChild( AssessmentDTD.HOMEENROLLMENTSIF3_HOMEROOMSIF3);
			if( value != null)
			{
				AddChild( AssessmentDTD.HOMEENROLLMENTSIF3_HOMEROOMSIF3, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;HomeroomNumber&gt;</c> element.
	/// </summary>
	/// <value> The <c>HomeroomNumber</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The locally-defined identifier for this room."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string HomeroomNumber
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.HOMEENROLLMENTSIF3_HOMEROOMNUMBER ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.HOMEENROLLMENTSIF3_HOMEROOMNUMBER, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;FullYearEnrollment&gt;</c> element.
	/// </summary>
	/// <value> The <c>FullYearEnrollment</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "An indication as to whether or not the student was enrolled for the whole school year. If the SchoolYear is in progress as of the SnapDate, use the value "Unknown"."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string FullYearEnrollment
	{
		get
		{ 
			return GetFieldValue( AssessmentDTD.HOMEENROLLMENTSIF3_FULLYEARENROLLMENT );
		}
		set
		{
			SetField( AssessmentDTD.HOMEENROLLMENTSIF3_FULLYEARENROLLMENT, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;FullYearEnrollment&gt;</c> element.
	/// </summary>
	/// <param name="val">A YesNoUnknown object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "An indication as to whether or not the student was enrolled for the whole school year. If the SchoolYear is in progress as of the SnapDate, use the value "Unknown"."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetFullYearEnrollment( YesNoUnknown val )
	{
		SetField( AssessmentDTD.HOMEENROLLMENTSIF3_FULLYEARENROLLMENT, val );
	}

}}