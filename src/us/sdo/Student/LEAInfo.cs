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

namespace OpenADK.Library.us.Student{

/// <summary>This object contains information about a school district or other Local Educational Agency (LEA). SIF_Events are reported.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.5r1</para>
/// </remarks>
[Serializable]
public class LEAInfo : SifDataObject
{
	/// <summary>
	/// Creates an instance of a LEAInfo
	/// </summary>
	public LEAInfo() : base( Adk.SifVersion, StudentDTD.LEAINFO ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">The GUID of the LEA whose information this is.</param>
	///<param name="leaName">Name of LEA.</param>
	///
	public LEAInfo( string refId, string leaName ) : base( Adk.SifVersion, StudentDTD.LEAINFO )
	{
		this.RefId = refId;
		this.LEAName = leaName;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected LEAInfo( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { StudentDTD.LEAINFO_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The GUID of the LEA whose information this is."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.LEAINFO_REFID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.LEAINFO_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LocalId&gt;</c> element.
	/// </summary>
	/// <value> The <c>LocalId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The locally-assigned identifier for this LEA."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string LocalId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.LEAINFO_LOCALID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.LEAINFO_LOCALID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StateProvinceId&gt;</c> element.
	/// </summary>
	/// <value> The <c>StateProvinceId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The state-assigned identifier for this LEA."</para>
	/// <para>This element is known by more than one tag name depending on the version of SIF in use. 
	/// The ADK will use the tag names shown below when parsing and rendering elements of this kind.</para>
	/// <list type="table"><listheader><term>Version</term><description>Tag</description></listheader>;
	/// <item><term>2.0 (and greater)</term><description>&lt;StateProvinceId&gt;</description></item>
	/// </list>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string StateProvinceId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.LEAINFO_STATEPROVINCEID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.LEAINFO_STATEPROVINCEID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;NCESId&gt;</c> element.
	/// </summary>
	/// <value> The <c>NCESId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The NCES-assigned identifier for this LEA."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string NCESId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.LEAINFO_NCESID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.LEAINFO_NCESID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LEAName&gt;</c> element.
	/// </summary>
	/// <value> The <c>LEAName</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Name of LEA."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string LEAName
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.LEAINFO_LEANAME ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.LEAINFO_LEANAME, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LEAURL&gt;</c> element.
	/// </summary>
	/// <value> The <c>LEAURL</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "URL for the LEA."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string LEAURL
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.LEAINFO_LEAURL ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.LEAINFO_LEAURL, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;EducationAgencyType&gt;</c> element.</summary>
	/// <param name="Code">Code indicating the operational/administrative level.</param>
	///<remarks>
	/// <para>This form of <c>setEducationAgencyType</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>EducationAgencyType</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void SetEducationAgencyType( EducationAgencyTypeCode Code ) {
		RemoveChild( StudentDTD.LEAINFO_EDUCATIONAGENCYTYPE);
		AddChild( StudentDTD.LEAINFO_EDUCATIONAGENCYTYPE, new EducationAgencyType( Code ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;EducationAgencyType&gt;</c> element.
	/// </summary>
	/// <value> An EducationAgencyType </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The classification of the education agency within the geographic boundaries of a state according to the level of administrative and operational control."</para>
	/// <para>To remove the <c>EducationAgencyType</c>, set <c>EducationAgencyType</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public EducationAgencyType EducationAgencyType
	{
		get
		{
			return (EducationAgencyType)GetChild( StudentDTD.LEAINFO_EDUCATIONAGENCYTYPE);
		}
		set
		{
			RemoveChild( StudentDTD.LEAINFO_EDUCATIONAGENCYTYPE);
			if( value != null)
			{
				AddChild( StudentDTD.LEAINFO_EDUCATIONAGENCYTYPE, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LEAContactList&gt;</c> element.
	/// </summary>
	/// <value> A LEAContactList </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Information on contact persons for this LEA."</para>
	/// <para>To remove the <c>LEAContactList</c>, set <c>LEAContactList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public LEAContactList LEAContactList
	{
		get
		{
			return (LEAContactList)GetChild( StudentDTD.LEAINFO_LEACONTACTLIST);
		}
		set
		{
			RemoveChild( StudentDTD.LEAINFO_LEACONTACTLIST);
			if( value != null)
			{
				AddChild( StudentDTD.LEAINFO_LEACONTACTLIST, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PhoneNumberList&gt;</c> element.
	/// </summary>
	/// <value> A PhoneNumberList </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The LEA's phone number(s)."</para>
	/// <para>To remove the <c>PhoneNumberList</c>, set <c>PhoneNumberList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public PhoneNumberList PhoneNumberList
	{
		get
		{
			return (PhoneNumberList)GetChild( StudentDTD.LEAINFO_PHONENUMBERLIST);
		}
		set
		{
			RemoveChild( StudentDTD.LEAINFO_PHONENUMBERLIST);
			if( value != null)
			{
				AddChild( StudentDTD.LEAINFO_PHONENUMBERLIST, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AddressList&gt;</c> element.
	/// </summary>
	/// <value> An AddressList </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The LEA's address(es)."</para>
	/// <para>To remove the <c>AddressList</c>, set <c>AddressList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public AddressList AddressList
	{
		get
		{
			return (AddressList)GetChild( StudentDTD.LEAINFO_ADDRESSLIST);
		}
		set
		{
			RemoveChild( StudentDTD.LEAINFO_ADDRESSLIST);
			if( value != null)
			{
				AddChild( StudentDTD.LEAINFO_ADDRESSLIST, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;IdentificationInfoList&gt;</c> element.
	/// </summary>
	/// <value> An IdentificationInfoList </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Other identification information associated with an LEA, such as the locally-defined code/identifier, etc."</para>
	/// <para>To remove the <c>IdentificationInfoList</c>, set <c>IdentificationInfoList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public IdentificationInfoList IdentificationInfoList
	{
		get
		{
			return (IdentificationInfoList)GetChild( StudentDTD.LEAINFO_IDENTIFICATIONINFOLIST);
		}
		set
		{
			RemoveChild( StudentDTD.LEAINFO_IDENTIFICATIONINFOLIST);
			if( value != null)
			{
				AddChild( StudentDTD.LEAINFO_IDENTIFICATIONINFOLIST, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;GradeLevels&gt;</c> element.
	/// </summary>
	/// <value> A GradeLevels </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Collection of grade levels offered in this LEA."</para>
	/// <para>To remove the <c>GradeLevels</c>, set <c>GradeLevels</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public GradeLevels GradeLevels
	{
		get
		{
			return (GradeLevels)GetChild( StudentDTD.LEAINFO_GRADELEVELS);
		}
		set
		{
			RemoveChild( StudentDTD.LEAINFO_GRADELEVELS);
			if( value != null)
			{
				AddChild( StudentDTD.LEAINFO_GRADELEVELS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;OperationalStatus&gt;</c> element.
	/// </summary>
	/// <value> The <c>OperationalStatus</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Operational condition of an LEA."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string OperationalStatus
	{
		get
		{ 
			return GetFieldValue( StudentDTD.LEAINFO_OPERATIONALSTATUS );
		}
		set
		{
			SetField( StudentDTD.LEAINFO_OPERATIONALSTATUS, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;OperationalStatus&gt;</c> element.
	/// </summary>
	/// <param name="val">A OperationalStatus object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Operational condition of an LEA."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void SetOperationalStatus( OperationalStatus val )
	{
		SetField( StudentDTD.LEAINFO_OPERATIONALSTATUS, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;CongressionalDistrict&gt;</c> element.
	/// </summary>
	/// <value> The <c>CongressionalDistrict</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Number for the US congressional district where the LEA is located."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string CongressionalDistrict
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.LEAINFO_CONGRESSIONALDISTRICT ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.LEAINFO_CONGRESSIONALDISTRICT, new SifString( value ), value );
		}
	}

}}
