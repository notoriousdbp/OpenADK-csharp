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

namespace OpenADK.Library.au.Student{

/// <summary>A StudentPersonal</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class StudentPersonal : SifDataObject
{
	/// <summary>
	/// Creates an instance of a StudentPersonal
	/// </summary>
	public StudentPersonal() : base( Adk.SifVersion, StudentDTD.STUDENTPERSONAL ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">The GUID of the student.</param>
	///<param name="localId">A LocalId</param>
	///<param name="personInfo">A PersonInfo</param>
	///
	public StudentPersonal( string refId, string localId, PersonInfo personInfo ) : base( Adk.SifVersion, StudentDTD.STUDENTPERSONAL )
	{
		this.RefId = refId;
		this.LocalId = localId;
		this.PersonInfo = personInfo;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected StudentPersonal( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { StudentDTD.STUDENTPERSONAL_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The GUID of the student."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STUDENTPERSONAL_REFID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENTPERSONAL_REFID, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;AlertMessages&gt;</c> element.</summary>
	/// <param name="AlertMessage">This is an alert message that is associated with the student.</param>
	///<remarks>
	/// <para>This form of <c>setAlertMessages</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>AlertMessages</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetAlertMessages( AlertMessage AlertMessage ) {
		RemoveChild( StudentDTD.STUDENTPERSONAL_ALERTMESSAGES);
		AddChild( StudentDTD.STUDENTPERSONAL_ALERTMESSAGES, new AlertMessages( AlertMessage ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AlertMessages&gt;</c> element.
	/// </summary>
	/// <value> An AlertMessages </value>
	/// <remarks>
	/// <para>To remove the <c>AlertMessages</c>, set <c>AlertMessages</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public AlertMessages AlertMessages
	{
		get
		{
			return (AlertMessages)GetChild( StudentDTD.STUDENTPERSONAL_ALERTMESSAGES);
		}
		set
		{
			RemoveChild( StudentDTD.STUDENTPERSONAL_ALERTMESSAGES);
			if( value != null)
			{
				AddChild( StudentDTD.STUDENTPERSONAL_ALERTMESSAGES, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;MedicalAlertMessages&gt;</c> element.</summary>
	/// <param name="MedicalAlertMessage">Medical alert associated with the student.</param>
	///<remarks>
	/// <para>This form of <c>setMedicalAlertMessages</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>MedicalAlertMessages</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetMedicalAlertMessages( MedicalAlertMessage MedicalAlertMessage ) {
		RemoveChild( StudentDTD.STUDENTPERSONAL_MEDICALALERTMESSAGES);
		AddChild( StudentDTD.STUDENTPERSONAL_MEDICALALERTMESSAGES, new MedicalAlertMessages( MedicalAlertMessage ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;MedicalAlertMessages&gt;</c> element.
	/// </summary>
	/// <value> A MedicalAlertMessages </value>
	/// <remarks>
	/// <para>To remove the <c>MedicalAlertMessages</c>, set <c>MedicalAlertMessages</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public MedicalAlertMessages MedicalAlertMessages
	{
		get
		{
			return (MedicalAlertMessages)GetChild( StudentDTD.STUDENTPERSONAL_MEDICALALERTMESSAGES);
		}
		set
		{
			RemoveChild( StudentDTD.STUDENTPERSONAL_MEDICALALERTMESSAGES);
			if( value != null)
			{
				AddChild( StudentDTD.STUDENTPERSONAL_MEDICALALERTMESSAGES, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LocalId&gt;</c> element.
	/// </summary>
	/// <value> The <c>LocalId</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string LocalId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STUDENTPERSONAL_LOCALID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENTPERSONAL_LOCALID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StateProvinceId&gt;</c> element.
	/// </summary>
	/// <value> The <c>StateProvinceId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The state-assigned identifier for this student."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string StateProvinceId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STUDENTPERSONAL_STATEPROVINCEID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENTPERSONAL_STATEPROVINCEID, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;ElectronicIdList&gt;</c> element.</summary>
	/// <param name="ElectronicId">An ElectronicId</param>
	///<remarks>
	/// <para>This form of <c>setElectronicIdList</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>ElectronicIdList</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetElectronicIdList( ElectronicId ElectronicId ) {
		RemoveChild( StudentDTD.STUDENTPERSONAL_ELECTRONICIDLIST);
		AddChild( StudentDTD.STUDENTPERSONAL_ELECTRONICIDLIST, new ElectronicIdList( ElectronicId ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ElectronicIdList&gt;</c> element.
	/// </summary>
	/// <value> An ElectronicIdList </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Electronic identifier(s) associated with this entity."</para>
	/// <para>To remove the <c>ElectronicIdList</c>, set <c>ElectronicIdList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public ElectronicIdList ElectronicIdList
	{
		get
		{
			return (ElectronicIdList)GetChild( StudentDTD.STUDENTPERSONAL_ELECTRONICIDLIST);
		}
		set
		{
			RemoveChild( StudentDTD.STUDENTPERSONAL_ELECTRONICIDLIST);
			if( value != null)
			{
				AddChild( StudentDTD.STUDENTPERSONAL_ELECTRONICIDLIST, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;OtherIdList&gt;</c> element.
	/// </summary>
	/// <value> An OtherIdList </value>
	/// <remarks>
	/// <para>To remove the <c>OtherIdList</c>, set <c>OtherIdList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public OtherIdList OtherIdList
	{
		get
		{
			return (OtherIdList)GetChild( StudentDTD.STUDENTPERSONAL_OTHERIDLIST);
		}
		set
		{
			RemoveChild( StudentDTD.STUDENTPERSONAL_OTHERIDLIST);
			if( value != null)
			{
				AddChild( StudentDTD.STUDENTPERSONAL_OTHERIDLIST, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;PersonInfo&gt;</c> element.</summary>
	/// <param name="Name">The name of the person. Note: Type attribute value of LGL must be used here.</param>
	///<remarks>
	/// <para>This form of <c>setPersonInfo</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>PersonInfo</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetPersonInfo( Name Name ) {
		RemoveChild( StudentDTD.STUDENTPERSONAL_PERSONINFO);
		AddChild( StudentDTD.STUDENTPERSONAL_PERSONINFO, new PersonInfo( Name ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PersonInfo&gt;</c> element.
	/// </summary>
	/// <value> A PersonInfo </value>
	/// <remarks>
	/// <para>To remove the <c>PersonInfo</c>, set <c>PersonInfo</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public PersonInfo PersonInfo
	{
		get
		{
			return (PersonInfo)GetChild( StudentDTD.STUDENTPERSONAL_PERSONINFO);
		}
		set
		{
			RemoveChild( StudentDTD.STUDENTPERSONAL_PERSONINFO);
			if( value != null)
			{
				AddChild( StudentDTD.STUDENTPERSONAL_PERSONINFO, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ProjectedGraduationYear&gt;</c> element.
	/// </summary>
	/// <value> The <c>ProjectedGraduationYear</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Currently projected graduation year."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public int? ProjectedGraduationYear
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( StudentDTD.STUDENTPERSONAL_PROJECTEDGRADUATIONYEAR ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENTPERSONAL_PROJECTEDGRADUATIONYEAR, new SifInt( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;OnTimeGraduationYear&gt;</c> element.
	/// </summary>
	/// <value> The <c>OnTimeGraduationYear</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "First projected graduation year, usually determined when student is accepted into 9th grade."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public int? OnTimeGraduationYear
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( StudentDTD.STUDENTPERSONAL_ONTIMEGRADUATIONYEAR ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENTPERSONAL_ONTIMEGRADUATIONYEAR, new SifInt( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;GraduationDate&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;PartialDateType&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setGraduationDate</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>GraduationDate</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetGraduationDate( string Value ) {
		RemoveChild( StudentDTD.STUDENTPERSONAL_GRADUATIONDATE);
		AddChild( StudentDTD.STUDENTPERSONAL_GRADUATIONDATE, new PartialDateType( Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;GraduationDate&gt;</c> element.
	/// </summary>
	/// <value> A PartialDateType </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Date student officially graduated from secondary education."</para>
	/// <para>To remove the <c>PartialDateType</c>, set <c>GraduationDate</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public PartialDateType GraduationDate
	{
		get
		{
			return (PartialDateType)GetChild( StudentDTD.STUDENTPERSONAL_GRADUATIONDATE);
		}
		set
		{
			RemoveChild( StudentDTD.STUDENTPERSONAL_GRADUATIONDATE);
			if( value != null)
			{
				AddChild( StudentDTD.STUDENTPERSONAL_GRADUATIONDATE, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;MostRecent&gt;</c> element.
	/// </summary>
	/// <value> A MostRecent </value>
	/// <remarks>
	/// <para>To remove the <c>MostRecent</c>, set <c>MostRecent</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public MostRecent MostRecent
	{
		get
		{
			return (MostRecent)GetChild( StudentDTD.STUDENTPERSONAL_MOSTRECENT);
		}
		set
		{
			RemoveChild( StudentDTD.STUDENTPERSONAL_MOSTRECENT);
			if( value != null)
			{
				AddChild( StudentDTD.STUDENTPERSONAL_MOSTRECENT, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AcceptableUsePolicy&gt;</c> element.
	/// </summary>
	/// <value> The <c>AcceptableUsePolicy</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Does the student have a current signed Acceptable Use Policy document for system access?"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string AcceptableUsePolicy
	{
		get
		{ 
			return GetFieldValue( StudentDTD.STUDENTPERSONAL_ACCEPTABLEUSEPOLICY );
		}
		set
		{
			SetField( StudentDTD.STUDENTPERSONAL_ACCEPTABLEUSEPOLICY, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;AcceptableUsePolicy&gt;</c> element.
	/// </summary>
	/// <param name="val">A AUCodeSetsYesOrNoCategoryType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Does the student have a current signed Acceptable Use Policy document for system access?"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetAcceptableUsePolicy( AUCodeSetsYesOrNoCategoryType val )
	{
		SetField( StudentDTD.STUDENTPERSONAL_ACCEPTABLEUSEPOLICY, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;EconomicDisadvantage&gt;</c> element.
	/// </summary>
	/// <value> The <c>EconomicDisadvantage</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Does the student meet the State criteria for classification as having an economic disadvantage?"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string EconomicDisadvantage
	{
		get
		{ 
			return GetFieldValue( StudentDTD.STUDENTPERSONAL_ECONOMICDISADVANTAGE );
		}
		set
		{
			SetField( StudentDTD.STUDENTPERSONAL_ECONOMICDISADVANTAGE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;EconomicDisadvantage&gt;</c> element.
	/// </summary>
	/// <param name="val">A AUCodeSetsYesOrNoCategoryType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Does the student meet the State criteria for classification as having an economic disadvantage?"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetEconomicDisadvantage( AUCodeSetsYesOrNoCategoryType val )
	{
		SetField( StudentDTD.STUDENTPERSONAL_ECONOMICDISADVANTAGE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;GiftedTalented&gt;</c> element.
	/// </summary>
	/// <value> The <c>GiftedTalented</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string GiftedTalented
	{
		get
		{ 
			return GetFieldValue( StudentDTD.STUDENTPERSONAL_GIFTEDTALENTED );
		}
		set
		{
			SetField( StudentDTD.STUDENTPERSONAL_GIFTEDTALENTED, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;GiftedTalented&gt;</c> element.
	/// </summary>
	/// <param name="val">A AUCodeSetsYesOrNoCategoryType object</param>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetGiftedTalented( AUCodeSetsYesOrNoCategoryType val )
	{
		SetField( StudentDTD.STUDENTPERSONAL_GIFTEDTALENTED, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ESL&gt;</c> element.
	/// </summary>
	/// <value> The <c>ESL</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Does the student meet ‘English as a Second Language Criteria’?"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string ESL
	{
		get
		{ 
			return GetFieldValue( StudentDTD.STUDENTPERSONAL_ESL );
		}
		set
		{
			SetField( StudentDTD.STUDENTPERSONAL_ESL, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;ESL&gt;</c> element.
	/// </summary>
	/// <param name="val">A AUCodeSetsYesOrNoCategoryType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Does the student meet ‘English as a Second Language Criteria’?"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetESL( AUCodeSetsYesOrNoCategoryType val )
	{
		SetField( StudentDTD.STUDENTPERSONAL_ESL, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;YoungCarersRole&gt;</c> element.
	/// </summary>
	/// <value> The <c>YoungCarersRole</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Is the student a carer of other family members?"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string YoungCarersRole
	{
		get
		{ 
			return GetFieldValue( StudentDTD.STUDENTPERSONAL_YOUNGCARERSROLE );
		}
		set
		{
			SetField( StudentDTD.STUDENTPERSONAL_YOUNGCARERSROLE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;YoungCarersRole&gt;</c> element.
	/// </summary>
	/// <param name="val">A AUCodeSetsYesOrNoCategoryType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Is the student a carer of other family members?"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetYoungCarersRole( AUCodeSetsYesOrNoCategoryType val )
	{
		SetField( StudentDTD.STUDENTPERSONAL_YOUNGCARERSROLE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Disability&gt;</c> element.
	/// </summary>
	/// <value> The <c>Disability</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Does the student have funding for disability?"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string Disability
	{
		get
		{ 
			return GetFieldValue( StudentDTD.STUDENTPERSONAL_DISABILITY );
		}
		set
		{
			SetField( StudentDTD.STUDENTPERSONAL_DISABILITY, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;Disability&gt;</c> element.
	/// </summary>
	/// <param name="val">A AUCodeSetsYesOrNoCategoryType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Does the student have funding for disability?"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetDisability( AUCodeSetsYesOrNoCategoryType val )
	{
		SetField( StudentDTD.STUDENTPERSONAL_DISABILITY, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;IntegrationAide&gt;</c> element.
	/// </summary>
	/// <value> The <c>IntegrationAide</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Does the Student require an Integration Aide?"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string IntegrationAide
	{
		get
		{ 
			return GetFieldValue( StudentDTD.STUDENTPERSONAL_INTEGRATIONAIDE );
		}
		set
		{
			SetField( StudentDTD.STUDENTPERSONAL_INTEGRATIONAIDE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;IntegrationAide&gt;</c> element.
	/// </summary>
	/// <param name="val">A AUCodeSetsYesOrNoCategoryType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Does the Student require an Integration Aide?"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetIntegrationAide( AUCodeSetsYesOrNoCategoryType val )
	{
		SetField( StudentDTD.STUDENTPERSONAL_INTEGRATIONAIDE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PrePrimaryEducation&gt;</c> element.
	/// </summary>
	/// <value> The <c>PrePrimaryEducation</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Care prior to kinder enrolment (eg. Family day care/home/extended care etc)."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string PrePrimaryEducation
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STUDENTPERSONAL_PREPRIMARYEDUCATION ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENTPERSONAL_PREPRIMARYEDUCATION, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;FirstAUSchoolEnrollment&gt;</c> element.
	/// </summary>
	/// <value> The <c>FirstAUSchoolEnrollment</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Date of the first enrolment in an Australian School"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public DateTime? FirstAUSchoolEnrollment
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( StudentDTD.STUDENTPERSONAL_FIRSTAUSCHOOLENROLLMENT ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENTPERSONAL_FIRSTAUSCHOOLENROLLMENT, new SifDate( value ), value );
		}
	}

}}
