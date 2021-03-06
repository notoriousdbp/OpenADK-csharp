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
using OpenADK.Library.us.Gradebook;
using OpenADK.Library.us.Student;

namespace OpenADK.Library.us.Etranscripts{

/// <summary>A StudentAcademicRecord</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class StudentAcademicRecord : SifDataObject
{
	/// <summary>
	/// Creates an instance of a StudentAcademicRecord
	/// </summary>
	public StudentAcademicRecord() : base( Adk.SifVersion, EtranscriptsDTD.STUDENTACADEMICRECORD ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">The ID (GUID) of this record.</param>
	///<param name="sifRefId">The GUID of an associated object, either StudentRecordExchange or StudentPersonal.</param>
	///<param name="sifRefObject">The associated object type.</param>
	///
	public StudentAcademicRecord( string refId, string sifRefId, TranscriptRecordRefObject sifRefObject ) : base( Adk.SifVersion, EtranscriptsDTD.STUDENTACADEMICRECORD )
	{
		this.RefId = refId;
		this.SIF_RefId = sifRefId;
		this.SetSIF_RefObject( sifRefObject );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected StudentAcademicRecord( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { EtranscriptsDTD.STUDENTACADEMICRECORD_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The ID (GUID) of this record."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( EtranscriptsDTD.STUDENTACADEMICRECORD_REFID ) ;
		}
		set
		{
			SetFieldValue( EtranscriptsDTD.STUDENTACADEMICRECORD_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>SIF_RefId</c> attribute.
	/// </summary>
	/// <value> The <c>SIF_RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The GUID of an associated object, either StudentRecordExchange or StudentPersonal."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string SIF_RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( EtranscriptsDTD.STUDENTACADEMICRECORD_SIF_REFID ) ;
		}
		set
		{
			SetFieldValue( EtranscriptsDTD.STUDENTACADEMICRECORD_SIF_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>SIF_RefObject</c> attribute.
	/// </summary>
	/// <value> The <c>SIF_RefObject</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The associated object type."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string SIF_RefObject
	{
		get
		{ 
			return GetFieldValue( EtranscriptsDTD.STUDENTACADEMICRECORD_SIF_REFOBJECT );
		}
		set
		{
			SetField( EtranscriptsDTD.STUDENTACADEMICRECORD_SIF_REFOBJECT, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>SIF_RefObject</c> attribute.
	/// </summary>
	/// <param name="val">A TranscriptRecordRefObject object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The associated object type."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetSIF_RefObject( TranscriptRecordRefObject val )
	{
		SetField( EtranscriptsDTD.STUDENTACADEMICRECORD_SIF_REFOBJECT, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ReportingDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>ReportingDate</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The date this record was prepared."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public DateTime? ReportingDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( EtranscriptsDTD.STUDENTACADEMICRECORD_REPORTINGDATE ) ;
		}
		set
		{
			SetFieldValue( EtranscriptsDTD.STUDENTACADEMICRECORD_REPORTINGDATE, new SifDate( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;StudentSchoolEnrollmentData&gt;</c> element.</summary>
	/// <param name="SchoolAttendedRefId">References the school of record for the student (see SchoolAttended).</param>
	///<remarks>
	/// <para>This form of <c>setStudentSchoolEnrollmentData</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>StudentSchoolEnrollmentData</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetStudentSchoolEnrollmentData( string SchoolAttendedRefId ) {
		RemoveChild( EtranscriptsDTD.STUDENTACADEMICRECORD_STUDENTSCHOOLENROLLMENTDATA);
		AddChild( EtranscriptsDTD.STUDENTACADEMICRECORD_STUDENTSCHOOLENROLLMENTDATA, new StudentSchoolEnrollmentData( SchoolAttendedRefId ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StudentSchoolEnrollmentData&gt;</c> element.
	/// </summary>
	/// <value> A StudentSchoolEnrollmentData </value>
	/// <remarks>
	/// <para>To remove the <c>StudentSchoolEnrollmentData</c>, set <c>StudentSchoolEnrollmentData</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public StudentSchoolEnrollmentData StudentSchoolEnrollmentData
	{
		get
		{
			return (StudentSchoolEnrollmentData)GetChild( EtranscriptsDTD.STUDENTACADEMICRECORD_STUDENTSCHOOLENROLLMENTDATA);
		}
		set
		{
			RemoveChild( EtranscriptsDTD.STUDENTACADEMICRECORD_STUDENTSCHOOLENROLLMENTDATA);
			if( value != null)
			{
				AddChild( EtranscriptsDTD.STUDENTACADEMICRECORD_STUDENTSCHOOLENROLLMENTDATA, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;DistrictEntryDate&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;PartialDateType&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setDistrictEntryDate</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>DistrictEntryDate</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetDistrictEntryDate( string Value ) {
		RemoveChild( EtranscriptsDTD.STUDENTACADEMICRECORD_DISTRICTENTRYDATE);
		AddChild( EtranscriptsDTD.STUDENTACADEMICRECORD_DISTRICTENTRYDATE, new PartialDateType( Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;DistrictEntryDate&gt;</c> element.
	/// </summary>
	/// <value> A PartialDateType </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The date the student originally enrolled in the district of the school of record."</para>
	/// <para>To remove the <c>PartialDateType</c>, set <c>DistrictEntryDate</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public PartialDateType DistrictEntryDate
	{
		get
		{
			return (PartialDateType)GetChild( EtranscriptsDTD.STUDENTACADEMICRECORD_DISTRICTENTRYDATE);
		}
		set
		{
			RemoveChild( EtranscriptsDTD.STUDENTACADEMICRECORD_DISTRICTENTRYDATE);
			if( value != null)
			{
				AddChild( EtranscriptsDTD.STUDENTACADEMICRECORD_DISTRICTENTRYDATE, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SchoolAttendanceHistory&gt;</c> element.
	/// </summary>
	/// <value> A SchoolAttendanceHistory </value>
	/// <remarks>
	/// <para>To remove the <c>SchoolAttendanceHistory</c>, set <c>SchoolAttendanceHistory</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public SchoolAttendanceHistory SchoolAttendanceHistory
	{
		get
		{
			return (SchoolAttendanceHistory)GetChild( EtranscriptsDTD.STUDENTACADEMICRECORD_SCHOOLATTENDANCEHISTORY);
		}
		set
		{
			RemoveChild( EtranscriptsDTD.STUDENTACADEMICRECORD_SCHOOLATTENDANCEHISTORY);
			if( value != null)
			{
				AddChild( EtranscriptsDTD.STUDENTACADEMICRECORD_SCHOOLATTENDANCEHISTORY, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;EnrollmentHistory&gt;</c> element.
	/// </summary>
	/// <value> An EnrollmentHistory </value>
	/// <remarks>
	/// <para>To remove the <c>EnrollmentHistory</c>, set <c>EnrollmentHistory</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public EnrollmentHistory EnrollmentHistory
	{
		get
		{
			return (EnrollmentHistory)GetChild( EtranscriptsDTD.STUDENTACADEMICRECORD_ENROLLMENTHISTORY);
		}
		set
		{
			RemoveChild( EtranscriptsDTD.STUDENTACADEMICRECORD_ENROLLMENTHISTORY);
			if( value != null)
			{
				AddChild( EtranscriptsDTD.STUDENTACADEMICRECORD_ENROLLMENTHISTORY, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;CurrentCourseActivity&gt;</c> element.
	/// </summary>
	/// <value> A CurrentCourseActivity </value>
	/// <remarks>
	/// <para>To remove the <c>CurrentCourseActivity</c>, set <c>CurrentCourseActivity</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public CurrentCourseActivity CurrentCourseActivity
	{
		get
		{
			return (CurrentCourseActivity)GetChild( EtranscriptsDTD.STUDENTACADEMICRECORD_CURRENTCOURSEACTIVITY);
		}
		set
		{
			RemoveChild( EtranscriptsDTD.STUDENTACADEMICRECORD_CURRENTCOURSEACTIVITY);
			if( value != null)
			{
				AddChild( EtranscriptsDTD.STUDENTACADEMICRECORD_CURRENTCOURSEACTIVITY, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;CourseHistory&gt;</c> element.
	/// </summary>
	/// <value> A CourseHistory </value>
	/// <remarks>
	/// <para>To remove the <c>CourseHistory</c>, set <c>CourseHistory</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public CourseHistory CourseHistory
	{
		get
		{
			return (CourseHistory)GetChild( EtranscriptsDTD.STUDENTACADEMICRECORD_COURSEHISTORY);
		}
		set
		{
			RemoveChild( EtranscriptsDTD.STUDENTACADEMICRECORD_COURSEHISTORY);
			if( value != null)
			{
				AddChild( EtranscriptsDTD.STUDENTACADEMICRECORD_COURSEHISTORY, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AcademicPerformanceHistory&gt;</c> element.
	/// </summary>
	/// <value> An AcademicPerformanceHistory </value>
	/// <remarks>
	/// <para>To remove the <c>AcademicPerformanceHistory</c>, set <c>AcademicPerformanceHistory</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public AcademicPerformanceHistory AcademicPerformanceHistory
	{
		get
		{
			return (AcademicPerformanceHistory)GetChild( EtranscriptsDTD.STUDENTACADEMICRECORD_ACADEMICPERFORMANCEHISTORY);
		}
		set
		{
			RemoveChild( EtranscriptsDTD.STUDENTACADEMICRECORD_ACADEMICPERFORMANCEHISTORY);
			if( value != null)
			{
				AddChild( EtranscriptsDTD.STUDENTACADEMICRECORD_ACADEMICPERFORMANCEHISTORY, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AcademicPerformanceSummary&gt;</c> element.
	/// </summary>
	/// <value> An AcademicPerformanceSummary </value>
	/// <remarks>
	/// <para>To remove the <c>AcademicPerformanceSummary</c>, set <c>AcademicPerformanceSummary</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public AcademicPerformanceSummary AcademicPerformanceSummary
	{
		get
		{
			return (AcademicPerformanceSummary)GetChild( EtranscriptsDTD.STUDENTACADEMICRECORD_ACADEMICPERFORMANCESUMMARY);
		}
		set
		{
			RemoveChild( EtranscriptsDTD.STUDENTACADEMICRECORD_ACADEMICPERFORMANCESUMMARY);
			if( value != null)
			{
				AddChild( EtranscriptsDTD.STUDENTACADEMICRECORD_ACADEMICPERFORMANCESUMMARY, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;AssessmentPerformanceHistory&gt;</c> element.</summary>
	/// <param name="Assessment">An Assessment</param>
	///<remarks>
	/// <para>This form of <c>setAssessmentPerformanceHistory</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>AssessmentPerformanceHistory</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetAssessmentPerformanceHistory( AssessmentHistory Assessment ) {
		RemoveChild( EtranscriptsDTD.STUDENTACADEMICRECORD_ASSESSMENTPERFORMANCEHISTORY);
		AddChild( EtranscriptsDTD.STUDENTACADEMICRECORD_ASSESSMENTPERFORMANCEHISTORY, new AssessmentPerformanceHistory( Assessment ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssessmentPerformanceHistory&gt;</c> element.
	/// </summary>
	/// <value> An AssessmentPerformanceHistory </value>
	/// <remarks>
	/// <para>To remove the <c>AssessmentPerformanceHistory</c>, set <c>AssessmentPerformanceHistory</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public AssessmentPerformanceHistory AssessmentPerformanceHistory
	{
		get
		{
			return (AssessmentPerformanceHistory)GetChild( EtranscriptsDTD.STUDENTACADEMICRECORD_ASSESSMENTPERFORMANCEHISTORY);
		}
		set
		{
			RemoveChild( EtranscriptsDTD.STUDENTACADEMICRECORD_ASSESSMENTPERFORMANCEHISTORY);
			if( value != null)
			{
				AddChild( EtranscriptsDTD.STUDENTACADEMICRECORD_ASSESSMENTPERFORMANCEHISTORY, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AdditionalGraduationRequirementPerformanceHistory&gt;</c> element.
	/// </summary>
	/// <value> An AdditionalGraduationRequirementPerformanceHistory </value>
	/// <remarks>
	/// <para>To remove the <c>AdditionalGraduationRequirementPerformanceHistory</c>, set <c>AdditionalGraduationRequirementPerformanceHistory</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public AdditionalGraduationRequirementPerformanceHistory AdditionalGraduationRequirementPerformanceHistory
	{
		get
		{
			return (AdditionalGraduationRequirementPerformanceHistory)GetChild( EtranscriptsDTD.STUDENTACADEMICRECORD_ADDITIONALGRADUATIONREQUIREMENTPERFORMANCEHISTORY);
		}
		set
		{
			RemoveChild( EtranscriptsDTD.STUDENTACADEMICRECORD_ADDITIONALGRADUATIONREQUIREMENTPERFORMANCEHISTORY);
			if( value != null)
			{
				AddChild( EtranscriptsDTD.STUDENTACADEMICRECORD_ADDITIONALGRADUATIONREQUIREMENTPERFORMANCEHISTORY, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ActivityAwardHistory&gt;</c> element.
	/// </summary>
	/// <value> An ActivityAwardHistory </value>
	/// <remarks>
	/// <para>To remove the <c>ActivityAwardHistory</c>, set <c>ActivityAwardHistory</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public ActivityAwardHistory ActivityAwardHistory
	{
		get
		{
			return (ActivityAwardHistory)GetChild( EtranscriptsDTD.STUDENTACADEMICRECORD_ACTIVITYAWARDHISTORY);
		}
		set
		{
			RemoveChild( EtranscriptsDTD.STUDENTACADEMICRECORD_ACTIVITYAWARDHISTORY);
			if( value != null)
			{
				AddChild( EtranscriptsDTD.STUDENTACADEMICRECORD_ACTIVITYAWARDHISTORY, value );
			}
		}
	}

}}
